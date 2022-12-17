using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be
{
	public class En : nilnul.obj.be.En4<nilnul.fs.FileI>
	{
		public En(FileI obj, BeI1<FileI> be) : base(obj, be)
		{
		}
	}
}
