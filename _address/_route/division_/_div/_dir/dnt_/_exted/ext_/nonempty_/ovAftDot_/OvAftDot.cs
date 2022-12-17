using System;

namespace nilnul.fs._address.doc_._exted.ext_
{
	/// <summary>
	/// no dot in.  but output a dot led
	/// </summary>
	[Obsolete()]
	public interface OvAftDotI : ExtI, _exted.Ext_emptyOrLedI, ext_.INonempty
	{
	}
	[Obsolete()]
	public class OvAftDot :
		obj.Box<_ovAftDot.aftDot.be.En>
		,
		OvAftDotI
	{
		public OvAftDot(_ovAftDot.aftDot.be.En val) : base(val)
		{
		}

		public OvAftDot(string x) : this(new _ovAftDot.aftDot.be.En(x))
		{

		}

		public _ovAftDot.aftDot.be.En aftDot { get { return boxed; } }

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
