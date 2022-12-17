using nilnul.obj;
using System;

namespace nilnul.fs.file.be
{
	public class Vow2 : nilnul.obj.be.Vow4<nilnul.fs.FileI>
		,
		nilnul.fs.file.VowI
	{
		public Vow2(BeI1<FileI> be) : base(be)
		{
		}

		public Vow2(Predicate<FileI> predicate) : base(predicate)
		{
		}

		public Vow2(Func<FileI, bool> func) : base(func)
		{
		}
	}
}