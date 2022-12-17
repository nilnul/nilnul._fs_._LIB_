using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_.exT_
{
	public class Zip : nilnul.fs.file.be_.Ext
	{
		public Zip() : base(".zip")
		{
		}


		static public Zip Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Zip>.Instance;
			}
		}

	}
}
