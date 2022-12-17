using nilnul.fs.address_;
using nilnul.fs.address_.spear;
using nilnul.fs.address_.spear_;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.file_.link_.hard
{
	/*On a NTFS drive it is not possible to have a hardlink between files on different drives. */
	static public class _CreateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="lpFileName"></param>
		/// <param name="lpExistingFileName"></param>
		/// <param name="lpSecurityAttributes">The lpSecurityAttributes parameter must be NULL, hence the use of IntPtr.Zero. – palswim May</param>
		/// <returns></returns>
		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
		static extern bool CreateHardLink(
			  string lpFileName,
			  string lpExistingFileName,
			  IntPtr lpSecurityAttributes
		  );



		static public bool _Success_linkAssumeNewButParentReady(string lpFileName, string lpExistingFileName)
		{
			return CreateHardLink(lpFileName, lpExistingFileName, IntPtr.Zero);
		}

		/// <summary>
		/// assume link new but parentFolder exists
		/// </summary>
		/// <param name="lpFileName"></param>
		/// <param name="lpExistingFileName"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(_Success_linkAssumeNewButParentReady))]
		static public bool _Success(string lpFileName, string lpExistingFileName)
		{
			

				return CreateHardLink(lpFileName, lpExistingFileName, IntPtr.Zero);


			
		}

		static public bool Success(nilnul.fs.address_.spear_.ParentDoc link, nilnul.fs.address_.SpearI target)
		{
			if (nilnul.fs.address_.spear.be_.Newable.Singleton.be(link))
			{

				nilnul.fs.folder._EnsureX.Void(link.parent);


				return _Success_linkAssumeNewButParentReady(link.ToString(), target.ToString());


			}
			return false;

		}

		static public bool Success(nilnul.fs.address_.SpearI link, nilnul.fs.address_.SpearI target)
		{


			return Success(new nilnul.fs.address_.spear_.ParentDoc(link), target);
		}

		static public void Void(nilnul.fs.address_.SpearI link, nilnul.fs.address_.SpearI target)
		{

			nilnul.obj.vow_.True.Singleton.vow(Success(link, target), $"Unsuccess creating Link: {link} for Target:{target} ");
		}


		static public void Void(string link, string target)
		{

			Void(nilnul.fs.address_.Spear.Parse(link), nilnul.fs.address_.Spear.Parse(target));
		}



		public static void Create(SpearI en, FileI kept)
		{
			Void(en, kept.file.en);
		}
		public static void Create(string v, FileI file)
		{
			Create(
				new nilnul.fs.address_.Spear(v), file
			);
		}
		public static void Create(string v, string target)
		{
			Create(v, new nilnul.fs.File(target));
		}


		static public bool Success(string lpFileName, string lpExistingFileName)
		{
			return Success(
				nilnul.fs.address_.Spear.Parse(lpFileName)
				,
				nilnul.fs.address_.Spear.Parse(lpExistingFileName)
			);
		}

		public static void Void(ParentDoc shieldDoc1, FileI src)
		{
			Void(shieldDoc1, src.file.en);
		}



		static public void Ensure(SpearI link, SpearI target)
		{
			if (nilnul.fs.address_.spear.be_.Newable.Singleton.be(link))
			{
				Void(link, target);
			}
		}




		//		Usage:

		//CreateHardLink(newLinkPath, sourcePath, IntPtr.Zero);

		//	And use it e.g.like

		//CreateHardLink(@"c:\temp\New Link", @"c:\temp\Original File", IntPtr.Zero);
	}
}
