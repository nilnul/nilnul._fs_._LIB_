using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document
{
	[Obsolete()]
	public class Eq
		: IEqualityComparer<nilnul.fs._address.DocumentI1>
	{
		public bool Equals(DocumentI1 x, DocumentI1 y)
		{
			return nilnul.fs._address.div.Eq.Singleton.Equals(x.div,y.div)
				&&
				nilnul.fs._address.doc.Eq1.Singleton.Equals(x.doc,y.doc)
				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(DocumentI1 obj)
		{
			return
nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div)
				&
				nilnul.fs._address.doc.Eq1.Singleton.GetHashCode(obj.doc)
				;
			//throw new NotImplementedException();
		}



		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

		

	}
}
