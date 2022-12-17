using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.prefixed
{
	/// <summary>
	/// prefixed by "", "file://", "//?/"
	/// </summary>
	public class Eq
		:
		nilnul.txt.eq_.homo_.EqDefaultOvCaseInsensitive
		,
		nilnul.txt.EqI
	{
		public Eq() : base(address._PrefixedX.Unprefix)
		{
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
