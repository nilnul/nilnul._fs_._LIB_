using System;

namespace nilnul.fs.folder.be
{
	[Obsolete()]
	public class Anto<TBe> : nilnul.obj.be.Anto<nilnul.fs.FolderI, TBe>
		,
		nilnul.fs.folder.BeI
		,
		nilnul.fs.address.BeI
		,
		nilnul.txt.BeI
		where TBe : nilnul.fs.folder.BeI, new()
	{
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
