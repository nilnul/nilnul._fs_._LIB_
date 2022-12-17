using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nilnul.fs.folder_
{
	public class Address
		: nilnul.fs.address_.shield_.Exist
	{
		public Address(nilnul.fs.address_.ShieldI val) : base(val)
		{

		}

		public nilnul.fs._address.route_.DeckedDiv route {
			get {
				return 
					ed.deckedDiv
				;
			}
		}

		static public implicit operator DirectoryInfo(Address folder)
		{
			return new DirectoryInfo(folder.ToString());
		}
		static public explicit operator Address(DirectoryInfo folder)
		{
			return new Address(
				folder
			);
		}
	}
}
