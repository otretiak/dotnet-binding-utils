using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

// base-ndk27 Additions.cs
//
// RESTORED in 11.15.x:
//  - PuckLocatedAtPointListenerAction / IsLocatedAt extension
//  - OnMapClickListenerFunction / OnMapLongClickListenerFunction / IGesturesPluginExtensions
//  - OnMapLoadErrorListenerAction
//
// KEPT CLEARED in 11.15.x:
//  1. XxxSettings.Creator partial classes implementing IParcelableCreator —
//     no longer needed; modern .NET Android binding generator handles IParcelable.Creator
//     automatically, and IParcelableCreator now inherits additional IJavaPeerable members
//     that the manual implementations did not provide (CS0535).
//
//  2. StandardBuildings/StandardPoi/StandardPlaceLabels overrides with unsafe code —
//     reference Com.Mapbox.Geojson.Feature and Com.Mapbox.Bindgen.Value which are
//     transitive deps. The generator may auto-handle these bridge methods in .NET 9/10.

namespace Com.Mapbox.Maps.Plugins.Locationcomponent
{
    public sealed class PuckLocatedAtPointListenerAction : Java.Lang.Object, global::Com.Mapbox.Maps.Plugins.Locationcomponent.IPuckLocatedAtPointListener
    {
        Action<bool> onResult;
        public PuckLocatedAtPointListenerAction(Action<bool> onResult)
        {
            this.onResult = onResult;
        }

        public void OnResult(bool isPuckLocatedAtPoint) => onResult?.Invoke(isPuckLocatedAtPoint);
    }

    public static class LocationComponentPluginExtensions
    {
        public static void IsLocatedAt(
            this ILocationComponentPlugin locationComponent,
            global::Com.Mapbox.Geojson.Point point, Action<bool> onResult)
            => locationComponent.IsLocatedAt(point, new PuckLocatedAtPointListenerAction(onResult));
    }
}

namespace Com.Mapbox.Maps.Plugins.Gestures
{
    public sealed class OnMapClickListenerFunction : Java.Lang.Object, IOnMapClickListener
    {
        Func<global::Com.Mapbox.Geojson.Point, bool> func;
        public OnMapClickListenerFunction(Func<global::Com.Mapbox.Geojson.Point, bool> func)
        {
            this.func = func;
        }

        public bool OnMapClick(global::Com.Mapbox.Geojson.Point point)
        {
            return func?.Invoke(point) ?? false;
        }
    }

    public sealed class OnMapLongClickListenerFunction : Java.Lang.Object, IOnMapLongClickListener
    {
        Func<global::Com.Mapbox.Geojson.Point, bool> func;
        public OnMapLongClickListenerFunction(Func<global::Com.Mapbox.Geojson.Point, bool> func)
        {
            this.func = func;
        }

        public bool OnMapLongClick(global::Com.Mapbox.Geojson.Point point)
        {
            return func?.Invoke(point) ?? false;
        }
    }

    public static class IGesturesPluginExtensions
    {
        public static void OnMapClick(
            this IGesturesPlugin gestures,
            Func<global::Com.Mapbox.Geojson.Point, bool> mapClicked)
            => gestures.AddOnMapClickListener(new OnMapClickListenerFunction(mapClicked));

        public static void OnMapLongClick(
            this IGesturesPlugin gestures,
            Func<global::Com.Mapbox.Geojson.Point, bool> mapLongClicked)
            => gestures.AddOnMapLongClickListener(new OnMapLongClickListenerFunction(mapLongClicked));
    }
}

namespace Com.Mapbox.Maps.Plugins.Delegates.Listeners
{
    public sealed class OnMapLoadErrorListenerAction : Java.Lang.Object, IOnMapLoadErrorListener
    {
        private readonly Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action;

        public OnMapLoadErrorListenerAction(Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action)
        {
            this.action = action;
        }

        public void OnMapLoadError(global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData eventData)
            => action?.Invoke(eventData);
    }
}
