using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {///OpenApplication(@"k:\");
            DirectoryInfo di = new DirectoryInfo(@"k:\");
            Console.WriteLine("No search pattern returns:");
            FileInfo[] s = di.GetFiles();
            foreach (var fi in di.GetFiles("AllDrawFFSF.asd"))
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();

            //button8_Click();
        }
        static void OpenApplication(string myFavoritesPath)
        {
            // Start Internet Explorer. Defaults to the home page.
            Process.Start("IExplore.exe");

            // Display the contents of the favorites folder in the browser.
            Process.Start(myFavoritesPath);
        }
        static void button8_Click()

        {

            string ThePath = @"K:\";

            string Extension ="asd";

            string[] FileName = Directory.GetFiles(ThePath);



            foreach (string fn in FileName)

            {

                if (Path.GetExtension(fn) == Extension)

                {

                    File.Delete(fn);

                }

            }

        }
    }
}
