using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace KeyBox
{
    class KeyConvert
    {
        /**
         * 创建密钥
         * 
         * 
         */
        public static string CreateKey(string keypath)
        {

            System.Net.WebRequest webreq = System.Net.WebRequest.Create("http://localhost/cloudkey/kkey.png");
            System.Net.WebResponse webres = webreq.GetResponse();
            Stream stream = webres.GetResponseStream();
            Image image;
            image = Image.FromStream(stream);
            stream.Close();

            string key = "";
            Bitmap bmp = new Bitmap(image);
            Random rd = new Random();
            try
            {
                string[] array = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

                Color color;
                int ret;
                int intkey;
                for (int i = 0; i < 320; i++)
                {
                    if (i % 10 == 0)
                    {
                        color = bmp.GetPixel(0, i);
                        intkey = rd.Next(36);
                        ret = 255 - intkey;
                        bmp.SetPixel(0, i, Color.FromArgb(color.R, color.G, ret));
                        key = key + array[intkey];
                    }
                }
            }
            catch (Exception ex)
            {
            }
            bmp.Save(keypath, System.Drawing.Imaging.ImageFormat.Png);
            return key;
        }
        /**
         * 根据图片密钥获取密钥
         * 
         * Imagefilename  图片密钥路径
         * 
         * return 密钥
         */
        public static string GetKeyByImage(string Imagefilename)
        {
            string key = "";
            Bitmap bmp = new Bitmap(Imagefilename);

            Color color;
            int intkey;
            string[] array = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i < 320; i++)
            {
                if (i % 10 == 0)
                {
                    color = bmp.GetPixel(0, i);
                    intkey = 255 - (int)(color.B);

                    key = key + array[intkey];
                }
            }

            return key;
        }        
    }
}
