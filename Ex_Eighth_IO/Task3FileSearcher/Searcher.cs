using System;
using System.IO;
using System.IO.Compression;

namespace Ex_Eighth_IO
{
    public class Searcher
    {
        private string _fileExtension = @".txt";
        public void Search(DirectoryInfo dir, string _fileName)
        {
            try
            {
                Console.Clear();
                bool _fileExist = false;
                string _filePath = _fileName + _fileExtension;
                FileInfo[] fi = dir.GetFiles();
                foreach (FileInfo file in fi)
                {
                    if (_filePath == file.Name)
                    {
                        _fileExist = true;
                        Console.WriteLine("File finded in directory {0}.", file.DirectoryName);
                        Console.WriteLine("If you want to open file press 'Enter.'");
                        Console.WriteLine("Else press any key.");
                        if (Console.ReadKey().Key == ConsoleKey.Enter) FileReader(file.DirectoryName + _filePath);
                        return;
                    }
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo directoryInfo in dirs)
                {
                    Search(directoryInfo, _fileName);
                }
                if (!_fileExist) Console.WriteLine("File is not exist.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The search failed: {0}", e.Message);
                Console.WriteLine("Psess any key to continue.");
                Console.ReadKey();
            }
        }
        private void FileReader(string _filePath)
        {
            using (FileStream fs = File.OpenRead(_filePath))
            {
                Console.Clear();
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
                Console.WriteLine("If you want to compress file press 'Enter.'");
                Console.WriteLine("Else press any key.");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    MemoryStream ms = new MemoryStream();
                    fs.CopyTo(ms);
                    Compresser(ms, _filePath);
                }
            }
        }

        private void Compresser(MemoryStream ms, string _name)
        {
            using (FileStream fsTarget = new FileStream(_name + @".gzip", FileMode.Create))
            {
                using (GZipStream gzs = new GZipStream(fsTarget, CompressionMode.Compress))
                {
                    byte[] b = ms.ToArray();
                    gzs.Write(b, 0, b.Length);
                    Console.WriteLine("File compressed in same directory.");
                }
            }

        }
    }
}
