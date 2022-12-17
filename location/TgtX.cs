using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location
{
	static public class _TgtX
	{


		static public string TgtAsTxt(ILocation shield)
		{
			if (nilnul.fs.location.be_.Symlink.Singleton.be(shield))
			{
				return  nilnul.fs.location_.link_.sym._TgtX.Path(shield);
			}
			else
			{
				return shield.ToString();
			}

		}

		public static string TgtAsTxt(File0FolderI shield )
		{
			if (nilnul.fs.location.be_.Symlink.Singleton.be(shield))
			{
				return  nilnul.fs.location_.link_.sym._TgtX.Path(shield);
			}
			else
			{
				return shield.ToString();
			}

		}

		static public string TgtAsTxt(LocationI shield)
		{
			if (nilnul.fs.location.be_.Symlink.Singleton.be(shield))
			{
				return  nilnul.fs.location_.link_.sym._TgtX.Path(shield);
			}
			else
			{
				return shield.ToString();
			}

		}

		public static string TgtAsTxt(ShieldI shield)
		{
			return TgtAsTxt(nilnul.fs.LocationA.Location(shield));
		}

		public static string TgtAsTxt(SpearI shield)
		{
			return TgtAsTxt( nilnul.fs.LocationA.Location(shield) );
			//throw new NotImplementedException();
		}

	}


}
