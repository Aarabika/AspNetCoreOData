﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.OData.Abstracts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SRResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.OData.Abstracts.Properties.SRResources", typeof(SRResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Relative URI values are not supported: &apos;{0}&apos;. The URI must be absolute..
        /// </summary>
        internal static string ArgumentInvalidAbsoluteUri {
            get {
                return ResourceManager.GetString("ArgumentInvalidAbsoluteUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported URI scheme: &apos;{0}&apos;. The URI scheme must be either &apos;{1}&apos; or &apos;{2}&apos;..
        /// </summary>
        internal static string ArgumentInvalidHttpUriScheme {
            get {
                return ResourceManager.GetString("ArgumentInvalidHttpUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than or equal to {0}..
        /// </summary>
        internal static string ArgumentMustBeGreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentMustBeGreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be less than or equal to {0}..
        /// </summary>
        internal static string ArgumentMustBeLessThanOrEqualTo {
            get {
                return ResourceManager.GetString("ArgumentMustBeLessThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to URI must not contain a query component or a fragment identifier..
        /// </summary>
        internal static string ArgumentUriHasQueryOrFragment {
            get {
                return ResourceManager.GetString("ArgumentUriHasQueryOrFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic dictionary property &apos;{0}&apos; of type &apos;{1}&apos; cannot be set. The dynamic property dictionary must have a setter..
        /// </summary>
        internal static string CannotSetDynamicPropertyDictionary {
            get {
                return ResourceManager.GetString("CannotSetDynamicPropertyDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actual entity type &apos;{0}&apos; is not assignable to the expected type &apos;{1}&apos;..
        /// </summary>
        internal static string DeltaEntityTypeNotAssignable {
            get {
                return ResourceManager.GetString("DeltaEntityTypeNotAssignable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find nested resource name &apos;{0}&apos; in parent resource type &apos;{1}&apos;.
        /// </summary>
        internal static string DeltaNestedResourceNameNotFound {
            get {
                return ResourceManager.GetString("DeltaNestedResourceNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use Delta of type &apos;{0}&apos; on an entity of type &apos;{1}&apos;..
        /// </summary>
        internal static string DeltaTypeMismatch {
            get {
                return ResourceManager.GetString("DeltaTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get property &apos;{0}&apos; of a null EDM object of type &apos;{1}&apos;..
        /// </summary>
        internal static string EdmComplexObjectNullRef {
            get {
                return ResourceManager.GetString("EdmComplexObjectNullRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported EDM type..
        /// </summary>
        internal static string EdmTypeNotSupported {
            get {
                return ResourceManager.GetString("EdmTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of argument &apos;{0}&apos; ({1}) is invalid for Enum type &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidEnumArgument {
            get {
                return ResourceManager.GetString("InvalidEnumArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one matching CLR type found for the EDM type {0}.\nThe matching CLR types are {1}..
        /// </summary>
        internal static string MultipleMatchingClrTypesForEdmType {
            get {
                return ResourceManager.GetString("MultipleMatchingClrTypesForEdmType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a boolean..
        /// </summary>
        internal static string PropertyMustBeBoolean {
            get {
                return ResourceManager.GetString("PropertyMustBeBoolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a DateTimeOffset or Date..
        /// </summary>
        internal static string PropertyMustBeDateTimeOffsetOrDate {
            get {
                return ResourceManager.GetString("PropertyMustBeDateTimeOffsetOrDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value with type &apos;{0}&apos; must have type &apos;{1}&apos;..
        /// </summary>
        internal static string PropertyMustBeEnum {
            get {
                return ResourceManager.GetString("PropertyMustBeEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string..
        /// </summary>
        internal static string PropertyMustBeString {
            get {
                return ResourceManager.GetString("PropertyMustBeString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string with a length of 1..
        /// </summary>
        internal static string PropertyMustBeStringLengthOne {
            get {
                return ResourceManager.GetString("PropertyMustBeStringLengthOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a string with a maximum length of 1..
        /// </summary>
        internal static string PropertyMustBeStringMaxLengthOne {
            get {
                return ResourceManager.GetString("PropertyMustBeStringMaxLengthOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be a Edm.TimeOfDay..
        /// </summary>
        internal static string PropertyMustBeTimeOfDay {
            get {
                return ResourceManager.GetString("PropertyMustBeTimeOfDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; must be an enum or Nullable&lt;T&gt; where T is an enum type..
        /// </summary>
        internal static string TypeMustBeEnumOrNullableEnum {
            get {
                return ResourceManager.GetString("TypeMustBeEnumOrNullableEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The element type &apos;{0}&apos; of the given collection type &apos;{1}&apos; is not of the type &apos;{2}&apos;..
        /// </summary>
        internal static string UnexpectedElementType {
            get {
                return ResourceManager.GetString("UnexpectedElementType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The EDM type &apos;{0}&apos; of kind &apos;{1}&apos; is not supported..
        /// </summary>
        internal static string UnsupportedEdmType {
            get {
                return ResourceManager.GetString("UnsupportedEdmType", resourceCulture);
            }
        }
    }
}