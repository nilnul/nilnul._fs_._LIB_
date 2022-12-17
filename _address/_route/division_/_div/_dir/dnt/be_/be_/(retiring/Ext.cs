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
	public class Ext
		:
		nilnul.obj.Box<nilnul.fs._address.doc_._dotted.Ext>
		,
		BeI
	{
		public Ext(doc_._dotted.Ext val) : base(val)
		{
		}

		public Ext(string s):this(new doc_._dotted.Ext(s))
		{

		}

		public bool be(DocI obj)
		{
			if (obj is doc_.NoDot)
			{
				if (this.boxed.ToString() == "")
				{
					return true;
				}
				return false;

			}

			return doc_._dotted.ext.Eq.Singleton.Equals(((doc_.Dotted)obj).extMember , boxed);
			//throw new NotImplementedException();
		}
	}
}
