using nilnul.fs._address._dst.denote_._vered;
using nilnul.fs.address_;
using System;
using System.IO;

namespace nilnul.fs.folder.dnt_.vered_.next
{
	public class _CreateFolderX
	{

		static public DirectoryInfo Info(nilnul.fs.FolderI parent, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_NextX.Address(parent, prefix)
			);
		}

		static public DirectoryInfo Info(nilnul.fs.FolderI1 parent, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_NextX.Address(parent, prefix)
			);
		}


		static public DirectoryInfo Info(nilnul.fs.FolderI parent, nilnul.fs._address._dst.denote_.Vered prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_NextX.Address(parent, prefix)
			);
		}



		static public DirectoryInfo Info_ofVered(nilnul.fs.FolderI parent, string prefix)
		{
			return Info(
				parent, new nilnul.fs._address._dst.denote_.Vered(prefix)
			);
		}
		static public DirectoryInfo Info(nilnul.fs.FolderI parent, string prefix)
		{
			return Info_ofVered(parent, (prefix)
			);
		}


		static public DirectoryInfo Info_ofName(nilnul.fs.FolderI parent, string prefix)
		{
			return Info(parent, new nilnul.fs._address._dst.denote_._vered.Germ(prefix)
			);
		}


		static public nilnul.fs.Folder Folder(nilnul.fs.FolderI parent, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return new nilnul.fs.Folder(Info(parent, prefix));
		}

		public static Folder1 Folder(Folder1 folder1, Germ germ)
		{
			return new nilnul.fs.Folder1(Info(folder1, germ));

		}


		/// <summary>
		///
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="prefix"> convert if necessary</param>
		/// <returns></returns>
		static public nilnul.fs.Folder Folder_ofBaseForced(nilnul.fs.FolderI parent, string prefix)
		{
			return Folder(parent, 

				
				 _address._dst.denote_._vered.Germ.CreateByAppendingSubIfNeed(prefix)
				
			);
		}

		static public nilnul.fs.Folder Folder_ofAddress_baseForced(string parent, string prefix)
		{
			return Folder_ofBaseForced(
				nilnul.fs.Folder.FroAddress(parent)
				, 
				 (prefix)
			);
		}

		public static Folder1 Folder(ShieldI1 parent, Germ germ)
		{
			return Folder(
				new nilnul.fs.Folder1(parent),germ
			);
		}

		public static Folder1 Folder_ofName(ShieldI1 parent, string prefix)
		{
			return Folder(
				parent
				,
				new nilnul.fs._address._dst.denote_._vered.Germ(
					prefix
				)
			);

		}



		static public nilnul.fs.Folder Folder_ofName(nilnul.fs.FolderI parent, string prefix)
		{
			return Folder(
				parent,
				new nilnul.fs._address._dst.denote_._vered.Germ(
					prefix
				)
			);
		}




		static public nilnul.fs.Folder Folder(nilnul.fs.FolderI parent, nilnul.fs._address._dst.denote_.Vered prefix)
		{
			return new nilnul.fs.Folder(
				Info(
				parent,
				prefix)
			);
		}

		static public nilnul.fs.Folder Folder_ofAddress(string parent, nilnul.fs._address._dst.denote_.Vered prefix)
		{
			return Folder( nilnul.fs.Folder.FroAddress(parent), prefix);
		}

		static public nilnul.fs.Folder Folder_ofAddress_Vered(string parent, string vered)
		{
			return Folder_ofAddress((parent), nilnul.fs._address._dst.denote_.Vered.Parse(vered) );
		}


		/// <summary>
		/// the main may have ver
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.fs.Folder Folder_ofVered(nilnul.fs.FolderI parent, string prefix)
		{
			return Folder(
				parent,
				new nilnul.fs._address._dst.denote_.Vered(
					prefix
				)
			);
		}



		static public DirectoryInfo Info(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_NextX.Address(parent, prefix)
			);
		}


		static public DirectoryInfo Info(System.IO.DirectoryInfo parent, string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				_NextX.Address(parent, prefix)
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
