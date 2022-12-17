using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.be_
{
	public class NotExist
		: nilnul.fs.address_.spear.be.Anto<Exist>
	{
		//public bool be(SpearI1 obj)
		//{
		//	return !System.IO.File.Exists(obj.ToString());
		//	throw new NotImplementedException();
		//}



		static public NotExist Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NotExist>.Instance;
			}
		}




	}
}
