using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.volRoute_;

namespace nilnul.fs.address_.container.convert_.join_
{
	public static class _DstX
	{
		static public nilnul.fs.address_.Container Eval(
			nilnul.fs.address_.Container container
			,
			nilnul.fs._address_._path.Dst dst
			
		) {
			return new Container(
				new Address(
					container.ed.root
					,

					nilnul.fs._address_.path_.container.dst._AppendX._Append(
						container.ed.path 
						,dst
					).toFolderLike()
				)
				
			);
		}

		public static Container Eval(string container, string dir)
		{

			return Eval(
				nilnul.fs.address_.Container.CreateFroAddress(container)
				,
				new nilnul.fs._address_._path.Dst(dir)
			);

			throw new NotImplementedException();
		}

		
	}
}
