namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_
{
	/// <summary>
	/// no dot in.  but output a dot led
	/// </summary>
	public interface OvAftDotI :   ext_.INonempty,ext_.NonemptyI
	{
	}
	public class OvAftDot :
		obj.Box1<_nonempty.aftDot.be.vow_.beDefault.Ee>
		,
		OvAftDotI
	{
		public OvAftDot(_nonempty.aftDot.be.vow_.beDefault.Ee val) : base(val)
		{
		}

		public OvAftDot(string x) : this(new _nonempty.aftDot.be.vow_.beDefault.Ee(x))
		{

		}

		public _nonempty.aftDot.be.vow_.beDefault.Ee aftDot { get { return boxed; } }

		//public _ext.txt.En txt =>  new Ext($".{boxed}");
		public override string ToString()
		{
			return $".{boxed}";
		}

		static public OvAftDot ParseOfLed(string s)
		{
			nilnul.character_.cha.eq._VowX.Vow(s[0], '.', "must start with '.'");
			return new OvAftDot(
				s.Substring(1)
			);
		}

		static public OvAftDot PrependDotIfNeed(string s) {
			if (s.StartsWith("."))
			{
				return new OvAftDot(s.Substring(1));
			}
			return new OvAftDot(s);
		}
	}

}
