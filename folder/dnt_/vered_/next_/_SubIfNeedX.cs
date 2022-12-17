using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.denote_.vered_.next_
{
	/// <summary>
	/// 
	/// </summary>
	public class _SubIfNeedX
	{


		/// <summary>
		/// ofName
		/// </summary>
		/// <param name="dirInfo"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.Num1 Ver(DirectoryInfo dirInfo, string prefix)
		{
			return vered_._NextX.Num(
				dirInfo, nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(prefix)
			);
		}


		private static Num1 Ver(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return Ver(

				nilnul.fs.address_.shield.to_._InfoX.Info(parent)

				
				,
				
					prefix
				
			);
		}

		private static Num1 Ver(nilnul.fs.FolderI parent, string prefix)
		{
			return Ver(nilnul.fs.folder.to_.Info.Singleton.to(parent), prefix);
		}


		public static string Stub(FolderI parent, string prefix)
		{
			var name = nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(prefix);
			return name + nilnul.num.phrase_._DecX.Phrase( Ver(parent, name ) );

		}
		public static string Stub(Folder parent, string prefix)
		{
			return Stub((FolderI)parent, (prefix));

		}
		static public string Stub(DirectoryInfo dirInfo, string prefix)
		{
			return Stub(new nilnul.fs.Folder(dirInfo), prefix);
		}
		


		static public string Stub(nilnul.fs.address_.ShieldI dirInfo, string prefix)
		{
			return Stub(new nilnul.fs.Folder(dirInfo), prefix);
		}

		static public string Spear(nilnul.fs.FolderI parent, string prefix)
		{
			return $"{parent}{Stub(parent, prefix)}";
		}


		

		static public string Spear(nilnul.fs.Folder parent, string prefix)
		{
			return Spear((FolderI)(parent), prefix);
		}


		static public string Spear(System.IO.DirectoryInfo parent, string prefix)
		{
			return Spear(new nilnul.fs.Folder(parent), (prefix));
		}


		static public string Spear(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return Spear(new nilnul.fs.Folder(parent), prefix);
		}

		static public string Spear(nilnul.fs.AddressI parent, string prefix)
		{
			return Spear(nilnul.fs.address_.Shield.FroAddress(parent), prefix);
		}

		static public string Spear_ofAddress(string parent, string prefix)
		{
			return Spear(nilnul.fs.address_.Shield.FroAddress(parent), prefix);
		}



	}

}
