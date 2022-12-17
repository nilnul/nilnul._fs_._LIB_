using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.sups_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ExistedX
	{
		static public IEnumerable<nilnul.fs.address_.ShieldI> Seq(nilnul.fs.address_.ShieldI origin)
		{
			return _SupsX.Sups(origin).SkipWhile(x => nilnul.fs.address_.shield.be_.NotFolder.Singleton.be(x));
		}
	}
}
