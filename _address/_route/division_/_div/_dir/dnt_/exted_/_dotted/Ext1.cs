using nilnul.fs._address.doc_.exted_._dotted._ext;
using System;

namespace nilnul.fs._address.doc_.exted_._dotted
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	public class Ext
		: nilnul.obj.Box<_ext.NoLead>
		,
		ExtI
	{
		public Ext(NoLead val) : base(val)
		{
		}
		public override string ToString()
		{
			return $".{ boxed.ToString()}";
		}


	}
}
