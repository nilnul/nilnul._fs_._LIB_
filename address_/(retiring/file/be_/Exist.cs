using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.fs.address_.file.be_
{
	/*extern alias obj;*/
	public class Exist
		:
		/*obj::*/nilnul.obj.BeI1<nilnul.fs.address_.File>
	{
		public bool be(address_.File obj)
		{
			return System.IO.File.Exists(
				obj.ToString()	
			);
			//throw new NotImplementedException();
		}

		static public readonly Exist Singleton = SingletonByDefault<Exist>.Instance;


		public class En
			:
			nilnul.obj.be.En_beDefaultable<nilnul.fs.address_.File, Exist>
		{
			public En(address_.File val) : base(val)
			{

			}
		}
	}
}
