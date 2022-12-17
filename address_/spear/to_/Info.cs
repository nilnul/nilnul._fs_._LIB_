using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.to_
{
	public class Info
		:
		nilnul.fs.address_.spear.op_.ToI<System.IO.FileInfo>
	{
		public FileInfo op(SpearI1 par)
		{
			return new FileInfo(par.ToString());
		}

		static public Info Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Info>.Instance;
			}
		}

	}
}
