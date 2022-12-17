using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._dir.name.be_
{
	/// <summary>
	/// </summary>
	public class Valid : nilnul.txt.BeI
	{

		

		public bool be(string obj)
		{
			return _dst.name.be_.Valid.Singleton.be(obj)  ;

		}


		static public readonly Valid Singleton = SingletonByDefault<Valid>.Instance;


		static private Lazy<Valid> _Lazy = new Lazy<Valid>();
		static public Valid Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public class En : nilnul.obj.be.En_beDefaultable<string, Valid>
		{
			public En(string val) : base(val)
			{
			}
		}



	}
}
