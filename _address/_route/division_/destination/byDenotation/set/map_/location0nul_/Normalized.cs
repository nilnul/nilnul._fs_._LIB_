using nilnul.fs._address;
using nilnul.fs._address._route.division_.destination.map_.location0nul.op_.unary_._normalize_;
using nilnul.fs._address.destination.dict_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K = nilnul.fs._address._route.division_.destination.map_.location0nul_.KeyAsDnts<nilnul.fs.ILocation>;

namespace nilnul.fs._address._route.division_.destination.byDenotation.set.map_.location0nul_
{
	/// <summary>
	/// when the value of lication is file,
	///		the ext of the key should be the same as file.
	/// </summary>

	public class Normalized : nilnul.obj.Box_pub<_address._route.division_.destination.map_.location0nul_.KeyAsDnts<ILocation>>
		,
		nilnul.fs.IPac
	{

		private Normalized(K val)
			:
			base(
_KeyIsDestionationX.EnsureDweltExt_assumeKeyFormated(
_KeyIsDestionationX.Key2DirectoryIfNeed(val)
	)

		)
		{
			_KeyIsDestionationX.KeyVowDocumentIfValIsFile(
				boxed
			);
			;

		}

		static public Normalized Create(K val)
		{
			_KeyIsDestionationX.KeyVowDocumentIfValIsFile(
				val
			);


			return new Normalized(
				_KeyIsDestionationX.EnsureDweltExt_assumeKeyFormated(
					_KeyIsDestionationX.Key2DirectoryIfNeed(val)
				)
			);
		}

		static public Normalized Ov(
			IEnumerable<KeyValuePair<DestinationI, ILocation>> enumerable
		)
		{

			var r = new K();
			enumerable.ForEach(e => r.Add(e.Key, e.Value));
			return Create(r);

		}
	}


}
