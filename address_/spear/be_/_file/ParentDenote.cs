using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.address_.spear.be_._file
{
	static public class _ParentDenoteX
	{

		static public bool Be(nilnul.fs.address_.spear_.ParentDoc parentDoc) {
			if (!nilnul.fs.address_.shield.be_.Folder.Singleton.be(parentDoc.parent)) {
				return false;
			}

			return nilnul.fs.folder._DocsX.Docs(parentDoc.parent).Any(
				d=> nilnul.fs._address.doc.Eq.Singleton.Equals(d, parentDoc.doc)
			);

		}

		static public bool _Be_ofLong(string address) {
			return Be( nilnul.fs.address_.spear_.ParentDoc.Parse(address));
		}

		public static bool Be(string path)
		{
			if (path.Length >= nilnul.fs.address._OverlongX.MAX_LENGTH)
			{
				return _Be_ofLong(path);
			}
			return System.IO.File.Exists(path);

		}

	}


}
