using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpenApplication(@"k:\");
            FileIOPermission f2 = new FileIOPermission(FileIOPermissionAccess.Read, "k:\\");
            f2.AddPathList(FileIOPermissionAccess.Write | FileIOPermissionAccess.Read, "k:\\out.txt");
            try
            {
                f2.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
            DirectoryInfo di = new DirectoryInfo(@"k:\");
            Console.WriteLine("No search pattern returns:");
            //FileInfo[] sss = di.GetFiles();
            //foreach (var fi in di.GetFiles("AllDrawFFSF.asd"))
            foreach (var fi in di.GetFiles())
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
