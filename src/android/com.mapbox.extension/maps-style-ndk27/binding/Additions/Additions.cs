// maps-style-ndk27 Additions.cs — intentionally empty.
//
// DO NOT copy from the non-ndk27 maps-style Additions.cs.
//
// In the ndk27 AAR:
//  - Expression.ExpressionBuilder/CollatorBuilder/FormatBuilder/InterpolatorBuilder
//    are all 'protected' — every Action<Builder> overload in ExpressionDslKt
//    fails CS0122 (inaccessible) + CS0050 (inconsistent accessibility).
//  - Layer, MapboxStyleManager, IStyleContract, FlatLight, Projection
//    are absent from this package.
