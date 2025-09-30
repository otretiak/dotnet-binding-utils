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