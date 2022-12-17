using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.volRoute_.container.convert_
{
	/// <summary>
	/// get to the parent container
	/// </summary>
	public class Up : ConvertI
	{
		public ContainerI eval(ContainerI arg)
		{
			return new Container(
				arg.vol
				,

				nilnul.fs._address.route_.deckedDiv.convert_.Up.Singleton.eval(
					arg.deckedDiv
				)
			);
			throw new NotImplementedException();
		}


		static public readonly Up Singleton = nilnul.obj.SingletonByDefault<Up>.Instance;

	}
}
