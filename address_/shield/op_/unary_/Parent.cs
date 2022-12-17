using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerI = nilnul.fs.address_.ShieldI;
using Container = nilnul.fs.address_.Shield;

namespace nilnul.fs.address_.shield.op_.unary_
{
	static public class _ParentX 
	{

		static public ContainerI _Op(nilnul.fs.address_.ShieldI arg) {
			return new Container(
				arg.vol
				,

				 nilnul.fs._address.route_.stem.op_.unary_.Up.Singleton.op(
					arg.stem
					
				)
			);

		}
		

	}
}
