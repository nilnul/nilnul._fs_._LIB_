using nilnul.fs.address_;

namespace nilnul.fs.location_
{
	/// <summary>
	/// </summary>
	public class Spear : nilnul.fs.address_.spear_.Occupied
	{
		public Spear(SpearI val) : base(val)
		{
		}

		public Spear(address_.Spear address) : base(address)
		{
		}

		public Spear(string address) : base(address)
		{
		}

		static public nilnul.fs.File0FolderI File0Folder(nilnul.fs.address_.spear_.Occupied occupied)
		{

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(occupied.en))
			{
				return new nilnul.fs.File(occupied.en);
			}
			return new nilnul.fs.Folder(occupied.en);

		}
		static public nilnul.fs.File0FolderI File0Folder(nilnul.fs.address_.SpearI occupied)
		{

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(occupied))
			{
				return new nilnul.fs.File(occupied);
			}
			else if (nilnul.fs.address_.spear.be_.Folder.Singleton.be(occupied))
			{
				return new nilnul.fs.Folder(occupied);
			}
			throw new nilnul.fs.address_.spear.vow_._occupied.Xpn();

		}


	}
}
