using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShieldI = nilnul.fs.address_.ShieldI;
using Container = nilnul.fs.address_.Shield;

namespace nilnul.fs.address_.shield.op_.unary_
{
	public class Up : nilnul.fs.address_.shield.op_.UnaryI
	{

		static public ShieldI Op(ShieldI arg,uint n) {
			return new Container(
				arg.vol
				,

				 nilnul.fs._address.route_.stem.op_.unary_.UpN._Op(
					arg.stem
					,n
				)
			);

		}
		public static ShieldI Op(ShieldI container, int v)
		{
			return Op(
				container, (uint)v
			);
		}
		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}

		public Up(uint n)
		{
			_n = n;
		}
		public ShieldI op(ShieldI arg)
		{
			return Op(arg, _n);
			//throw new NotImplementedException();

		}

	}
}
