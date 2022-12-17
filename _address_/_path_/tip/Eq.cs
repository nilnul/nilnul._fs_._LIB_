using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address_._path;

namespace nilnul.fs._address_._path_.tip
{
	public class Eq : nilnul.obj.opt.Eq< nilnul.fs._address_._path.Dst, nilnul.fs._address_._path_.Tip>
	{
		public Eq() : base(nilnul.fs._address_._path.dst.Eq.Singleton)
		{
		}


		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;



	}
}
