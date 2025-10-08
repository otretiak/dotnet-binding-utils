
rm -rf ./src/libs/BindingHost/*.props
rm -rf ./src/libs/BindingHost/bin
rm -rf ./src/libs/BindingHost/obj
rm -rf ./src/android/**/obj
rm -rf ./src/android/**/bin
rm -rf tools
rm -rf .cake
# dotnet nuget locals -c all
dotnet tool restore
dotnet clean ./src/libs/BindingHost/BindingHost.csproj

echo "Cleaning previous build artifacts..."
find ./src/android -type d -name 'bin' -exec rm -rf {} + 2>/dev/null || true
find ./src/android -type d -name 'obj' -exec rm -rf {} + 2>/dev/null || true

dotnet cake "$@"

# Install Android workload
echo "Install Android workload"
dotnet workload install android wasi-experimental

dotnet restore ./src/libs/BindingHost/BindingHost.csproj
dotnet run --project ./src/libs/BindingHost/BindingHost.csproj \
    --verbosity detailed \
    -- --base-path=$PWD "$@"