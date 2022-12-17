using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._file
{
	static public class _CreateX
	{
		static public bool CreatedIfNotExist(string spear, string blob)
		{
			return CreatedIfNotExist(
			 new nilnul.fs.address_.Spear(spear),blob
			);
		}
		static public bool CreatedIfNotExist(nilnul.fs.address_.SpearI spear, string blob)
		{
			if (nilnul.fs.address_.spear.be_.occupied.Anto.Singleton.be(spear))
			{
				System.IO.File.WriteAllText(spear.ToString(), blob);
				return true;
			}
			return false;
		}


	}
}
