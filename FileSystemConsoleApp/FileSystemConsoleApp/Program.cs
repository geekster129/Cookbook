using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileSystemConsoleApp.TempWS;

namespace FileSystemConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo flList = new DirectoryInfo("e:\\");
            FileInfo[] files= flList.GetFiles();
            Console.WriteLine(files[0].GetHashCode());

            byte[] byteData = new byte[200];
            char[] charData = new char[200];
            try
            {
                FileStream afile = new FileStream("e:\\test\\try.txt", FileMode.Open);
                using (StreamReader sr = new StreamReader(afile)) { 
                    string line = sr.ReadLine();

                    while(line!=null)
                    {
                        //Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
                
            } catch (IOException e) {
                Console.WriteLine("An I/O Exception has been thrown:");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            } catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("An I/O Unauthorized has been thrown:");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;

            }
            
            TempConvert ws = new TempConvert();
            string celcius = ws.FahrenheitToCelsius("100");
            string fahrenheit = ws.CelsiusToFahrenheit("40");
            Console.WriteLine($"100 deg F = {celcius.ToString()} deg C");
            Console.WriteLine($"40 deg C = {fahrenheit.ToString()} deg F");
            Console.ReadKey();
        }
    }
}
