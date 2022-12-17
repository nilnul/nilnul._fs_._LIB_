using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// one is the parent of the other or equal to the other. in other words, one nonstrictly contains the other, like the subset
	/// </summary>
	/// 
	[Obsolete()]
	static public class _SubX
	{
		static public bool Re(route_.Stem x, route_.Stem y) {
			return stem._EqX.Eq( co_._SharedStubX.Co(x,y) ,y);
		}
	}

	[Obsolete()]
	public class Sub : ReI
	{
		public bool re(StemI x, StemI y)
		{
			return stem._EqX.Eq( co_._SharedStubX.Co(x,y) ,y);

			//throw new NotImplementedException();
		}

		static public Sub Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Sub>.Instance;
			}
		}

	}
}
