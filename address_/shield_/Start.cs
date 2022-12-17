﻿namespace nilnul.fs.address_.shield_
{
	/*6 ways to get the current directory in C#
Small update: added the dotnet core way of doing things

System.AppContext.BaseDirectory
This is the prefered replacement for AppDomain.CurrentDomain.BaseDirectory in .net core (at least until the API appears for AppDomain, if it ever will).

AppDomain.CurrentDomain.BaseDirectory
This is the best option all round. It will give you the base directory for class libraries, including those in ASP.NET applications.

Directory.GetCurrentDirectory()
This does an interop call using the winapi GetCurrentDirectory call inside kernel32.dll, which means the launching process’ folder will often be returned. Also as the MSDN documents say, it’s not guaranteed to work on mobile devices.

Environment.CurrentDirectory
This simply calls Directory.GetCurrentDirectory()

Assembly.Location
This would be called using

this.GetType().Assembly.Location
This returns the full path to the calling assembly, including the assembly name itself. If you are calling a separate class library, then its base directory will be returned, such “C:\myassembly.dll” - depending obviously on which Assembly instance is being used.

Application.StartupPath
This is inside the System.Windows.Forms namespace, so is typically used in window forms application only.

Application.ExecutablePath
The same as Application.StartupPath, however this also includes the application name, such as “myapp.exe”*/
	/// <summary>
	/// </summary>
	public class _StartX
	{



	}
}
