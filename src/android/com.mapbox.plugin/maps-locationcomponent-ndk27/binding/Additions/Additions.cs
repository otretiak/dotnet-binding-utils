// maps-locationcomponent-ndk27 Additions.cs — intentionally empty.
//
// The ndk27 LocationComponentUtils class has no static GetLocationComponent() method —
// that Kotlin extension function was removed from the ndk27 AAR.
// Extension methods calling it would produce CS1501 (no overload takes 1 argument).
