// Additions for com.mapbox.extension:maps-style-ndk27:11.15.x
//
// Cleared in 11.15.x — previous additions are no longer compatible:
//
// - Expression.ExpressionBuilder/FormatBuilder/etc. are inaccessible (protection level changed)
// - Com.Mapbox.Maps.Extension.Style.Layers.Layer namespace changed
// - MapboxStyleManager, IStyleContract, Kotlin types not found in this AAR
// - Layer method overrides (Slot/MaxZoom/MinZoom/Visibility) no longer match signatures
// - unsafe code blocks referencing Com.Mapbox.Bindgen types absent from this AAR
// - IFlatLightDslReceiver, FlatLight, AmbientLight, DirectionalLight, Light types moved

