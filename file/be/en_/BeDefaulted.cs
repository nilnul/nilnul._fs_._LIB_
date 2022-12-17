using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be.en_
{
	public class BeDefaulted<TBe>
		: file.be.En
		where TBe : nilnul.obj.BeI1<nilnul.fs.FileI>,new()
	{
		public BeDefaulted(FileI obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}
