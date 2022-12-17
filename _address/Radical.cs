using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{
	/// <summary>
	/// related to root. a root-based container. such as:
	///		"/", "/a/", "/a/b/"
	/// </summary>
	public class Radicle:RadicleI
	{

		private Dirs _dirs;

		public Dirs dirs
		{
			get { return _dirs; }
			set { _dirs = value; }
		}


		public override string ToString()
		{
			return $"{System.IO.Path.DirectorySeparatorChar}{ _dirs}";
		}

	}
}
