using System;
using System.IO;

namespace Ex_Eighth_IO
{
    public class Creator
    {
        private string _activDir = @"D:\Task1CreateFolders\";
        private string _path = @"Folder_";
        
        public void CreateDirectories()
        {
            try
            {
                if (Directory.Exists(_activDir))
                {
                    Console.WriteLine("Main directory is already exist.");
                    return;
                }
                Console.WriteLine("Created at {0}", _activDir);
                for (int i = 0; i < 100; i++)
                {
                    Directory.CreateDirectory(_activDir + _path + i);
                    Console.WriteLine(_path + i + ';');
                }
                Console.WriteLine("Deleted: {0}", _activDir);
                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete(_activDir + _path + i);
                    Console.WriteLine(_path + i + ';');
                }
                Directory.Delete(_activDir);

            }
            catch(Exception e)
            {
                Console.WriteLine("Process error: {0}", e.Message);
            }
        }
    }
}
