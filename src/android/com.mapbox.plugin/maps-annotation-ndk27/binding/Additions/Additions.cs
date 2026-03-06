using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Maps.Plugins.Annotations.Generated
{
    // CircleAnnotationManager / PointAnnotationManager / PolygonAnnotationManager /
    // PolylineAnnotationManager are concrete (final) Java classes but the C# binding generates them
    // as extending abstract AnnotationManagerImpl.  The two abstract members that survive in the
    // generated AnnotationManagerImpl must be implemented in each sealed partial class.
    // We call through JNI using InvokeVirtualObjectMethod/InvokeVirtualVoidMethod because
    // the actual implementations live in the Java bytecode of each concrete manager class.
    public sealed partial class CircleAnnotationManager
    {
        public override unsafe string AnnotationIdKey
        {
            [Register("getAnnotationIdKey", "()Ljava/lang/String;", "GetGetAnnotationIdKeyHandler")]
            get
            {
                const string __id = "getAnnotationIdKey.()Ljava/lang/String;";
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
        }

        [Register("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V",
            "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
        protected override unsafe void SetDataDrivenPropertyIsUsed(string property)
        {
            const string __id = "setDataDrivenPropertyIsUsed.(Ljava/lang/String;)V";
            IntPtr native_property = JNIEnv.NewString(property);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_property);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally { JNIEnv.DeleteLocalRef(native_property); }
        }
    }

    public sealed partial class PointAnnotationManager
    {
        public override unsafe string AnnotationIdKey
        {
            [Register("getAnnotationIdKey", "()Ljava/lang/String;", "GetGetAnnotationIdKeyHandler")]
            get
            {
                const string __id = "getAnnotationIdKey.()Ljava/lang/String;";
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
        }

        [Register("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V",
            "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
        protected override unsafe void SetDataDrivenPropertyIsUsed(string property)
        {
            const string __id = "setDataDrivenPropertyIsUsed.(Ljava/lang/String;)V";
            IntPtr native_property = JNIEnv.NewString(property);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_property);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally { JNIEnv.DeleteLocalRef(native_property); }
        }
    }

    public sealed partial class PolygonAnnotationManager
    {
        public override unsafe string AnnotationIdKey
        {
            [Register("getAnnotationIdKey", "()Ljava/lang/String;", "GetGetAnnotationIdKeyHandler")]
            get
            {
                const string __id = "getAnnotationIdKey.()Ljava/lang/String;";
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
        }

        [Register("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V",
            "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
        protected override unsafe void SetDataDrivenPropertyIsUsed(string property)
        {
            const string __id = "setDataDrivenPropertyIsUsed.(Ljava/lang/String;)V";
            IntPtr native_property = JNIEnv.NewString(property);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_property);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally { JNIEnv.DeleteLocalRef(native_property); }
        }
    }

    public sealed partial class PolylineAnnotationManager
    {
        public override unsafe string AnnotationIdKey
        {
            [Register("getAnnotationIdKey", "()Ljava/lang/String;", "GetGetAnnotationIdKeyHandler")]
            get
            {
                const string __id = "getAnnotationIdKey.()Ljava/lang/String;";
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
        }

        [Register("setDataDrivenPropertyIsUsed", "(Ljava/lang/String;)V",
            "GetSetDataDrivenPropertyIsUsed_Ljava_lang_String_Handler")]
        protected override unsafe void SetDataDrivenPropertyIsUsed(string property)
        {
            const string __id = "setDataDrivenPropertyIsUsed.(Ljava/lang/String;)V";
            IntPtr native_property = JNIEnv.NewString(property);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_property);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally { JNIEnv.DeleteLocalRef(native_property); }
        }
    }

    // Build() overloads delegate to the renamed DoBuild() bridge (see Metadata.xml).
    partial class CircleAnnotationOptions
    {
        public global::Java.Lang.Object Build(string id, global::Com.Mapbox.Maps.Plugins.Annotations.IAnnotationManager annotationManager)
            => DoBuild(id, annotationManager);
    }
    partial class PolylineAnnotationOptions
    {
        public global::Java.Lang.Object Build(string id, global::Com.Mapbox.Maps.Plugins.Annotations.IAnnotationManager annotationManager)
            => DoBuild(id, annotationManager);
    }
    partial class PolygonAnnotationOptions
    {
        public global::Java.Lang.Object Build(string id, global::Com.Mapbox.Maps.Plugins.Annotations.IAnnotationManager annotationManager)
            => DoBuild(id, annotationManager);
    }
    partial class PointAnnotationOptions
    {
        public global::Java.Lang.Object Build(string id, global::Com.Mapbox.Maps.Plugins.Annotations.IAnnotationManager annotationManager)
            => DoBuild(id, annotationManager);
    }

    // GetOffsetGeometry() overrides: Annotation base class (base-ndk27) declares this abstract;
    // the generator renames the concrete implementation to DoGetOffsetGeometry() via Metadata.xml,
    // so we must bridge back here.
    partial class CircleAnnotation
    {
        public override unsafe global::Java.Lang.Object? GetOffsetGeometry(
            global::Com.Mapbox.Maps.Plugins.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate,
            global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
            => DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
    }
    partial class PolylineAnnotation
    {
        public override unsafe global::Java.Lang.Object? GetOffsetGeometry(
            global::Com.Mapbox.Maps.Plugins.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate,
            global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
            => DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
    }
    partial class PolygonAnnotation
    {
        public override unsafe global::Java.Lang.Object? GetOffsetGeometry(
            global::Com.Mapbox.Maps.Plugins.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate,
            global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
            => DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
    }
    partial class PointAnnotation
    {
        public override unsafe global::Java.Lang.Object? GetOffsetGeometry(
            global::Com.Mapbox.Maps.Plugins.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate,
            global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
            => DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
    }
}
