using System.Collections.Generic;

namespace nilnul.fs.address_.shields
{
	public interface VowI1 : nilnul.obj.VowI<nilnul.fs.address_.ShieldsI>
	{
	}

	public interface VowOfSeqI :
		nilnul.obj.VowI2<
			IEnumerable<nilnul.fs.address_.ShieldI>
		>
	{


	}
}
