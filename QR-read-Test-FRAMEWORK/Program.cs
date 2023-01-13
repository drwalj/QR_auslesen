using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;


namespace QR_read_Test_FRAMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Load the image
            var image = new Bitmap("D:/Downloads/qrcode.png");

            // Create a reader to read the QR code from the image
            var reader = new BarcodeReader();

            // Read the QR code
            var result = reader.Decode(image);

            // Print the QR code text
            if (result != null)
            {
                Console.WriteLine(result.Text);
                Console.ReadKey();
            }


            // Get the width and height of the image
            var width = image.Width;
            var height = image.Height;

            //var result = reader.decode(new BinaryBitmap(new HybridBinarizer(new RGBLuminanceSource(imageBytes, width, height))));

            // Print the QR code text
            //if (result != null)
            //{
            //    Console.WriteLine(result.Text);
            //}
        }
    }
}
