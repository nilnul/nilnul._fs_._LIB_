namespace nilnul.fs.file.be_.link_
{


	/// <summary>
	///The concept of a Symbolic Link will be familiar to Unix users.A Symbolic Link is a "shortcut" to a file or folder elsewhere on the system.
	/// </summary>
	public class Sym : nilnul.fs.file.BeI
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
		public bool be(FileI obj)
		{
			return location_.link_._sym_.SymbolicLink.GetTarget(obj.file.ToString()) != null;
			//throw new NotImplementedException();
		}




		static public Sym Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sym>.Instance;
			}
		}


	}
}
