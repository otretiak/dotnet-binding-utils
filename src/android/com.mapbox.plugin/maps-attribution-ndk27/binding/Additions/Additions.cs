// Additions for com.mapbox.plugin:maps-attribution-ndk27:11.15.x
//
// CS0535: 'AttributionViewImpl' does not implement interface member
//   'IAttributionView.SetContentDescription(ICharSequence?)'
//
// AppCompatImageView does not expose setContentDescription() as a directly callable
// C# method. The standard Android View binding uses a ContentDescription string
// property instead. Delegate to that property setter to satisfy the Mapbox interface.

namespace Com.Mapbox.Maps.Plugins.Attributions
{
    partial class AttributionViewImpl
    {
        void IAttributionView.SetContentDescription(Java.Lang.ICharSequence? value)
            => ContentDescription = value?.ToString();
    }
}
