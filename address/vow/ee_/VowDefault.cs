using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.vow.ee_
{
	public class VowDefault1<TVow> : fs.address.vow.Ee1
		where TVow :
		VowI2<AddressI1>
		//nilnul.fs.address.VowI
		, new()
	{
		public VowDefault1(AddressI1 val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}
	}
}
