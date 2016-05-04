using System;
using Spring.Context;
using Spring.Context.Support;
using SpringObjs;

namespace Spring2 {
    class Program {
        static void Main(string[] args)
        {
            do {
                IApplicationContext ctx = ContextRegistry.GetContext();
                IObj oObj = (IObj)ctx.GetObject("ObjToExecute");
                oObj.Hello();
                Console.WriteLine("Esc to exit. Any other key to continue.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.WriteLine("Exited. Thank you.");
        }
    }
}
