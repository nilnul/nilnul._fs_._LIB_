using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.link_
{
	/// <summary>
	/// </summary>
	//static  class _SymX
	//{
	//}

	public class Sym : nilnul.fs.folder.be_.link_.sym.vow.Ee
		,
		nilnul.fs.folder_.ILink
	{
		public Sym(FolderI val) : base(val)
		{
		}

		public Sym(ShieldI sym):this(new nilnul.fs.Folder(sym) )
		{
		}

		public Exist address => ee.address;
	}

}
