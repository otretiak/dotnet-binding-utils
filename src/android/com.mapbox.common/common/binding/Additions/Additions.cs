
namespace Com.Mapbox.Common
{
    partial class BaseMapboxInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
        {
            var result = this.Create(context);
            return result as global::Java.Lang.Object ?? new global::Java.Lang.Object();
        }

        public global::System.Collections.IList Dependencies =>
            new global::System.Collections.Generic.List<global::Java.Lang.Class>();
    }

    partial class MapboxSDKCommonInitializerImpl
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
        {
            var result = this.Create(context);
            return result as global::Java.Lang.Object ?? new global::Java.Lang.Object();
        }

        public global::System.Collections.IList Dependencies =>
            new global::System.Collections.Generic.List<global::Java.Lang.Class>();
    }

    partial class CoreInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
        {
            var result = this.Create(context);
            return result as global::Java.Lang.Object ?? new global::Java.Lang.Object();
        }

        public global::System.Collections.IList Dependencies =>
            new global::System.Collections.Generic.List<global::Java.Lang.Class>();
    }
}

namespace Com.Mapbox.Common
{
    partial class ResponseReadStream
    {
        byte[] global::Com.Mapbox.Common.IReadStream.ReadBytes()
        {
            try
            {
                var count = this.InvokeReadBytes();
                if (this.GetBytes != null)
                    return this.GetBytes();

                if (this.ToByteArray != null)
                    return this.ToByteArray();

                return new byte[0];
            }
            catch
            {
                return new byte[0];
            }
        }
    }
}

namespace Com.Mapbox.Common.Location
{
    public interface IGooglePlayServicesHelper
    {
        bool IsGooglePlayServicesAvailable();
    }

    public class GooglePlayServicesHelper : global::Java.Lang.Object, IGooglePlayServicesHelper
    {
        public bool IsGooglePlayServicesAvailable() => true;
    }
}
