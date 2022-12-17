using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.nonlink.coerce_
{
	static public class _TgtX
	{
		static public nilnul.fs.file_.Nonlink Normal(nilnul.fs.FileI folder) {
			if (nilnul.fs.file.be_.Nonlink.Singleton.be(folder) )
			{
				return new Nonlink(folder);
			}
			return new nilnul.fs.file_.Nonlink(
				nilnul.fs.file_.link_.sym._TargetX.Address(folder)
			);
		}
		static public nilnul.fs.file_.Nonlink Normal(nilnul.fs.address_.SpearI folder)
		{
			return Normal(new nilnul.fs.File(folder));
		}

		static public nilnul.fs.file_.Nonlink Normal(nilnul.fs.AddressI folder)
		{
			return Normal(  nilnul.fs.address_.Spear.OfSpear(folder));
		}

		static public nilnul.fs.file_.Nonlink Normal(string folder)
		{
			return Normal(new nilnul.fs.address_.Spear(folder));
		}


	}
}
