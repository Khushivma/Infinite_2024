using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_03
{
    class ExistingFile
    {
        static void Main(string[] args)
        {


            string wriitngFilePath = @"C:\Infinite_training24\Training\CSharp Program\Assessment\Assessment_03\appended txt file.txt";

            string writingText;

            Console.Write("Enter text to append: ");
            writingText = Console.ReadLine();

            try
            {
                AppendTextToFile(wriitngFilePath, writingText);
                Console.WriteLine("Text appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is: " + ex.Message);
            }

            Console.Read();
        }

        static void AppendTextToFile(string wriitngFilePath, string writingText)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(wriitngFilePath, true))
                {
                    writer.WriteLine(writingText);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}