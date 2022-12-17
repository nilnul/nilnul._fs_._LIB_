using System.Diagnostics;

namespace nilnul.fs.file
{
	/// <summary>
	/// by process.start
	/// </summary>
	static public class _ExeX
	{


		static public void Exe(nilnul.fs.FileI file)
		{
			Process.Start(file.ToString());
		}

		static public void Exe(nilnul.fs.FileI1 file)
		{
			Process.Start(file.ToString());
		}
		static public void Exe(nilnul.fs.address_.SpearI shield)
		{
			Exe(new nilnul.fs.File(shield));
		}
		static public void Exe(nilnul.fs.address_.SpearI1 shield)
		{
			Exe(new nilnul.fs.File1(shield));
		}


		static public void Exe(string shield)
		{
			Exe(nilnul.fs.address_.Spear.Parse(shield));
		}


	}
}
