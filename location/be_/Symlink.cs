using System;
using System.IO;

namespace nilnul.fs.location.be_
{
	/// <summary>
	///The concept of a Symbolic Link will be familiar to Unix users.A Symbolic Link is a "shortcut" to a file or folder elsewhere on the system.
	/// </summary>
	/// 
	[Obsolete()]
	public class Symlink : nilnul.fs.location.BeI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		/// <remarks>
		/// That is:
		/// •Open the file with CreateFile()
		/// •Call DeviceIoControl() to get the reparse point data(NOTE: it could be a junction point!)
		/// •Check out the returned data structure to inspect.The reparse tag will tell you if it is a junction point or symbolic link. This may be all you want to do.
		/// </remarks>
		public bool be(LocationI obj)
		{
			return location_.link_._sym_.SymbolicLink.GetTarget(obj.address.ToString()) != null;
			//throw new NotImplementedException();
		}
		[Obsolete("wrong?")]
		public bool be(string obj)
		{
			return be(nilnul.fs._File0FolderX.File0Folder_ofAddress(obj));
			//throw new NotImplementedException();
		}

		public bool be(_location_.BlankI obj)
		{
			return location_.link_._sym_.SymbolicLink.GetTarget(obj.ToString()) != null;

			//throw new NotImplementedException();
		}

		public bool be(DirectoryInfo x)
		{
			return location_.link_._sym_.SymbolicLink.GetTarget(x.FullName) != null;
			throw new NotImplementedException();
		}

		static public Symlink Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Symlink>.Instance;
			}
		}


	}
}
