# Spring.Net-a-simplified-demo-
Spring.Net a super simple demo

Spring/Spring.Net is all very powerful stuff.

You can cut right to the chase and run the demo from the included 'demoExecutable' folder.
It is a console app.
1) run the Spring1.exe
	You should get a reply "DEV/TEST: Hello world" & "Press any key to end..."
		This is from within the ObjA object which Spring helped Spring1.exe call because Spring1.exe is pointed to ObjA by use of the Spring1.exe.config file.
		Take note of the type __"SpringObjs.ObjA"__ in:
		_<object name="ObjToExecute" type="SpringObjs.ObjA, SpringObjs" singleton="false">_
		The "Press any key to end..." prompt is in code of SpringObjs.ObjA object.
		
2) Edit Spring1.exe.config to point "ObjToExecute" from "ObjA" to type "ObjB" as in __type="SpringObjs.ObjB, SpringObjs"__
	Save your changes.

3) re-run Spring1.exe again
	You should get a reply "PROD: Hello world" & "Press any key to end..."
	
By editing a text config file you direct Spring to change Spring1.exe's resolution from one object to an different object ~ at execution/runtime.

Also provided is Spring2.exe & Spring2.exe.config.
You can play with this to prove the resolution is set when the executable is first loaded into runtime.
In other words, you can prove that editing the config file in real-time cannot be used to change resolution in real-time.

In the solution folder you can find an article of David Consdorf dated Jan-2008.
I include it because stepping through the article is where this project began.


The solution is built in V Studio 2015 for .Net 4.5.2 (executables) & .Net 4.5 (dll) w/ Spring 2.0.1 & Common.Logging 3.3.1

