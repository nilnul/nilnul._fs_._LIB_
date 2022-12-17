using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path
{

	static public class _ParseX
	{
		static public IPath Parse(string x)
		{

			var firstColon = x.IndexOf(":");
			if (firstColon >= 0)
			{
				try
				{
					return nilnul.fs.path_.Full.Parse(
						x
					);

				}
				catch (Exception e)
				{
					throw new path_.xpn_.ParseException("There is a colon, but parsing to full path failed", e);

				}

			}

			//no colon


			//there is / at the begining
			if (nilnul.txt.be_.fs_.BeginWithSep.Singleton.be(x))
			{
				try
				{
					return nilnul.fs.path_.Rted.Parse(x);

				}
				catch (Exception e)
				{
					throw new path_.xpn_.ParseException("starting with / or \\, but parsing to route failed", e);
				}
			}
			try
			{
				return nilnul.fs.path_.division._ParseX.Parse(x);
			}
			catch (Exception e)
			{
				throw new path_.xpn_.ParseException("parsing to division failed", e);

			}


		}

	}
}
