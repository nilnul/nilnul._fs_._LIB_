using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_
{
	/// <summary>
	/// any file in "~/" is obsolete, otherwise shall apear in the parent folder of "~/"
	/// </summary>
	public class Obsolete : _address.Dir
	{
		public Obsolete() : base(
			new nilnul.fs._address.Doc(
			"~"
			)
		)
		{
		}
	}
}
