using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	public class Location : nilnul.fs.address.vow_.location.Ed
	{
		public Location(Address val) : base(val)
		{
		}

		static public Location CreateFroAddress(Address val) {
			if ( nilnul.fs.address.be_.Tipped.SingletonInstance.be(val)  )
			{
				if (nilnul.fs.address_.element.be_.Exist.Singleton.be(
					val
				))
				{
					return new Location(val);

				}

			}

			return new Location(val.toFolderLike());

		}


		static public Location CreateFroAddress(string  val) {
			return CreateFroAddress(
				Address.Parse(val)
			 );
		}


	}
}
