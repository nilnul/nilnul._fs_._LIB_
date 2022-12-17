using nilnul.obj;
using System;

namespace nilnul.fs.address_.spear.vow.ee_
{
	[Obsolete()]
	public class VowDefaulted<T> : Ee
		where T : nilnul.fs.address_.spear.VowI1, new()
	{
		public VowDefaulted(SpearI val) : base(val, nilnul.obj_.Singleton<T>.Instance)
		{
		}

		

		public VowDefaulted(string s) : base(s,  nilnul.obj_.Singleton<T>.Instance)
		{
		}
	}
}
