using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink.coerce_
{
	/// <summary>
	/// delink
	/// </summary>
	/// alias:
	///		delink
	static public class _TgtX
	{
		static public nilnul.fs.folder_.Normal Normal(nilnul.fs.FolderI folder)
		{
			if (nilnul.fs.folder.be_.link_.Sym.Singleton.be(folder))
			{
				return nilnul.fs.folder_.link_.sym._DestinyX.Normal(
					new link_.Sym(folder)
				);
			}
			return new Normal(folder);
		}
		static public nilnul.fs.folder_.Normal Normal(nilnul.fs.address_.ShieldI folder)
		{
			return Normal(new nilnul.fs.Folder(folder));
		}

		static public nilnul.fs.folder_.Normal Normal(nilnul.fs.AddressI folder)
		{
			return Normal(nilnul.fs.address_.Shield.Ov(folder));
		}

		static public nilnul.fs.folder_.Normal Normal(string folder)
		{
			return Normal(nilnul.fs.address_.Shield.FroAddress(folder));
		}


	}
}
