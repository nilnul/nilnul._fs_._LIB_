namespace nilnul.fs.folder.be
{
	
	static public partial class _ExtensionsX
	{
		static public bool Be(this nilnul.fs.folder.BeI be, nilnul.fs.FolderI address)
		{
			return be.be((address));
		}

		static public bool Be(this nilnul.fs.folder.BeI be, nilnul.fs.Folder address)
		{
			return be.be((address));
		}

		static public bool Be(this nilnul.fs.folder.BeI be, nilnul.fs.AddressI address)
		{
			return Be(be, new nilnul.fs.Folder(address));
		}

		static public bool Be_ofAddress(this nilnul.fs.folder.BeI be, string address)
		{
			return Be(be, nilnul.fs.AddressA.Parse(address));
		}

	}


}
