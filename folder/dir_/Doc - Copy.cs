using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_
{
	[Obsolete(nameof(dst.to_._ElementX))]
	public class Doc
	{
		static public nilnul.fs.address_.Element CreateAddress(nilnul.fs.Folder container, nilnul.fs._address_._path.DstI dst)
		{
			return new nilnul.fs.address_.Element(System.IO.Path.Combine(container.ToString(), dst.ToString()));
		}


		static public nilnul.fs.address_.Element CreateAddress(nilnul.fs.Folder container, string dst)
		{
			return CreateAddress(
				container
				,
				new nilnul.fs._address_._path.Dst(dst) as nilnul.fs._address_._path.DstI
			);
		}


	}
}
