using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.nulable
{
	
	static public class _ParseX
	{
		static public IPath Parse(string x) {

			try
			{
				return nilnul.fs.path._ParseX.Parse(x);
			}
			catch (path_.xpn_.ParseException)
			{
				return null;
				//throw;
			}

			
		}

	}
}
