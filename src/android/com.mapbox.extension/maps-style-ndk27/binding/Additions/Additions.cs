// maps-style-ndk27 Additions.cs
//
// (1) *Layer bridge methods (CS0534)
//     Metadata.xml renames visibility()/maxZoom()/minZoom()/slot() setters on every
//     concrete *Layer class to SetVisibility()/SetMaxZoom()/SetMinZoom()/SetSlot() to
//     avoid CS0508 (covariant return type). That rename leaves five abstract Layer members
//     unimplemented. These bridges delegate back to the renamed setters.
//
// (2) StyleExtensionImpl explicit interface implementations (CS0535)
//     StyleExtensionImpl.getXxx() methods are suppressed to plain GetXxx() methods by
//     propertyName="" in Metadata.xml (to avoid CS0508 on covariant returns).
//     IStyleExtension (from base-ndk27) exposes those as properties, so explicit
//     interface implementations are needed to satisfy the contract.

using System.Linq;
using Expression  = global::Com.Mapbox.Maps.Extension.Style.Expressions.Generated.Expression;
using Layer       = global::Com.Mapbox.Maps.Extension.Style.Layers.Layer;
using Visibility  = global::Com.Mapbox.Maps.Extension.Style.Layers.Properties.Generated.Visibility;

namespace Com.Mapbox.Maps.Extension.Style.Layers.Generated
{
    partial class BackgroundLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class CircleLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class ClipLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class FillExtrusionLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class FillLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class HeatmapLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class HillshadeLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class LineLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class LocationIndicatorLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class ModelLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class RasterLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class RasterParticleLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class SkyLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class SlotLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }

    partial class SymbolLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }
}

namespace Com.Mapbox.Maps.Extension.Style.Layers
{
    partial class CustomLayer
    {
        public override Layer MaxZoom(double maxZoom) => SetMaxZoom(maxZoom);
        public override Layer MinZoom(double minZoom) => SetMinZoom(minZoom);
        public override Layer Slot(string slot) => SetSlot(slot);
        public override Layer Visibility(Expression visibility) => SetVisibility(visibility);
        public override Layer Visibility(Visibility visibility) => SetVisibility(visibility);
    }
}

namespace Com.Mapbox.Maps.Extension.Style
{
    using IStyleExtension         = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension;
    using IStyleAtmosphereExt     = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleAtmosphereExtension;
    using IStyleLightExt          = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleLightExtension;
    using IStyleImageExt          = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleImageExtension;
    using IStyleModelExt          = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleModelExtension;
    using IStyleProjectionExt     = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleProjectionExtension;
    using IStyleRainExt           = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleRainExtension;
    using IStyleSnowExt           = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleSnowExtension;
    using IStyleSourceExt         = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleSourceExtension;
    using IStyleTerrainExt        = global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleTerrainExtension;

    // StyleExtensionImpl.getXxx() methods are rendered as plain methods (not properties) by
    // propertyName="" Metadata transforms to avoid CS0508. IStyleExtension declares them as
    // properties, so explicit interface implementations bridge the gap.
    partial class StyleExtensionImpl
    {
        IStyleAtmosphereExt?  IStyleExtension.Atmosphere  => GetAtmosphere();
        global::Com.Mapbox.Maps.ColorTheme? IStyleExtension.ColorTheme => GetColorTheme();
        IStyleLightExt?       IStyleExtension.DynamicLight => GetDynamicLight();
        IStyleLightExt?       IStyleExtension.FlatLight    => GetFlatLight();
        global::System.Collections.Generic.IList<IStyleImageExt>  IStyleExtension.Images
            => GetImages()?.Cast<IStyleImageExt>().ToList()!;
        global::System.Collections.Generic.IList<global::Kotlin.Pair> IStyleExtension.Layers
            => GetLayers();
        global::System.Collections.Generic.IList<IStyleModelExt> IStyleExtension.Models
            => GetModels()?.Cast<IStyleModelExt>().ToList()!;
        IStyleProjectionExt?  IStyleExtension.Projection  => GetProjection();
        IStyleRainExt?        IStyleExtension.Rain         => GetRain();
        IStyleSnowExt?        IStyleExtension.Snow         => GetSnow();
        global::System.Collections.Generic.IList<IStyleSourceExt> IStyleExtension.Sources
            => GetSources()?.Cast<IStyleSourceExt>().ToList()!;
        string IStyleExtension.Style => GetStyle();
        IStyleTerrainExt?     IStyleExtension.Terrain      => GetTerrain();
        global::Com.Mapbox.Maps.TransitionOptions? IStyleExtension.Transition => GetTransition();
    }
}
