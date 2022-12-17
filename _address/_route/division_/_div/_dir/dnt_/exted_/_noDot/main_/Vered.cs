using nilnul.txt_._vered;

namespace nilnul.fs._address.doc_.exted_._noDot.main_
{
	public class Vered
		:
		nilnul.txt_.Vered<_vered.Name>
		,
		_noDot.MainI
	{
		public Vered(_vered.Name prefix, NumI version) : base(prefix, version)
		{

		}

		public Vered(Name prefix, NumI version) : this(new _vered.Name(prefix), version)
		{
			//_main.txt.be.Vow.Singleton.vow(
			//	$"{prefix}{version}"
			//);
		}
		public Vered(string prefix, NumI version) : this(new Name(prefix), version)
		{
		}
		public Vered(Name prefix) : this(prefix, new nilnul.Num())
		{
		}

		public Vered(string prefix) : this(new Name(prefix))
		{
			_main.txt.be.Vow.Singleton.vow(prefix);
		}
		static public Vered OvNameNum(string name, string num)
		{
			return new Vered(name,
				nilnul.txt_.num_.radix_.Dec.Singleton.parse(num)
			);
		}

		static public Vered _OvNameNum(string[] _nameNum)
		{
			return OvNameNum(_nameNum[0], _nameNum[1]);
		}



#pragma warning disable CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
		static public Vered Parse(string s)
		{
#pragma warning restore CS0108 // 'Vered.Parse(string)' hides inherited member 'Vered.Parse(string)'. Use the new keyword if hiding was intended.
			return _OvNameNum(nilnul.txt_.Vered1.__Parse(s));
		}
	}
}
