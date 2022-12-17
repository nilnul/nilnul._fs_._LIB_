using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerI = nilnul.fs.address_.ShieldI;
using Container = nilnul.fs.address_.Shield;

namespace nilnul.fs.address_.shield
{
	[Obsolete(nameof(shield.op_.unary_.Up))]
	public class UpN : ConvertI
	{

		static public ContainerI _Convert(ContainerI arg,uint n) {
			return new Container(
				arg.vol
				,

				 nilnul.fs._address.route_.stem.op_.unary_.UpN._Op(
					arg.stem
					,n
				)
			);

		}
		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}

		public UpN(uint n)
		{
			_n = n;
		}
		public ContainerI op(ContainerI arg)
		{
			return _Convert(arg, _n);
			//throw new NotImplementedException();

		}


	}
}
