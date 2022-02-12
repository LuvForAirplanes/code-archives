using System.Drawing;
using System.IO;

namespace Pronect.Core.Services
{
    public class ConversionService
    {
        public byte[] ImageToByte(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
