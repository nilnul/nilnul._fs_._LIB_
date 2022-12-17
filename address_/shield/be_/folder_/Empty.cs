using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_.folder_
{
	public class Empty : shield.BeI1
	{
		public bool be(ShieldI obj)
		{
			return shield.be_.Folder.Singleton.be(obj) && nilnul.fs.folder.be_.Empty.Singleton.be(obj);
			//throw new NotImplementedException();
		}


		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}

	}
}
