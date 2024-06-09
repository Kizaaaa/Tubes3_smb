using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TouchID.Backend
{
    public static class ImageToASCII
    {
        public static BitArray bitmapToBinary(string filePath)
        {
            Bitmap bmp = new Bitmap(filePath);
            int width = bmp.Width;
            int height = bmp.Height;
            int length = width * height / 6;
            int remainder = length%8;

            BitArray binaryData = new BitArray(length);

            int index = 0;
            for (int y = 0; y < height; y+=6)
            {
                for (int x = 0; x < width; x++)
                {
                    int totalBrightness = 0;
                    for (int blockX = x; blockX < Math.Min(x + 6, width); blockX++)
                    {
                        Color color = bmp.GetPixel(blockX, y);
                        totalBrightness += (color.R + color.G + color.B) / 3;
                    }
                    int avgBrightness = totalBrightness / 6;
                    binaryData[index++] = (avgBrightness >= 128);
                }
            }

            for (int i = length; i < remainder ; i++){
                binaryData[i] = 0;
            }

            return binaryData;
        }

        public static char[] binaryToASCII(BitArray bitarr){ //bit array should always be divisble by 8
            int len = bitarr.Length / 8;
            byte[] bytes = new byte[len];
            
            for (int i = 0; i < len; i++)
            {
                for (int bit = 0; bit < 8; bit++)
                {
                    if (bits.Get(i * 8 + bit))
                    {
                        bytes[i] |= (byte)(1 << (7 - bit));
                    }
                }
            }
        }

        return System.Text.Encoding.ASCII.GetString(bytes);
    }
}