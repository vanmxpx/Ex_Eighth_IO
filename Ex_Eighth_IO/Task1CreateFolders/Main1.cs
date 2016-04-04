using System;

namespace Ex_Eighth_IO
{
    public partial class Presenter
    {
        public void Task1()
        {
            Creator _creator = new Creator();
            _creator.CreateDirectories();
            Console.ReadKey();
        }
    }
}
