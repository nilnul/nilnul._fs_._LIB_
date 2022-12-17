using nilnul.fs._address;
using nilnul.fs._address.destination.dict_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.empty.destinations._link
{
	/// <summary>
	/// when the value of lication is file,
	///		the ext of the key should be the same as file.
	/// </summary>

	[Obsolete()]
	public class Dict : nilnul.obj.Box_pub<_address.destination.dict_.AsDenote<ILocation>>
		,
		nilnul.fs.IPac
	{

		private Dict(AsDenote<ILocation> val)
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

		static public Dict Create(AsDenote<ILocation> val)
		{
			_KeyIsDestionationX.KeyVowDocumentIfValIsFile(
				val
			);


			return new Dict(
				_KeyIsDestionationX.EnsureDweltExt_assumeKeyFormated(
					_KeyIsDestionationX.Key2DirectoryIfNeed(val)
				)
			);
		}

		static public Dict Ov(
			IEnumerable<KeyValuePair<DestinationI, ILocation>> enumerable
		)
		{

			var r = new AsDenote<ILocation>();
			enumerable.ForEach(e => r.Add(e.Key, e.Value));
			return Create(r);

		}
	}


}
