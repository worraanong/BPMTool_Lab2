using System;
using System.IO;

namespace BPMTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path;
            if (args.Length != 0)
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("Input a file path:");
                path = Console.ReadLine();
            }
            FileInfo fileInfo = new FileInfo(path);
            var err = IsFileExists(fileInfo);
            if (err != null)
            {
                ShowError(err);
            }
        }

        public static string IsFileExists(FileInfo fileInfo)
        {
            var isValid = fileInfo.Exists;
            if (!isValid)
            {
                return "ERROR: File not found";
            }
            return string.Empty;
        }

        public static void ShowError(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            Console.ResetColor();
        }
    }

}
