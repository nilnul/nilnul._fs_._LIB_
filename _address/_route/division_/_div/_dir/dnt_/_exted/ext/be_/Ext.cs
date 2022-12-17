using System;

namespace nilnul.fs._address.doc_._exted.ext.be_
{
	//todo: rename to "Specific"
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public class Ext : nilnul.obj.Box<nilnul.fs._address.doc_._exted.ExtI>
		,
		nilnul.fs._address.doc_._exted.ext.BeI
	{

		public Ext(doc_._exted.ExtI val) : base(val)
		{

		}
		public Ext(doc_._exted.Ext val) : base(val)
		{

		}


		public Ext(string v):this(
			new doc_._exted.Ext(v)
		)
		{
		}

		public bool be(doc_._exted.ExtI obj)
		{
			return doc_._exted.ext.Eq.Singleton.Equals(boxed, obj);
			//throw new NotImplementedException();
		}

	}
}
