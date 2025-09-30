using System;
using Android.Runtime;

namespace Com.Mapbox.Common
{
    public partial class ResponseReadStream
    {
        byte[] Com.Mapbox.Common.IReadStream.ReadBytes()
        {
            return InvokeReadBytes();
        }
    }
}