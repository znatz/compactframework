﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8009
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InTheHand.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InTheHand.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Object must be of type DateTimeOffset..
        /// </summary>
        internal static string Arg_MustBeDateTimeOffset {
            get {
                return ResourceManager.GetString("Arg_MustBeDateTimeOffset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal..
        /// </summary>
        internal static string Argument_ConflictingDateTimeRoundtripStyles {
            get {
                return ResourceManager.GetString("Argument_ConflictingDateTimeRoundtripStyles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together..
        /// </summary>
        internal static string Argument_ConflictingDateTimeStyles {
            get {
                return ResourceManager.GetString("Argument_ConflictingDateTimeStyles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DateTimeStyles value &apos;NoCurrentDateDefault&apos; is not allowed when parsing DateTimeOffset..
        /// </summary>
        internal static string Argument_DateTimeOffsetInvalidDateTimeStyles {
            get {
                return ResourceManager.GetString("Argument_DateTimeOffsetInvalidDateTimeStyles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An undefined DateTimeStyles value is being used..
        /// </summary>
        internal static string Argument_InvalidDateTimeStyles {
            get {
                return ResourceManager.GetString("Argument_InvalidDateTimeStyles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UTC Offset of the local dateTime parameter does not match the offset argument..
        /// </summary>
        internal static string Argument_OffsetLocalMismatch {
            get {
                return ResourceManager.GetString("Argument_OffsetLocalMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field passed in is not a marshaled member of the type &apos;{0}&apos;..
        /// </summary>
        internal static string Argument_OffsetOfFieldNotFound {
            get {
                return ResourceManager.GetString("Argument_OffsetOfFieldNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset must be within plus or minus 14 hours..
        /// </summary>
        internal static string Argument_OffsetOutOfRange {
            get {
                return ResourceManager.GetString("Argument_OffsetOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset must be specified in whole minutes..
        /// </summary>
        internal static string Argument_OffsetPrecision {
            get {
                return ResourceManager.GetString("Argument_OffsetPrecision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UTC Offset for Utc DateTime instances must be 0..
        /// </summary>
        internal static string Argument_OffsetUtcMismatch {
            get {
                return ResourceManager.GetString("Argument_OffsetUtcMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UTC time represented when the offset is applied must be between year 0 and 10,000..
        /// </summary>
        internal static string Argument_UTCOutOfRange {
            get {
                return ResourceManager.GetString("Argument_UTCOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name can be no more than 260 characters in length..
        /// </summary>
        internal static string Argument_WaitHandleNameTooLong {
            get {
                return ResourceManager.GetString("Argument_WaitHandleNameTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This BackgroundWorker is currently busy and cannot run multiple tasks concurrently..
        /// </summary>
        internal static string BackgroundWorker_WorkerAlreadyRunning {
            get {
                return ResourceManager.GetString("BackgroundWorker_WorkerAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This BackgroundWorker states that it doesn&apos;t report progress. Modify WorkerReportsProgress to state that it does report progress..
        /// </summary>
        internal static string BackgroundWorker_WorkerDoesntReportProgress {
            get {
                return ResourceManager.GetString("BackgroundWorker_WorkerDoesntReportProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This BackgroundWorker states that it doesn&apos;t support cancellation. Modify WorkerSupportsCancellation to state that it does support cancellation..
        /// </summary>
        internal static string BackgroundWorker_WorkerDoesntSupportCancellation {
            get {
                return ResourceManager.GetString("BackgroundWorker_WorkerDoesntSupportCancellation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index cannot be negative..
        /// </summary>
        internal static string IndexCannotBeNegative {
            get {
                return ResourceManager.GetString("IndexCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters..
        /// </summary>
        internal static string IO_PathTooLong {
            get {
                return ResourceManager.GetString("IO_PathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor only supports either a Reset, Add, or Remove action..
        /// </summary>
        internal static string MustBeResetAddOrRemoveActionForCtor {
            get {
                return ResourceManager.GetString("MustBeResetAddOrRemoveActionForCtor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collection is read-only..
        /// </summary>
        internal static string NotSupported_ReadOnlyCollection {
            get {
                return ResourceManager.GetString("NotSupported_ReadOnlyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change ObservableCollection during a CollectionChanged event..
        /// </summary>
        internal static string ObservableCollectionReentrancyNotAllowed {
            get {
                return ResourceManager.GetString("ObservableCollectionReentrancyNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Embedded API by In The Hand Ltd.
        /// </summary>
        internal static string ProductName {
            get {
                return ResourceManager.GetString("ProductName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset action must be initialized with index -1..
        /// </summary>
        internal static string ResetActionRequiresIndexMinus1 {
            get {
                return ResourceManager.GetString("ResetActionRequiresIndexMinus1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset action must be initialized with no changed items..
        /// </summary>
        internal static string ResetActionRequiresNullItem {
            get {
                return ResourceManager.GetString("ResetActionRequiresNullItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error (0x{0:x8}).
        /// </summary>
        internal static string Unknown_Error {
            get {
                return ResourceManager.GetString("Unknown_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor supports only the &apos;{0}&apos; action..
        /// </summary>
        internal static string WrongActionForCtor {
            get {
                return ResourceManager.GetString("WrongActionForCtor", resourceCulture);
            }
        }
    }
}
