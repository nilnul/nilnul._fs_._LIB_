using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.division
{
	static public class _ToDenotationX
	{
		static public nilnul.fs._address.Denotation ToDenotation(
			contextual_.DivisionI division
		) {
			var shrunk = division.toLiteral();
			return nilnul.fs._address.division.op_.unary_.Shrink.Singleton.toDenotation(shrunk);
		}
	}
}
