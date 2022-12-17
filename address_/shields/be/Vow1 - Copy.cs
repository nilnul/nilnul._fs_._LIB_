using System.Collections.Generic;

namespace nilnul.fs.address_.shields.be
{
	public class Vow1<T>
		:
		nilnul.obj.be.Vow1<nilnul.fs.address_.ShieldsI, T>
		,
		nilnul.fs.address_.shields.VowI1
		,
		address_.shields.VowOfSeqI
		where T : BeI1, new()
	{
		public void vow(IEnumerable<ShieldI> obj)
		{
			 base.vow(
				new nilnul.fs.address_.Shields(obj)
			);
			//throw new System.NotImplementedException();
		}
	}
}
