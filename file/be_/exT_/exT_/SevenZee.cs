using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_.exT_
{
	public class SevenZee : nilnul.fs.file.be_.Ext
	{
		public SevenZee() : base(".7z")
		{
		}


		static public SevenZee Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SevenZee>.Instance;
			}
		}

	}
}
