using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.doc_._dotted;

namespace nilnul.fs._address.doc.be_
{
	/// <summary>
	/// noDot is regarded as with extension "";
	/// </summary>
	/// 
	[Obsolete()]
	public class Ext1
		:
		nilnul.Box1<nilnul.fs._address._doc.Ext>
		,
		BeI1
		,BeI2
	{

		public Ext1(_doc.Ext val) : base(val)
		{
		}

		public Ext1(string s):this(new _doc.Ext(s))
		{

		}

		public bool be(string doc) {
			return be(new Doc1(doc));
		}
		public bool be(Doc1 obj)
		{
			return be((DocI1)obj);
		}
		public bool be(DocI1 obj)
		{
			
			

			return _doc.ext.Eq.Singleton.Equals( 
				boxed 
				,
				nilnul.fs._address.doc._ExtX2.Exe(obj)
				
			);
			//throw new NotImplementedException();
		}

		public bool be(DocI2 obj)
		{
			return _doc.ext.Eq.Singleton.Equals( 
				boxed 
				,
				nilnul.fs._address.doc._ExtX3.Exe(obj)
				
			);

		}
	}
}
