using nilnul.fs.folder;

namespace nilnul.fs.address.be_.folder_
{
	/// <summary>
	/// </summary>
	public class Empty :
		nilnul.fs.address.BeI
	{

		public bool be(AddressI obj)
		{
			return nilnul.fs.address.be_.Folder.Singleton.be(obj)
				&&
				nilnul.fs.folder.be_.Empty.Singleton.Be(obj)
			;
		}


		static public Empty Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Folder>' is obsolete
				return nilnul._obj.Singleton<Empty>.Instance;
#pragma warning restore CS0612 // 'Singleton<Folder>' is obsolete
			}
		}

	}
}
