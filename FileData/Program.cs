using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.IO;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
                string[] Split = args[0].Split(',');
                Test(Split[0], Split[1]);
                Console.ReadKey();
        }

        public static void Test(string Version, string Size)
        {
            try
            {
                String FilePath = @"C:\test.txt";
                FileDetails FD = new FileDetails();
                if (Version == "-v" || Version == "--v" || Version == "/v" || Version == "--Version")
                {


                    Console.WriteLine("Version : " + FD.Version(FilePath));

                }
                else
                {
                    Console.WriteLine("Version cannot find");
                }

                if (Size == "-s" || Size == "--s" || Size == "/s" || Size == "--size")
                {
                    Console.WriteLine("File Size : " + FD.Size(FilePath));
                }
                else
                {
                    Console.WriteLine("File Size cannot find");
                }

            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.ToString());
            }
          
        }
    }
}
