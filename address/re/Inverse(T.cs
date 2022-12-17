using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.fs.address.re
{
	public class Converse<TRe> : nilnul.obj.re.Converse<nilnul.fs.AddressI>
		,ReI
		where TRe:address.ReI,new()
	{
		public Converse() : base(nilnul.obj_.Singleton<TRe>.Instance)
		{
		}

		static public Converse<TRe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Converse<TRe>>.Instance;
			}
		}

	}


}
