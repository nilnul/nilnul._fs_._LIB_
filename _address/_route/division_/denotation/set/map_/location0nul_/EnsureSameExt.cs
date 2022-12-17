using nilnul.fs._address;
using nilnul.fs._address._route.division_.destination.map_.location0nul.op_.unary_._normalize_;
using nilnul.fs._address.destination.dict_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K = nilnul.fs._address._route.division_.denotation.set.map_.Location0nul;

namespace nilnul.fs._address._route.division_.denotation.set.map_.location0nul_
{
	/// <summary>
	/// when the value of lication is file,
	///		the ext of the key should be the same as file.
	/// </summary>

	public class EnsuredExt : nilnul.obj.Box_pub<_address._route.division_.denotation.set.map_.Location0nul>
		,
		nilnul.fs.IPac
	{

		private EnsuredExt(K val)
			:
			base(
				location0nul.op_.unary_._EnsureExtX.EnsureExt(
val
	)

		)
		{
			

		}

		

		static public EnsuredExt Ov(
			IEnumerable<KeyValuePair<div.DntedI, ILocation>> enumerable
		)
		{

			var r = new K();
			enumerable.ForEach(e => r.Add(e.Key, e.Value));
			return new EnsuredExt(r);

		}
	}


}
