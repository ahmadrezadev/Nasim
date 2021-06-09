using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using ImageMagick;

namespace NasimImageEditor.Services
{
    public class ImageProcess : IImageProcess
    {
        public string Resize(string imagePath, string name, int width, int height = 0, int quality = 75)
        {
            try
            {
                using var image = new MagickImage(imagePath);
                if (height != 0)
                {
                    image.Quality = quality;
                    image.Resize(new MagickGeometry(width, height)
                    {
                        IgnoreAspectRatio = true
                    });
                    image.Write(
                        name,
                        MagickFormat.Jpeg);
                    return name;
                }

                image.Quality = quality;
                image.Resize(width, height);
                image.Write(name,
                    MagickFormat.Jpeg);
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="watermarkPath"></param>
        /// <param name="imageName"></param>
        /// <param name="position"></param>
        public void Watermark(string imagePath, string watermarkPath, string imageName,
            WatermarkPosition position = WatermarkPosition.TopRight)
        {
            var savePath = Path.Combine(Path.GetDirectoryName(imagePath), imageName);

            try
            {
                using var image = new MagickImage(imagePath);
                using var watermark = new MagickImage(watermarkPath);

                switch (position)
                {
                    case WatermarkPosition.TopLeft:
                        {
                            image.Composite(watermark, 15, 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.LeftCenter:
                        {
                            image.Composite(watermark, 15,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomLeft:
                        {
                            image.Composite(watermark, 15,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomCenter:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomRight:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.RightCenter:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.TopRight:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.TopCenter:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.Center:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.AllOver:
                        {
                            image.Tile(watermark, CompositeOperator.Over);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                image.Write(savePath, MagickFormat.Jpg);
                var optimizer = new ImageOptimizer();
                if (!optimizer.IsSupported(savePath)) return;
                optimizer.IgnoreUnsupportedFormats = true;
                optimizer.OptimalCompression = true;
                optimizer.LosslessCompress(savePath);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="watermarkPath"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="quality"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public string Watermark(string imagePath, string watermarkPath, int width, int height = 0,
            int quality = 75, WatermarkPosition position = WatermarkPosition.TopRight)
        {
            try
            {
                using var image = new MagickImage(imagePath);
                using var watermark = new MagickImage(watermarkPath);

                switch (position)
                {
                    case WatermarkPosition.TopLeft:
                        {
                            image.Composite(watermark, 15, 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.LeftCenter:
                        {
                            image.Composite(watermark, 15,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomLeft:
                        {
                            image.Composite(watermark, 15,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomCenter:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.BottomRight:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                image.Height - watermark.Height - 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.RightCenter:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.TopRight:
                        {
                            image.Composite(watermark, image.Width - watermark.Width - 15,
                                 15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.TopCenter:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                15, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.Center:
                        {
                            image.Composite(watermark, (image.Width - watermark.Width) / 2,
                                (image.Height - watermark.Height) / 2, CompositeOperator.Over);
                            break;
                        }
                    case WatermarkPosition.AllOver:
                        break;
                    default:
                        {
                            break;
                        }
                }

                var savePath = Path.Combine(Path.GetDirectoryName(imagePath) ?? string.Empty,
                    $"{Path.GetFileNameWithoutExtension(imagePath)}_S{image.Width}x{image.Height}_Q{image.Quality}.jpg");

                image.Quality = quality;
                image.Resize(width, height);
                image.Write(savePath);
                return savePath;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageName"></param>
        public bool HardCompression(Image imageFile, string imageName)
        {
            try
            {
                using var bitmap = new Bitmap(imageFile);
                using var drawArea = new Bitmap(bitmap.Width, bitmap.Height);
                using var drawAreaGraphic = Graphics.FromImage(drawArea);
                drawAreaGraphic.CompositingQuality = CompositingQuality.HighSpeed;
                drawAreaGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                drawAreaGraphic.CompositingMode = CompositingMode.SourceCopy;
                drawAreaGraphic.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
                var encoderParameters = new EncoderParameters(1)
                {
                    Param = { [0] = new EncoderParameter(Encoder.Quality, 50L) }
                };
                var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
                drawArea.Save(imageName, codec, encoderParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageName"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void HardCompression(Image imageFile, string imageName, int width, int height)
        {
            using var bitmap = new Bitmap(imageFile);
            using var drawArea = new Bitmap(width, height);
            using var drawAreaGraphic = Graphics.FromImage(drawArea);
            drawAreaGraphic.CompositingQuality = CompositingQuality.HighSpeed;
            drawAreaGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            drawAreaGraphic.CompositingMode = CompositingMode.SourceCopy;
            drawAreaGraphic.DrawImage(bitmap, 0, 0, width, height);
            var encoderParameters = new EncoderParameters(1)
            {
                Param = { [0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L) }
            };
            var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
            drawArea.Save(imageName, codec, encoderParameters);
        }

        public enum WatermarkPosition
        {
            Center,
            TopRight,
            BottomRight,
            TopLeft,
            BottomLeft,
            BottomCenter,
            TopCenter,
            RightCenter,
            LeftCenter,
            AllOver
        }
    }
}