using System.Linq;

namespace nilnul.fs._address.doc_._exted
{

	public interface Ext_emptyOrLedI
	: ExtI
	{

	}
	/// <summary>
	/// </summary>
	public class Ext_emptyOrLedA : Ext_emptyOrLedI

	{
		static public Ext_emptyOrLedI Parse(string s)
		{
			if (s.Any())
			{
				return ext_.OvAftDot.ParseOfLed(s);
			}
			return ext_.Empty.Singleton;
		}

		static public Ext_emptyOrLedI PrependDotIfNeed(string s)
		{
			if (s.Any())
			{
				if (s.StartsWith("."))
				{
					return ext_.OvAftDot.ParseOfLed(s);
				}
				return new ext_.OvAftDot(s);
			}
			return ext_.Empty.Singleton;
		}


		public static Ext_emptyOrLedI Parse(ExtI ext)
		{
			switch (ext)
			{
				case ext_.OvAftDot ovAftDot:
					return ovAftDot;
				case ext_.Empty empty:
					return empty;
				default:
					return Parse(ext.ToString());
					break;
			}
			//throw new NotImplementedException();
		}
	}


}
