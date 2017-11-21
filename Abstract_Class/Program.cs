using System;

namespace Abstract_Class
{
    public abstract class PureBase{
        
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DeriverA : PureBase {
        private int no = 1;
    }



    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
