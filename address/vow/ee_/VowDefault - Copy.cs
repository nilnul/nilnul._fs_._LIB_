using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.vow.ee_
{
	[Obsolete()]
	public class VowDefault<TVow> : fs.address.vow.Ee
		where TVow :
		VowI2<AddressI>
		//nilnul.fs.address.VowI
		, new()
	{
		public VowDefault(AddressI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
