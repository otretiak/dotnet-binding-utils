// maps-gestures-ndk27 Additions.cs — intentionally empty.
//
// The ndk27 GesturesUtils class has no static GetGestures()/GetGesturesManager()
// methods — those Kotlin extension functions were removed from the ndk27 AAR.
// Extension methods calling those would produce CS1501 (no overload takes 1 argument).
