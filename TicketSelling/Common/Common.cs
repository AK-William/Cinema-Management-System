using TicketSelling.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO.Entity;
using System.IO;
using System.Security.Cryptography;

namespace TicketSelling.Common
{
   public class CommonFormat
    {
        public static string DateFormat = "dd-MM-yyyy";
        public static string MonthFormat = "MM-yyyy";
        public static int LoginId = 0;
        public static int RoleId = 0;

        public static Bitmap ConvertTo16bpp(Image img)
        {
            var bmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height));
            return bmp;
        }

        public static Bitmap getResizedImage(Byte[] imagebyte, int width, int height)
        {
            Bitmap imgIn = new Bitmap(byteToImage(imagebyte));
            double y = imgIn.Height;
            double x = imgIn.Width;

            double factor = 1;
            if (width > 0)
            {
                factor = width / x;
            }
            else if (height > 0)
            {
                factor = height / y;
            }
            System.IO.MemoryStream outStream = new System.IO.MemoryStream();
            Bitmap imgOut = new Bitmap((int)(x * factor), (int)(y * factor));

            // Set DPI of image (xDpi, yDpi)
            imgOut.SetResolution(32, 32);


            Graphics g = Graphics.FromImage(imgOut);
            g.Clear(System.Drawing.Color.White);
            g.DrawImage(imgIn, new Rectangle(0, 0, (int)(factor * x), (int)(factor * y)),
            new Rectangle(0, 0, (int)x, (int)y), GraphicsUnit.Pixel);
            return imgOut;

        }

        private static Image byteToImage(byte[] brr)
        {
            MemoryStream ms = new MemoryStream(brr);
            Image img = Image.FromStream(ms);
            return img;
        }

    }

    public class Cryptography  //For Password Encrypt and Decrypt
    {
        static string DefaultKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";

        public static string Encrypt(string encryptString)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(DefaultKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public static string Decrypt(string cipherText)
        {
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(DefaultKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

    }

    public class GetWeekDay
    {
        public static int GetDayNum(string DayName)
        {
            if (DayName.ToLower() == "sunday") return 0;
            else if (DayName.ToLower() == "monday") return 1;
            else if (DayName.ToLower() == "tuesday") return 2;
            else if (DayName.ToLower() == "wednesday") return 3;
            else if (DayName.ToLower() == "thursday") return 4;
            else if (DayName.ToLower() == "friday") return 5;
            else return 6;
        }
    }


}
