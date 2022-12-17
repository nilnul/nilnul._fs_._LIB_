namespace nilnul.fs.folder.be
{
	public class Anto1 : nilnul.obj.be.Anto<nilnul.fs.FolderI>
		,
		nilnul.fs.folder.BeI
		,
		nilnul.fs.address.BeI
		,
		nilnul.txt.BeI
	{
		public Anto1(nilnul.obj.BeI1<FolderI> be) : base(be)
		{
		}

		public bool be(AddressI obj)
		{
			return be(new nilnul.fs.Folder(obj));
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.Folder.FroAddress(obj));
		}
	}
}
