﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prism.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Prism.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 The object must be of type &apos;{0}&apos; in order to use the current region adapter. 的本地化字符串。
        /// </summary>
        internal static string AdapterInvalidTypeException {
            get {
                return ResourceManager.GetString("AdapterInvalidTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot change the region name once is set. The current region name is &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string CannotChangeRegionNameException {
            get {
                return ResourceManager.GetString("CannotChangeRegionNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot create navigation target &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string CannotCreateNavigationTarget {
            get {
                return ResourceManager.GetString("CannotCreateNavigationTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type &apos;{0}&apos; does not implement from IRegionBehavior. 的本地化字符串。
        /// </summary>
        internal static string CanOnlyAddTypesThatInheritIFromRegionBehavior {
            get {
                return ResourceManager.GetString("CanOnlyAddTypesThatInheritIFromRegionBehavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The ConfigurationStore cannot contain a null value.  的本地化字符串。
        /// </summary>
        internal static string ConfigurationStoreCannotBeNull {
            get {
                return ResourceManager.GetString("ConfigurationStoreCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ContentControl&apos;s Content property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s Content property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property. 的本地化字符串。
        /// </summary>
        internal static string ContentControlHasContentException {
            get {
                return ResourceManager.GetString("ContentControlHasContentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Deactivation is not possible in this type of region. 的本地化字符串。
        /// </summary>
        internal static string DeactiveNotPossibleException {
            get {
                return ResourceManager.GetString("DeactiveNotPossibleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {1}: {2}. Priority: {3}. Timestamp:{0:u}. 的本地化字符串。
        /// </summary>
        internal static string DefaultTextLoggerPattern {
            get {
                return ResourceManager.GetString("DefaultTextLoggerPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Neither the executeMethod nor the canExecuteMethod delegates can be null. 的本地化字符串。
        /// </summary>
        internal static string DelegateCommandDelegatesCannotBeNull {
            get {
                return ResourceManager.GetString("DelegateCommandDelegatesCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 T for DelegateCommand&lt;T&gt; is not an object nor Nullable. 的本地化字符串。
        /// </summary>
        internal static string DelegateCommandInvalidGenericPayloadType {
            get {
                return ResourceManager.GetString("DelegateCommandInvalidGenericPayloadType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Directory {0} was not found. 的本地化字符串。
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A duplicated module group with name {0} has been found by the loader. 的本地化字符串。
        /// </summary>
        internal static string DuplicatedModuleGroup {
            get {
                return ResourceManager.GetString("DuplicatedModuleGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to retrieve the module type {0} from the loaded assemblies.  You may need to specify a more fully-qualified type name. 的本地化字符串。
        /// </summary>
        internal static string FailedToGetType {
            get {
                return ResourceManager.GetString("FailedToGetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 HostControl cannot have null value when behavior attaches.  的本地化字符串。
        /// </summary>
        internal static string HostControlCannotBeNull {
            get {
                return ResourceManager.GetString("HostControlCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The HostControl property cannot be set after Attach method has been called. 的本地化字符串。
        /// </summary>
        internal static string HostControlCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("HostControlCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 HostControl type must be a TabControl. 的本地化字符串。
        /// </summary>
        internal static string HostControlMustBeATabControl {
            get {
                return ResourceManager.GetString("HostControlMustBeATabControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The IModuleEnumerator interface is no longer used and has been replaced by ModuleCatalog. 的本地化字符串。
        /// </summary>
        internal static string IEnumeratorObsolete {
            get {
                return ResourceManager.GetString("IEnumeratorObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The argument must be a valid absolute Uri to an assembly file. 的本地化字符串。
        /// </summary>
        internal static string InvalidArgumentAssemblyUri {
            get {
                return ResourceManager.GetString("InvalidArgumentAssemblyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Target of the IDelegateReference should be of type {0}. 的本地化字符串。
        /// </summary>
        internal static string InvalidDelegateRerefenceTypeException {
            get {
                return ResourceManager.GetString("InvalidDelegateRerefenceTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ItemsControl&apos;s ItemsSource property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s ItemSource property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property. 的本地化字符串。
        /// </summary>
        internal static string ItemsControlHasItemsSourceException {
            get {
                return ResourceManager.GetString("ItemsControlHasItemsSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Mapping with the given type is already registered: {0}. 的本地化字符串。
        /// </summary>
        internal static string MappingExistsException {
            get {
                return ResourceManager.GetString("MappingExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Module {0} was not found in the catalog. 的本地化字符串。
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The ModulePath cannot contain a null value or be empty 的本地化字符串。
        /// </summary>
        internal static string ModulePathCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ModulePathCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to load type &apos;{0}&apos; from assembly &apos;{1}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ModuleTypeNotFound {
            get {
                return ResourceManager.GetString("ModuleTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The ModuleCatalog must implement IModuleGroupCatalog to add groups 的本地化字符串。
        /// </summary>
        internal static string MustBeModuleGroupCatalog {
            get {
                return ResourceManager.GetString("MustBeModuleGroupCatalog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Navigation is already in progress on region with name &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string NavigationInProgress {
            get {
                return ResourceManager.GetString("NavigationInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Navigation cannot proceed until a region is set for the RegionNavigationService. 的本地化字符串。
        /// </summary>
        internal static string NavigationServiceHasNoRegion {
            get {
                return ResourceManager.GetString("NavigationServiceHasNoRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The IRegionAdapter for the type {0} is not registered in the region adapter mappings. You can register an IRegionAdapter for this control by overriding the ConfigureRegionAdapterMappings method in the bootstrapper. 的本地化字符串。
        /// </summary>
        internal static string NoRegionAdapterException {
            get {
                return ResourceManager.GetString("NoRegionAdapterException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There is currently no moduleTypeLoader in the ModuleManager that can retrieve the specified module. 的本地化字符串。
        /// </summary>
        internal static string NoRetrieverCanRetrieveModule {
            get {
                return ResourceManager.GetString("NoRetrieverCanRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An exception has occurred while trying to add a view to region &apos;{0}&apos;. 
        ///    - The most likely causing exception was was: &apos;{1}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException().  的本地化字符串。
        /// </summary>
        internal static string OnViewRegisteredException {
            get {
                return ResourceManager.GetString("OnViewRegisteredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The member access expression does not access a property. 的本地化字符串。
        /// </summary>
        internal static string PropertySupport_ExpressionNotProperty_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_ExpressionNotProperty_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The expression is not a member access expression. 的本地化字符串。
        /// </summary>
        internal static string PropertySupport_NotMemberAccessExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_NotMemberAccessExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The referenced property is a static property. 的本地化字符串。
        /// </summary>
        internal static string PropertySupport_StaticExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_StaticExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Attach method cannot be called when Region property is null. 的本地化字符串。
        /// </summary>
        internal static string RegionBehaviorAttachCannotBeCallWithNullRegion {
            get {
                return ResourceManager.GetString("RegionBehaviorAttachCannotBeCallWithNullRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Region property cannot be set after Attach method has been called. 的本地化字符串。
        /// </summary>
        internal static string RegionBehaviorRegionCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("RegionBehaviorRegionCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An exception occurred while creating a region with name &apos;{0}&apos;. The exception was: {1}.  的本地化字符串。
        /// </summary>
        internal static string RegionCreationException {
            get {
                return ResourceManager.GetString("RegionCreationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The region being added already has a name of &apos;{0}&apos; and cannot be added to the region manager with a different name (&apos;{1}&apos;). 的本地化字符串。
        /// </summary>
        internal static string RegionManagerWithDifferentNameException {
            get {
                return ResourceManager.GetString("RegionManagerWithDifferentNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The region name cannot be null or empty. 的本地化字符串。
        /// </summary>
        internal static string RegionNameCannotBeEmptyException {
            get {
                return ResourceManager.GetString("RegionNameCannotBeEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Region with the given name is already registered: {0} 的本地化字符串。
        /// </summary>
        internal static string RegionNameExistsException {
            get {
                return ResourceManager.GetString("RegionNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This RegionManager does not contain a Region with the name &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string RegionNotFound {
            get {
                return ResourceManager.GetString("RegionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The region manager does not contain the {0} region. 的本地化字符串。
        /// </summary>
        internal static string RegionNotInRegionManagerException {
            get {
                return ResourceManager.GetString("RegionNotInRegionManagerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 View already exists in region. 的本地化字符串。
        /// </summary>
        internal static string RegionViewExistsException {
            get {
                return ResourceManager.GetString("RegionViewExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 View with name &apos;{0}&apos; already exists in the region. 的本地化字符串。
        /// </summary>
        internal static string RegionViewNameExistsException {
            get {
                return ResourceManager.GetString("RegionViewNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The provided String argument {0} must not be null or empty. 的本地化字符串。
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The provided String argument {0} must not be null or empty. 的本地化字符串。
        /// </summary>
        internal static string StringCannotBeNullOrEmpty1 {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No BehaviorType with key &apos;{0}&apos; was registered. 的本地化字符串。
        /// </summary>
        internal static string TypeWithKeyNotRegistered {
            get {
                return ResourceManager.GetString("TypeWithKeyNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An exception occurred while trying to create region objects. 
        ///    - The most likely causing exception was: &apos;{0}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException().  的本地化字符串。
        /// </summary>
        internal static string UpdateRegionException {
            get {
                return ResourceManager.GetString("UpdateRegionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The value must be of type ModuleInfo. 的本地化字符串。
        /// </summary>
        internal static string ValueMustBeOfTypeModuleInfo {
            get {
                return ResourceManager.GetString("ValueMustBeOfTypeModuleInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} not found. 的本地化字符串。
        /// </summary>
        internal static string ValueNotFound {
            get {
                return ResourceManager.GetString("ValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The region does not contain the specified view. 的本地化字符串。
        /// </summary>
        internal static string ViewNotInRegionException {
            get {
                return ResourceManager.GetString("ViewNotInRegionException", resourceCulture);
            }
        }
    }
}
