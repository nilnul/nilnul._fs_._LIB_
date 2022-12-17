using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.volRoute_;

namespace nilnul.fs.address_.volRoute_.container.convert_.join_
{
	public static class _DirX
	{
		static public nilnul.fs.address_.volRoute_.Container Eval(
			nilnul.fs.address_.volRoute_.Container container
			,
			nilnul.fs._address.Dst dst
			
		) {
			return new Container(
				container.vol
				,
				nilnul.fs._address.route_.deckedDiv.convert_.join_._DirX.Eval(
					container.deckedDiv
					,dst
				)
			);
		}

		public static Container Eval_ofContainerDst(string container, string dst)
		{

			return Eval(
				nilnul.fs.address_.volRoute_.Container.Parse(container)
				,
				new nilnul.fs._address.Dst(dst)
			);

			throw new NotImplementedException();
		}

		public static Container Eval_ofContainerDst(Container container, string dst)
		{

			return Eval(
					container
				,
				new nilnul.fs._address.Dst(dst)
			
			);
		//	throw new NotImplementedException();
		}
	}
}
