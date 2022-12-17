using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.destination.dict_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// for keyEq, destination is regarded as denotation, 
	/// </remarks>
	/// <typeparam name="TVal"></typeparam>
	///
	[Obsolete()]
	public class AsDenote<TVal> :
		nilnul.obj.Dict<nilnul.fs._address.DestinationI, TVal, destination.eq_.Location>
		,
		nilnul.fs.IPac
	{

	}
}
