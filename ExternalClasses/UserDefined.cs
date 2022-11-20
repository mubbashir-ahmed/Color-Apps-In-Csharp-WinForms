using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalClasses
{
    public class UserDefined
    {
        
    }

    public class Conversions
    {
        public static String RGBToCMYK(int r, int g, int b)
        {
            String cmyk;
            double dr = (double)r / 255;
            double dg = (double)g / 255;
            double db = (double)b / 255;

            double k = 1 - Math.Max(Math.Max(dr, dg), db);
            double c = (1 - dr - k) / (1 - k);
            double m = (1 - dg - k) / (1 - k);
            double y = (1 - db - k) / (1 - k);

            cmyk = Math.Round(c * 100, 0) + ", " + Math.Round(m * 100, 0) + ", " + Math.Round(y * 100, 0) + ", " + Math.Round(k * 100, 0);

            return cmyk;
        }

        public static String RGBToHSV(int r, int g, int b)
        {
            String hsv;
            double dr = (double)r / 255;
            double dg = (double)g / 255;
            double db = (double)b / 255;

            double max = Math.Max(dr, Math.Max(dg, db));
            double min = Math.Min(dr, Math.Min(dg, db));
            double diff = max - min;
            double h = -1, s = -1;

            // if max and max are equal then h = 0
            if (max == min)
                h = 0;
            // if max equal r then compute h
            else if (max == dr)
                h = (60 * ((dg - db) / diff) + 360) % 360;
            // if max equal g then compute h
            else if (max == dg)
                h = (60 * ((db - dr) / diff) + 120) % 360;
            // if max equal b then compute h
            else if (max == db)
                h = (60 * ((dr - dg) / diff) + 240) % 360;
            // if max equal zero
            if (max == 0)
                s = 0;
            else
                s = (diff / max) * 100;

            double v = max * 100;

            hsv = Math.Round(h, 0) + ", " + Math.Round(s, 1) + "%, " + Math.Round(v, 1) + "%";
            return hsv;
        }

        public static String RGBToHSL(int r, int g, int b)
        {
            String hsl;
            double dr = (double)r / 255;
            double dg = (double)g / 255;
            double db = (double)b / 255;

            double max = Math.Max(Math.Max(dr, dg), db);
            double min = Math.Min(Math.Min(dr, dg), db);
            double diff = max - min;
            double h, s;
            double l = (max + min) / 2;

            if (diff == 0)
                return hsl = "0, 0%, 0%";

            s = (l <= 0.5) ? (diff / (max + min)) : (diff / (2 - max - min));

            if (dr == max)
            {
                h = ((dg - db) / 6) / diff;
            }
            else if (dg == max)
            {
                h = (1.0f / 3) + ((db - dr) / 6) / diff;
            }
            else
            {
                h = (2.0f / 3) + ((dr - dg) / 6) / diff;
            }

            if (h < 0)
                h += 1;
            if (h > 1)
                h -= 1;

            h = (h * 360);

            //// if max and max are equal then s = 0
            //if (min == max)
            //    s = 0;
            //// if l is less than or equal to 0.5
            //if (l <= 0.5)
            //    s = (diff) / (max + min);
            //// if l is greater than 0.5
            //else
            //    s = (diff) / (2.0 - diff);
            //// if dr is max
            //if (dr > dg && dr > db)
            //    h = ((dg - db) / (diff)) * 60;
            //// if dg is max
            //else if (dg > db && dg > dr)
            //    h = (2.0 + (db - dr) / (diff)) * 60;
            //// if db is max
            //else
            //    h = (4.0 + (dr - dg) / (diff)) * 60;

            hsl = Math.Round(h, 0, MidpointRounding.AwayFromZero) + ", " + Math.Round(s * 100, 1) + "%, " + Math.Round(l * 100, 1) + "%";
            return hsl;
        }
    }

    public class FileOperations
    {
        static String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static String ColorFileName = "Color.txt";
        static String ColorFilePath = Path.Combine(path, ColorFileName);
        static String GeneratedColorsFileName = "Generated Color Palette.txt";
        static String GeneratedColorsFilePath = Path.Combine(path, GeneratedColorsFileName);

        public static void WriteColorInFile(String rgb, String hex, String cmyk, String hsv, String hsl)
        {
            StreamWriter writer = new StreamWriter(ColorFilePath, append: true);
            writer.WriteLine("==============================");
            writer.WriteLine("Saved Color Details:");
            writer.WriteLine("==============================");
            writer.WriteLine("Date Created: " + DateTime.Now);
            writer.WriteLine("RGB: " + rgb);
            writer.WriteLine("HEX: " + hex);
            writer.WriteLine("CMYK: " + cmyk);
            writer.WriteLine("HSV: " + hsv);
            writer.WriteLine("HSL: " + hsl);
            writer.WriteLine("==============================\n");
            writer.Close();
        }

        public static void WriteGeneratedColorsInFile(String col1, String col2, String col3, String col4, String col5, String col6)
        {
            StreamWriter writer = new StreamWriter(GeneratedColorsFilePath, append:true);
            writer.WriteLine("==============================");
            writer.WriteLine("Generated Color Palette");
            writer.WriteLine("==============================");
            writer.WriteLine("Date Created: " + DateTime.Now);
            writer.WriteLine("Color #1 RGB: " + col1);
            writer.WriteLine("Color #2 RGB: " + col2);
            writer.WriteLine("Color #3 RGB: " + col3);
            writer.WriteLine("Color #4 RGB: " + col4);
            writer.WriteLine("Color #5 RGB: " + col5);
            writer.WriteLine("Color #6 RGB: " + col6);
            writer.WriteLine("==============================\n");
            writer.Close();
        }
    }
}
