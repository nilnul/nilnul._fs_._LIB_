using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_
{
	/// <summary>
	/// given shield, get the newest
	/// </summary>
	static public class _NewestX
	{
		static public nilnul.fs.folder_.ParentDir Folder0nul(nilnul.fs.address_.shield_.BaseDir shield) {
			var t = new nilnul.fs.folder.dir_.Vered(shield.parent).veredNulableLatest_ofVered(shield.child.denote.en);
			if (t is null)
			{
				return null;
			}
			return  nilnul.fs.folder_.ParentDir._OvDenote(
				shield.parent
				,
				t
			);

		}

		static public nilnul.fs.FolderI Folder0nul(nilnul.fs.address_.ShieldI shield) {
			if (nilnul.fs.address_.shield.be_.Root.Singleton.be(shield) )
			{
				return new nilnul.fs.Folder(shield);
			}
			return Folder0nul(
				nilnul.fs.address_.shield_.BaseDir._Ov(shield)
			);

		}
		static public nilnul.fs.FolderI Folder0nul(nilnul.fs.address_.SpearI shield) {
			return Folder0nul(
				nilnul.fs.address_.shield_._SpearX.Shield(shield)
			);

		}


	}
}
