using System.IO;

namespace nilnul.fs.folder.denote_.vered_.next_.subIfNeed
{
	public class _CreateFolderX
	{

		static public DirectoryInfo Info(nilnul.fs.FolderI parent, string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_SubIfNeedX.Spear(parent, prefix)
			);
		}




		static public nilnul.fs.Folder Folder(nilnul.fs.FolderI parent, string prefix)
		{
			return new nilnul.fs.Folder(Info(parent, prefix));
		}

	

		static public nilnul.fs.Folder Folder_ofAddress(string parent, string prefix)
		{
			return Folder(
				nilnul.fs.Folder.FroAddress(parent)
				, 
				 (prefix)
			);
		}



		static public DirectoryInfo Info(nilnul.fs.Folder parent, string prefix)
		{
			return Info(
				( nilnul.fs.FolderI)(parent),prefix
			);
		}


		static public DirectoryInfo Info(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return Info(
				new nilnul.fs.Folder(parent),prefix
			);
		}


		static public DirectoryInfo Info(System.IO.DirectoryInfo parent, string prefix)
		{
			return Info(
				new nilnul.fs.Folder(parent), prefix
			);
		}

		static public DirectoryInfo Info_ofShield(string parent, string prefix)
		{
			return Info(nilnul.fs.address_.Shield.Parse(parent), prefix);
		}

		static public DirectoryInfo Info_ofAddress(string parent, string prefix)
		{
			return Info_ofShield(
				nilnul.txt.op_.unary_.fs_.EnsureEndWithDirSep.Singleton.op(parent)
				,
				prefix
			);
		}



	}

}
