using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.vow.ee_
{
	public class VowDefault<TVow>
		: path.vow.Ee
		where TVow : fs.path.VowI, new()
	{
		public VowDefault(IPath val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
