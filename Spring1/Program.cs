using Spring.Context;
using Spring.Context.Support;
using SpringObjs;

namespace Spring1 {
    class Program {
        static void Main(string[] args)
        {
			using (IApplicationContext ctx = ContextRegistry.GetContext()) {
				IObj oObj = (IObj)ctx.GetObject("ObjToExecute");
				oObj.Hello();
			}
        }
    }
}
