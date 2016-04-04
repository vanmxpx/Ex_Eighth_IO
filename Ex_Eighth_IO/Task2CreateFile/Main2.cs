using System;

namespace Ex_Eighth_IO
{
    public partial class Presenter
    {
        public void Task2()
        {
            FileCreateRead fcr = new FileCreateRead();

            Console.Clear();
            fcr.Create();
            fcr.Read();
        }
    }
}
