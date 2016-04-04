using System;
using System.IO;

namespace Ex_Eighth_IO
{
    public partial class Presenter
    {
        public void Task3()
        {
            Searcher ser = new Searcher();

            Console.Clear();
            Console.WriteLine("Enter name of txt file what you searching:");
            ser.Search(new DirectoryInfo(@"d:\"),Console.ReadLine());
            Console.ReadKey();
        }
    }
}
