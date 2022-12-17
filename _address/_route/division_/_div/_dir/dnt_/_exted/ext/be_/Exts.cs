using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc_._exted.ext.be_
{
	public class Exts : nilnul.obj.Box<nilnul.fs._address.doc_._exted.ext.Set>
		,
		nilnul.fs._address.doc_._exted.ext.BeI
	{
		public Exts(doc_._exted.ext.Set val) : base(val)
		{

		}

		public bool be(doc_._exted.Ext obj)
		{
			return doc_._exted.ext.Eq.Singleton.Equals(boxed, obj);
			//throw new NotImplementedException();
		}

	}
}
