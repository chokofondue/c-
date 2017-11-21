using System;

namespace Abstract_Class
{
    public abstract class PureBase{
        
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DeriverA : PureBase {
        private int no = 1;

        //override C#키워드
        public override int GetFirst(){
            return no;
        }
        public override int GetNext(){
            return ++no;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            DeriverA a = new DeriverA();
            Console.WriteLine(a.GetFirst());
            Console.WriteLine(a.GetNext());
        }
    }
}
