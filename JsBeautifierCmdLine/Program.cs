using System;
using System.IO;
using Jsbeautifier;

namespace JsBeautifierCmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) {
                DisplayHelp();
            }
            else {
                string inputFile = args[0];
                string fileContent = File.ReadAllText(inputFile);

                string beautifiedJs = new Beautifier().Beautify(fileContent);

                string outputFile = inputFile.Replace(".js", ".beauty.js");
                if (args.Length > 1)
                {
                    outputFile = args[1];
                }
                File.WriteAllText(outputFile, beautifiedJs);
            }

            Console.ReadLine();
        }

        static void DisplayHelp()
        {
            string helpMsg = "pass in minified js file as argument";
            Console.WriteLine(helpMsg);
        }
    }
}
