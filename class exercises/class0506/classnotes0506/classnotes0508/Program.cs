using System;

namespace classnotes0508
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine dieseelEngine = new DieselEngineChildChild();

            dieseelEngine.Drive();

            Console.ReadLine();
        }
    }
}
