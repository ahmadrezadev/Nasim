using System.Drawing;
using System.IO;

namespace NasimImageEditor.Services
{
    public interface IImageProcess
    {
        string Resize(string imagePath, string name, int width, int height = 0, int quality = 75);
        void Watermark(string imagePath, string watermarkPath, string imageName,
            ImageProcess.WatermarkPosition position = ImageProcess.WatermarkPosition.TopRight);
        string Watermark(string imagePath, string watermarkPath, int width, int height = 0,
            int quality = 75, ImageProcess.WatermarkPosition position = ImageProcess.WatermarkPosition.TopRight);
        bool HardCompression(Image imageFile, string imageName);
        void HardCompression(Image imageFile, string imageName, int width, int height);
    }
}