using System;
using System.IO;

namespace Ex_Eighth_IO
{
    public class FileCreateRead
    {
        private string _activDir = @"D:\";
        private string _fileName = @"NewFile.txt";
        public void Create()
        {
            using (StreamWriter sw = new StreamWriter(_activDir + _fileName))
            {
                sw.WriteLine("ddddddasdg,maslk;hnmhsdhsdhsdgwerdd");
                Console.WriteLine("File created.");
                Console.ReadKey();
            }
        }
        public void Read()
        {
            using (StreamReader sw = new StreamReader(_activDir + _fileName))
            { 
                Console.WriteLine("File readed.");
                Console.WriteLine(sw.ReadToEnd());
                Console.ReadKey();
            }
        }

    }
}
