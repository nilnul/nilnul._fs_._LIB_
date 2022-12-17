using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.document_.divDoc
{
	[Obsolete()]
	public class Eq : IEqualityComparer<
		DivDoc
	>
	{
		public bool Equals(DivDoc x, DivDoc y)
		{
			return nilnul.fs._address.div.Eq.Singleton.Equals(x.div,y.div)
				&&

				nilnul.fs._address.doc.Eq.Singleton.Equals(x.doc,y.doc)
				
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(DivDoc obj)
		{
			return nilnul.fs._address.doc.Eq.Singleton.GetHashCode(obj.doc)
				&
				nilnul.fs._address.div.Eq.Singleton.GetHashCode(obj.div)
			;
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Eq>.Instance;
			}
		}

	}
}
