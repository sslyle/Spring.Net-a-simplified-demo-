using System;

namespace SpringObjs
{
    public class ObjB : IObj {
        ObjB() { }
        public void Hello()
        {
            Console.WriteLine("PROD: Hello world");
            Console.WriteLine("Press any key to end...");
	        Console.Read();
        }
    }
}
