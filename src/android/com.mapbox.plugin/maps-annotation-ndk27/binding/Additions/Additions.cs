namespace Com.Mapbox.Maps.Plugins.Annotations.Generated
{
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
