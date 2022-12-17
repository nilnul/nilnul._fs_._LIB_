using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_.exT_
{
	public class Rar : nilnul.fs.file.be_.Ext
	{
		public Rar() : base(".rar")
		{
		}


		static public Rar Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Rar>.Instance;
			}
		}

	}
}
