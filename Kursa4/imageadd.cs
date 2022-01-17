using System.IO;
using System.Windows.Media.Imaging;

namespace Kursa4
{
    internal class imageadd
    {
        public byte[] imageTobyteArray(BitmapSource imageC)
        {
            MemoryStream memstream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memstream);
            return memstream.ToArray();
        }
    }
}
