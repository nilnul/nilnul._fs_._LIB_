using nilnul.fs._address_._path;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path_.container.document
{
	static public class _AppendX
	{
		static public nilnul.fs._address_.Path _Append(
			nilnul.fs._address_.Path _container
			,
			nilnul.fs._address_._path.dsts_.Started document
		) {
				return  Path.Parse(
							_container.ToString()+ document.ToString() 
				);

		}
	}
}
