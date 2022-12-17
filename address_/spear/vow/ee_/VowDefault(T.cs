using nilnul.obj;

namespace nilnul.fs.address_.spear.vow.ee_
{
	public class VowDefault<TSpear,TVow> : Ee<TSpear>
		where TVow : nilnul.fs.address_.spear.VowI<TSpear>, new()
		where TSpear:nilnul.fs.address_.SpearI1
	{
		public VowDefault(TSpear val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}



		
	}
}
