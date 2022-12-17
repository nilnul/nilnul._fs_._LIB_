using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// </summary>
	public class DestinyDisjoint :
	   BeOfSeqI

	{
		public bool be(IEnumerable<nilnul.fs.FolderI> folders)
		{
			return nilnul.fs.address_.shields.be_.Disjoint1.Singleton.be(
				folders.Select(
					f => nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(f).en.address.en
				)
			);
		}


		static public DestinyDisjoint Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<DestinyDisjoint>.Instance;
			}
		}


	}
}
