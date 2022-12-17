using nilnul.obj;
using System;

namespace nilnul.fs.folder.be
{
	public class Vow2
		: nilnul.obj.be.Vow4<nilnul.fs.FolderI>
		,
		nilnul.fs.folder.VowI1
	{
		public Vow2(BeI1<FolderI> be) : base(be)
		{
		}

		public Vow2(Predicate<FolderI> predicate) : base(predicate)
		{
		}

		public Vow2(Func<FolderI, bool> func) : base(func)
		{
		}
	}
}
