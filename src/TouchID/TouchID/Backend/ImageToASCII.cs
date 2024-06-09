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

            int numberOfBlocks = width * height / 6;
            int remainder = (numberOfBlocks / 8) % 8;
            BitArray binaryData = new BitArray(numberOfBlocks + remainder * 8);

            int idx = 0;

            //Color test = bmp.GetPixel(width - 1 , height - 1);
            //Color test1 = bmp.GetPixel(width, height - 1);
            //Color test2 = bmp.GetPixel(width - 1, height);
            //Color test3 = bmp.GetPixel(width, height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j += 6)
                {
                    int totalBrightness = 0;
                    int count = 0;

                    for (int k = j; k < Math.Min(j + 6, width); k++)
                    {
                        Color color = bmp.GetPixel(k, i);
                        totalBrightness += (color.R + color.G + color.B) / 3;
                        count++;
                    }

                    int avgBrightness = totalBrightness / count;
                    binaryData[idx] = (avgBrightness >= 128);
                    idx++;
                }
            }

            for (int i = numberOfBlocks; i < binaryData.Length; i++)
            {
                binaryData[idx] = false;
            };

            return binaryData;
        }

        public static string binaryToASCII(BitArray bitarr){
            int len = bitarr.Length / 8;
            byte[] bytes = new byte[len];
            
            for (int i = 0; i < len; i++)
            {
                for (int bit = 0; bit < 8; bit++)
                {
                    if (bitarr.Get(i * 8 + bit))
                    {
                        bytes[i] |= (byte)(1 << (7 - bit));
                    }
                }
            }
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}