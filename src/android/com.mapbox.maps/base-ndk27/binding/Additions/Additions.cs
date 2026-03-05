// Additions for com.mapbox.maps:base-ndk27:11.15.x
//
// Cleared in 11.15.x — previous additions are no longer compatible:
//
// 1. Gesture/location helper wrappers (IOnMapClickListener, IGesturesPlugin, etc.) —
//    these types moved to their respective plugin packages (maps-gestures-ndk27,
//    maps-locationcomponent-ndk27). Add them to those packages' Additions.cs if needed.
//
// 2. XxxSettings.Creator partial classes implementing IParcelableCreator —
//    no longer needed; modern .NET Android binding generator handles IParcelable.Creator
//    automatically, and IParcelableCreator now inherits additional IJavaPeerable members
//    that the manual implementations did not provide (CS0535).
//
// 3. StandardBuildings/StandardPoi/StandardPlaceLabels overrides with unsafe code —
//    reference Com.Mapbox.Geojson and Com.Mapbox.Bindgen types not present in this AAR.
