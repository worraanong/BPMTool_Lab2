using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BPMTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                ProcessFile(args[0]);
            }
            else
            {
                PromptProcessFile();
            }
        }
        private static void ProcessFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            if (IsFileExists(fileInfo)?.ShowError() ?? false)
            {
                PromptQuit();
            }
            if (IsValidFileExtension(fileInfo)?.ShowError() ?? false)
            {
                PromptQuit();
            }

            Console.WriteLine($"Processing '{fileInfo.Name}'");
            Console.WriteLine("Pressing completed");
            Console.WriteLine("Sorry, we don't implement the output file yet");
            PromptQuit();
        }

        private static void PromptProcessFile()
        {
            Console.WriteLine("Input a file path:");
            string path = Console.ReadLine();
            ProcessFile(path);
        }

        private static void PromptQuit()
        {
            Console.Write("Select new file? (y,n): ");
            char ans = Console.ReadLine()[0];
            if (ans == 'n' || ans == 'N')
            {
                Environment.Exit(0);
            }
            else
            {
                PromptProcessFile();
            }
        }
        public static Error IsFileExists(FileInfo fileInfo)
        {
            var isValid = fileInfo.Exists;
            if (!isValid)
            {
                return new Error(new List<string>
                {
                    "ERROR: File not found",
                    $"File '{fileInfo.FullName}' does not exist"
                });
            }
            return null;
        }
        public static Error IsValidFileExtension(FileInfo fileInfo)
        {
            string extension = fileInfo.Extension.ToLower();
            var isValid = extension == ".xes" || extension == ".csv";
            if (!isValid)
            {
                return new Error(new List<string>
                {
                    "ERROR: The input file does not in XES or CSV format",
                    $"File Extension {extension} is not support"
                });
            }
            return null;
        }
    }
    public class Error
    {
        private List<string> Message { get; set; }

        public Error(List<string> message)
        {
            Message = message;
        }
        public string GetShortError()
        {
            return (Message is null) ? string.Empty : Message.First();
        }
        public bool ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var err in Message)
            {
                Console.WriteLine(err);
            }
            Console.ResetColor();
            return true;
        }
    }
}
