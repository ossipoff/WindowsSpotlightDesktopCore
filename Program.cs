using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace WindowsSpotlightDesktopCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var pkgs = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages");
            if (Directory.Exists(pkgs))
            {
                var cdm = Directory.GetDirectories(pkgs, "Microsoft.Windows.ContentDeliveryManager*").FirstOrDefault();
                var assets = Path.Combine(cdm, @"LocalState\Assets");
                if (Directory.Exists(assets))
                {
                    if (Directory.Exists("Images"))
                    {
                        Directory.Delete("Images", recursive: true);
                    }

                    var files = Directory.GetFiles(assets);
                    foreach (var file in files)
                    {
                        try
                        {
                            Image img = Image.FromFile(file);

                            if (img.Width == 1920 && img.Height == 1080)
                            {
                                var dst = Path.Combine(@"Images\", $"{Path.GetFileName(file)}.jpg");
                                if (!Directory.Exists("Images"))
                                {
                                    Directory.CreateDirectory("Images");
                                }
                                File.Copy(file, dst);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
            }
        }
    }
}
