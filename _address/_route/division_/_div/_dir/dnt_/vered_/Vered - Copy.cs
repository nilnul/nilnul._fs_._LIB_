using nilnul.txt_._vered_;
using System;

namespace nilnul.fs._address._dst.denote_
{
	[Obsolete()]
	public class Vered : nilnul.txt_.Vered
	{
		public Vered(Name prefix, NumI version) : base(prefix, version)
		{
			_denote.txt.Vow.Singleton.vow(
				$"{prefix}{version}"
			);
		}

		public Vered(string prefix, NumI version) : this(new Name(prefix), version)
		{
		}
		public Vered(Name prefix) : this(prefix, new nilnul.Num())
		{
		}

		public Vered(string prefix) : this(new Name(prefix))
		{
			_denote.txt.Vow.Singleton.vow(prefix);
		}

		public _vered_.Germ germ => new _vered_.Germ(
					this.name
		);

#pragma warning disable CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
		static public Vered Parse(string s)
		{
#pragma warning restore CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
			return new Vered(
				nilnul.txt_.Vered.Parse(s)
			);
		}
	}
}
