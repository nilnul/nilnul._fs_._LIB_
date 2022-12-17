using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class DotLed : dir.BeI
	{
		public bool be(DirI obj)
		{
			return obj.denote.en.StartsWith(".");
		}


		static public DotLed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DotLed>.Instance;
			}
		}

	}
}
