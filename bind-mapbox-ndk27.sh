#!/usr/bin/env bash
set -e

# Builds all Mapbox NDK27 NuGet packages in the correct dependency order.
# Output: ./nugets/*.nupkg
#
# Usage: sh bind-mapbox-ndk27.sh

ARTIFACTS=(
  "com.mapbox.common:common-ndk27:24.15.2"
  "com.mapbox.maps:base-ndk27:11.15.3"
  "com.mapbox.maps:android-core-ndk27:11.15.3"
  "com.mapbox.extension:maps-style-ndk27:11.15.3"
  "com.mapbox.extension:maps-localization-ndk27:11.15.3"
  "com.mapbox.module:maps-telemetry-ndk27:11.15.3"
  "com.mapbox.plugin:maps-animation-ndk27:11.15.3"
  "com.mapbox.plugin:maps-annotation-ndk27:11.15.3"
  "com.mapbox.plugin:maps-attribution-ndk27:11.15.3"
  "com.mapbox.plugin:maps-compass-ndk27:11.15.3"
  "com.mapbox.plugin:maps-gestures-ndk27:11.15.3"
  "com.mapbox.plugin:maps-lifecycle-ndk27:11.15.3"
  "com.mapbox.plugin:maps-locationcomponent-ndk27:11.15.3"
  "com.mapbox.plugin:maps-logo-ndk27:11.15.3"
  "com.mapbox.plugin:maps-overlay-ndk27:11.15.3"
  "com.mapbox.plugin:maps-scalebar-ndk27:11.15.3"
  "com.mapbox.plugin:maps-viewport-ndk27:11.15.3"
  "com.mapbox.maps:android-ndk27:11.15.3"
)

TOTAL=${#ARTIFACTS[@]}
for i in "${!ARTIFACTS[@]}"; do
  ARTIFACT="${ARTIFACTS[$i]}"
  echo ""
  echo "=== [$((i+1))/$TOTAL] $ARTIFACT ==="
  sh bind.sh --artifact "$ARTIFACT"
done

echo ""
echo "=== All $TOTAL packages built successfully ==="
ls -1 nugets/*.nupkg | grep -i mapbox
