using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._location_;

namespace nilnul.fs.location.nulable.be_
{
	public class File :
		nilnul.obj.nulable.be_.nulFalse_.Default<
			nilnul.fs._location_.BlankI
			,
			nilnul.fs.location.be_.File
		>
		,
		nilnul.fs.location.BeI
	{
		static public File Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<File>.Instance;
			}
		}

		public bool be(LocationI obj)
		{
			return be((nilnul.fs._location_.BlankI) obj);
		}
	}
}
