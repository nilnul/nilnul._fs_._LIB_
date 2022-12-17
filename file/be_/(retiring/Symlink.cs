using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_
{
	/// <summary>
	///The concept of a Symbolic Link will be familiar to Unix users.A Symbolic Link is a "shortcut" to a file or folder elsewhere on the system.
	/// </summary>
	public class Symlink : nilnul.fs.file.BeI
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
		public bool be(File obj)
		{
			return location_._symlink_.SymbolicLink.GetTarget(obj.address.ToString()) != null;
			//throw new NotImplementedException();
		}

		static public Symlink Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Symlink>.Instance;
			}
		}

	}
}
