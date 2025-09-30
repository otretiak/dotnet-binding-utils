using System;
using Android.Runtime;

namespace Com.Mapbox.Common
{
    public partial class ResponseReadStream
    {
        // This bridges the gap between the generated InvokeReadBytes and the interface
        byte[] Com.Mapbox.Common.IReadStream.ReadBytes()
        {
            return InvokeReadBytes();
        }
    }
}