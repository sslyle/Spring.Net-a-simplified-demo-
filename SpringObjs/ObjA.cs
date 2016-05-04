using System;

namespace SpringObjs
{
    public class ObjA : IObj {
        ObjA() { }
        public void Hello()
        {
            Console.WriteLine("DEV/TEST: Hello world");
            Console.WriteLine("Press any key to end...");
	        Console.Read();
        }
    }
}
