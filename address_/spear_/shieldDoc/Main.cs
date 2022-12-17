using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear_.shieldDoc
{
	/// <summary>
	/// a shield and a _address.doc_._exted.Main
	/// </summary>
	static public class _MainX
	{
		static public string Txt_assumeSpear(string spear){
			///// GetFileNameWithoutExtension('C:\mydir\myfile.ext') returns 'myfile'
			// GetFileName('C:\mydir\') returns ''
			return System.IO.Path.GetFileNameWithoutExtension(spear);

		}
	}
}
