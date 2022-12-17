using System;

namespace nilnul.fs._address._route.division_.denotation
{
	public interface BeI : nilnul.obj.BeI1<div.DntedI>
	{
	}
	public class Be :
		nilnul.obj.Be1<div.DntedI>
		,
		BeI
	{
		public Be(Predicate<div.DntedI> val) : base(val)
		{
		}

		public Be(Func<div.DntedI, bool> func) : base(func)
		{
		}

	}
}
