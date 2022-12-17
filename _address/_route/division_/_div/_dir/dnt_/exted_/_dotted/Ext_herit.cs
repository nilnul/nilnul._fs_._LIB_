using nilnul.fs._address.doc_._exted.ext_;
using nilnul.fs._address.doc_._exted.ext_._ovAftDot.aftDot.be;

namespace nilnul.fs._address.doc_.exted_._dotted
{
	/// <summary>
	/// </summary>
	public class Ext_herit
		: doc_._exted.ext_.OvAftDot
		,
		ExtI
	{
		public Ext_herit(En val) : base(val)
		{
		}

		public Ext_herit(OvAftDot ext) : base(ext)
		{
		}

		static public Ext_herit Ov(OvAftDotI ext)
		{
			switch (ext)
			{
				case OvAftDot ovAftDot:
					return new Ext_herit(ovAftDot);
				default:
					return new Ext_herit(OvAftDot.ParseOfLed(ext.ToString()));
					break;
			}
		}


		static public Ext_herit OvNoLead(string x)
		{
			return new Ext_herit(
				new En(x)
			);
		}
		static public Ext_herit OvLed(string x)
		{
			return new Ext_herit(
				OvAftDot.ParseOfLed(x)
			);
		}


	}
}
