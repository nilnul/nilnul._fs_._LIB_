using nilnul.fs.address_;
using System;
using System.Diagnostics;

namespace nilnul.fs.file_.link_.hard.create_.by_
{

	/// <summary>
	/// 
	/// </summary>
	static public class _MkLinkX
	{


		public static void _Exe(string link, string target)
		{
			Process.Start("mklink /H", String.Format("{0} {1}", link, target));
			/*
			
			Better to use the API, and this solution also has problems reg. spaces in file names (and dependency on an external program). – Michael Bisbjerg Aug 22 '15 at 14:54
			@Michael there is no problems, you can escape spaces. This this the right approach, Unix way, why to call complex C API when you can call simple exe? That's right, call simple exe which always presents in Windows. – abatishchev Aug 22 '15 at 15:03 
			 */
		}

		public static void Exe(SpearI shieldDocument, SpearI target)
		{
			_Exe(shieldDocument.ToString(), target.ToString());
		}

		static public void Ensure(SpearI link, SpearI target)
		{
			if (nilnul.fs.address_.spear.be_.Newable.Singleton.be(link))
			{
				Exe(link, target);
			}
		}
	}
}
