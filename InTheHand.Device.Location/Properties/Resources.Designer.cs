﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InTheHand.Device.Location.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InTheHand.Device.Location.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The coordinate&apos;s latitude or longitude is not a number.
        ///.
        /// </summary>
        internal static string Argument_LatitudeOrLongitudeIsNotANumber {
            get {
                return ResourceManager.GetString("Argument_LatitudeOrLongitudeIsNotANumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the parameter must be from -180.0 to 180.0..
        /// </summary>
        internal static string Argument_MustBeInRangeNegative180To180 {
            get {
                return ResourceManager.GetString("Argument_MustBeInRangeNegative180To180", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the parameter must be from -90.0 to 90.0..
        /// </summary>
        internal static string Argument_MustBeInRangeNegative90to90 {
            get {
                return ResourceManager.GetString("Argument_MustBeInRangeNegative90to90", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the parameter must be from 0.0 to 360.0..
        /// </summary>
        internal static string Argument_MustBeInRangeZeroTo360 {
            get {
                return ResourceManager.GetString("Argument_MustBeInRangeZeroTo360", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the parameter must be greater than or equal to zero..
        /// </summary>
        internal static string Argument_MustBeNonNegative {
            get {
                return ResourceManager.GetString("Argument_MustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one address field is required..
        /// </summary>
        internal static string Argument_RequiresAtLeastOneNonEmptyStringParameter {
            get {
                return ResourceManager.GetString("Argument_RequiresAtLeastOneNonEmptyStringParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        internal static string Unknown {
            get {
                return ResourceManager.GetString("Unknown", resourceCulture);
            }
        }
    }
}