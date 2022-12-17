using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem.re_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	public class Sub1 : ReI1
	{
		public bool re(StemI1 x, StemI1 y)
		{
			return stem._EqX1.Eq( co_._SharedStubX1.Co(x,y) ,y);

			//throw new NotImplementedException();
		}

		static public Sub1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Sub1>.Instance;
			}
		}

	}
}
