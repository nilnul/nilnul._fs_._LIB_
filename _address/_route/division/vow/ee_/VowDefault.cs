using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.vow.ee_
{
	public class VowDefault<TVow> :
		division.vow.Ee
		where TVow : division.VowI, new()
	{
		public VowDefault(DivisionI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
