using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalClasses
{
    public class FileOperations
    {
        static String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static String ColorFileName = "Color Scheme.txt";
        static String ColorFilePath = Path.Combine(path, ColorFileName);
        static String GeneratedColorsFileName = "Color Palette.txt";
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
            StreamWriter writer = new StreamWriter(GeneratedColorsFilePath, append: true);
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
