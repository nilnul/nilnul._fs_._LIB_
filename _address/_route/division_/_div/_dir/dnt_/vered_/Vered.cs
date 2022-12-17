using nilnul.txt_._vered;


namespace nilnul.fs._address._dst.denote_.vered_
{

	public class BaseValid : nilnul.txt_.Vered2
	{
		public BaseValid(nilnul.txt_._vered.Name prefix, NumI1 version) : base(prefix, version)
		{
			_denote.txt.Vow.Singleton.vow(
				$"{prefix}{version}"
			);
		}

		public BaseValid(string prefix, NumI1 version) : this(new Name(prefix), version)
		{
		}
		public BaseValid(Name prefix) : this(prefix, new nilnul.Num1())
		{
		}

		public BaseValid(string prefix) : this(new Name(prefix))
		{
			_denote.txt.Vow.Singleton.vow(prefix);
		}

		public _vered.Germ germ => new _vered.Germ(
					this.name
		);

#pragma warning disable CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
		static public BaseValid Parse(string s)
		{
#pragma warning restore CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
			return new BaseValid(
				nilnul.txt_.Vered2.Parse(s)
			);
		}
	}
}
