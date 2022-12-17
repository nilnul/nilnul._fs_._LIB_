using nilnul.fs.address_.spear_.based_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file
{
	static public class _SizeX
	{
		static public long Size(nilnul.fs.FileI1 file) {
			return nilnul.fs.file.to_.ToFileInfo.Singleton.to(file).Length;
		}

		public static long  Size(nilnul.fs.address_.SpearI1 d)
		{
			return nilnul.fs.address_.spear.to_.Info.Singleton.op(d).Length;

		}
	}
}
