using System;

namespace nilnul.fs._address.document
{
	[Obsolete()]
	public interface BeI : nilnul.BeI<DocumentI>
	{
	}
	[Obsolete()]
	public class Be :
		nilnul.Be1<DocumentI>
		,
		BeI
	{
		public Be(Predicate<DocumentI> val) : base(val)
		{
		}

		public Be(Func<DocumentI, bool> func) : base(func)
		{
		}
	}
}
