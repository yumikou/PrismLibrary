using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Prism.Regions
{
    /// <summary>
    /// Implementation of <see cref="IViewsCollection"/> that takes an <see cref="ObservableCollection{T}"/> of <see cref="ItemMetadata"/>
    /// and filters it to display an <see cref="INotifyCollectionChanged"/> collection of
    /// <see cref="object"/> elements (the items which the <see cref="ItemMetadata"/> wraps).
    /// </summary>
    public class ViewsCollection : IViewsCollection
    {
        private readonly ObservableCollection<ItemMetadata> subjectCollection;

        private readonly Dictionary<ItemMetadata, MonitorInfo> monitoredItems =
            new Dictionary<ItemMetadata, MonitorInfo>();

        private readonly Predicate<ItemMetadata> filter;
        private Comparison<object> sort;
        private List<object> filteredItems = new List<object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewsCollection"/> class.
        /// </summary>
        /// <param name="list">The list to wrap and filter.</param>
        /// <param name="filter">A predicate to filter the <paramref name="list"/> collection.</param>
        public ViewsCollection(ObservableCollection<ItemMetadata> list, Predicate<ItemMetadata> filter)
        {
            this.subjectCollection = list;
            this.filter = filter;
            this.MonitorAllMetadataItems();
            this.subjectCollection.CollectionChanged += this.SourceCollectionChanged;
            this.UpdateFilteredItemsList();
        }

        /// <summary>
        /// Occurs when the collection changes.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event EventHandler<NavigationNotifyCollectionChangedEventArgs> NavigationCollectionChanged;

        /// <summary>
        /// Gets or sets the comparison used to sort the views.
        /// </summary>
        /// <value>The comparison to use.</value>
        public Comparison<object> SortComparison
        {
            get { return this.sort; }
            set
            {
                if (this.sort != value)
                {
                    this.sort = value;
                    this.UpdateFilteredItemsList();
                    this.OnCollectionChanged(new NavigationNotifyCollectionChangedEventArgs(null, NotifyCollectionChangedAction.Reset));
                }
            }
        }

        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        /// <param name="value">The object to locate in the collection.</param>
        /// <returns><see langword="true" /> if <paramref name="value"/> is found in the collection; otherwise, <see langword="false" />.</returns>
        public bool Contains(object value)
        {
            return this.filteredItems.Contains(value);
        }

        ///<summary>
        ///Returns an enumerator that iterates through the collection.
        ///</summary>
        ///<returns>
        ///A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        ///</returns>
        public IEnumerator<object> GetEnumerator()
        {
            return this.filteredItems.GetEnumerator();
        }

        ///<summary>
        ///Returns an enumerator that iterates through a collection.
        ///</summary>
        ///<returns>
        ///An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        ///</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Used to invoked the <see cref="CollectionChanged"/> event.
        /// </summary>
        /// <param name="e"></param>
        private void OnCollectionChanged(NavigationNotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if (handler != null) handler(this, e);
            this.NavigationCollectionChanged?.Invoke(this, e);
        }

        private void NotifyReset()
        {
            this.OnCollectionChanged(new NavigationNotifyCollectionChangedEventArgs(null, NotifyCollectionChangedAction.Reset));
        }

        /// <summary>
        /// Removes all monitoring of underlying MetadataItems and re-adds them.
        /// </summary>
        private void ResetAllMonitors()
        {
            this.RemoveAllMetadataMonitors();
            this.MonitorAllMetadataItems();
        }

        /// <summary>
        /// Adds all underlying MetadataItems to the list from the subjectCollection
        /// </summary>
        private void MonitorAllMetadataItems()
        {
            foreach (var item in this.subjectCollection)
            {
                this.AddMetadataMonitor(item, this.filter(item));
            }
        }

        /// <summary>
        /// Removes all monitored items from our monitoring list.
        /// </summary>
        private void RemoveAllMetadataMonitors()
        {
            foreach (var item in this.monitoredItems)
            {
                item.Key.IsActiveChanged -= this.OnItemMetadataIsActiveChanged;
            }

            this.monitoredItems.Clear();
        }

        /// <summary>
        /// Adds handler to monitor the MetadataItem and adds it to our monitoring list.
        /// </summary>
        /// <param name="itemMetadata"></param>
        /// <param name="isInList"></param>
        private void AddMetadataMonitor(ItemMetadata itemMetadata, bool isInList)
        {
            itemMetadata.IsActiveChanged += this.OnItemMetadataIsActiveChanged;
            this.monitoredItems.Add(
                itemMetadata,
                new MonitorInfo
                {
                    IsInList = isInList
                });
        }

        /// <summary>
        /// Unhooks from the MetadataItem change event and removes from our monitoring list.
        /// </summary>
        /// <param name="itemMetadata"></param>
        private void RemoveMetadataMonitor(ItemMetadata itemMetadata)
        {
            itemMetadata.IsActiveChanged -= this.OnItemMetadataIsActiveChanged;
            this.monitoredItems.Remove(itemMetadata);
        }

        /// <summary>
        /// Invoked when any of the underlying ItemMetadata items we're monitoring changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemMetadataIsActiveChanged(object sender, ItemMetadataIsActiveChangedEventArgs e)
        {
            ItemMetadata itemMetadata = (ItemMetadata)sender;

            // Our monitored item may have been removed during another event before
            // our OnItemMetadataChanged got called back, so it's not unexpected
            // that we may not have it in our list.
            MonitorInfo monitorInfo;
            bool foundInfo = this.monitoredItems.TryGetValue(itemMetadata, out monitorInfo);
            if (!foundInfo) return;

            if (this.filter(itemMetadata))
            {
                if (!monitorInfo.IsInList)
                {
                    // This passes our filter and wasn't marked
                    // as in our list so we can consider this
                    // an Add.
                    monitorInfo.IsInList = true;
                    this.UpdateFilteredItemsList();
                    NotifyAdd(itemMetadata.Item, e.NavigationType);
                }
            }
            else
            {
                // This doesn't fit our filter, we remove from our
                // tracking list, but should not remove any monitoring in
                // case it fits our filter in the future.
                monitorInfo.IsInList = false;
                this.RemoveFromFilteredList(itemMetadata.Item, e.NavigationType);
            }
        }

        /// <summary>
        /// The event handler due to changes in the underlying collection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.UpdateFilteredItemsList();
                    foreach (ItemMetadata itemMetadata in e.NewItems)
                    {
                        bool isInFilter = this.filter(itemMetadata);
                        this.AddMetadataMonitor(itemMetadata, isInFilter);
                        if (isInFilter)
                        {
                            NotifyAdd(itemMetadata.Item, null);
                        }
                    }

                    // If we're sorting we can't predict how
                    // the collection has changed on an add so we
                    // resort to a reset notification.
                    if (this.sort != null)
                    {
                        this.NotifyReset();
                    }

                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (ItemMetadata itemMetadata in e.OldItems)
                    {
                        this.RemoveMetadataMonitor(itemMetadata);
                        if (this.filter(itemMetadata))
                        {
                            this.RemoveFromFilteredList(itemMetadata.Item, null);
                        }
                    }

                    break;

                default:
                    this.ResetAllMonitors();
                    this.UpdateFilteredItemsList();
                    this.NotifyReset();

                    break;
            }
        }

        private void NotifyAdd(object item, NavigationType? navigationType)
        {
            int newIndex = this.filteredItems.IndexOf(item);
            this.NotifyAdd(new[] { item }, newIndex, navigationType);
        }

        private void RemoveFromFilteredList(object item, NavigationType? navigationType)
        {
            int index = this.filteredItems.IndexOf(item);
            this.UpdateFilteredItemsList();
            this.NotifyRemove(new[] { item }, index, navigationType);
        }

        private void UpdateFilteredItemsList()
        {
            this.filteredItems = this.subjectCollection.Where(i => this.filter(i)).Select(i => i.Item)
                .OrderBy<object, object>(o => o, new RegionItemComparer(this.SortComparison)).ToList();
        }

        private class MonitorInfo
        {
            public bool IsInList { get; set; }
        }

        private class RegionItemComparer : Comparer<object>
        {
            private readonly Comparison<object> comparer;

            public RegionItemComparer(Comparison<object> comparer)
            {
                this.comparer = comparer;
            }

            public override int Compare(object x, object y)
            {
                if (this.comparer == null)
                {
                    return 0;
                }

                return this.comparer(x, y);
            }
        }

        private void NotifyAdd(IList items, int newStartingIndex, NavigationType? navigationType)
        {
            if (items.Count > 0)
            {
                OnCollectionChanged(new NavigationNotifyCollectionChangedEventArgs(
                                            navigationType,
                                            NotifyCollectionChangedAction.Add,
                                            items,
                                            newStartingIndex));
            }
        }

        private void NotifyRemove(IList items, int originalIndex, NavigationType? navigationType)
        {
            if (items.Count > 0)
            {
                OnCollectionChanged(new NavigationNotifyCollectionChangedEventArgs(
                    navigationType,
                    NotifyCollectionChangedAction.Remove,
                    items,
                    originalIndex));
            }
        }
    }
}
