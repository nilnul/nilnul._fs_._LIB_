using System;

namespace nilnul.fs.address_.spear
{
	/*extern alias obj;*/

	public interface BeI<T>
		:
		/*obj::*/nilnul.obj.BeI1<T>
	//,
	//nilnul.BeI<nilnul.fs.address_.SpearI>
	where T: nilnul.fs.address_.SpearI1
	{
	}

}
