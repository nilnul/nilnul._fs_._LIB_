using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// </summary>
	static public class _DisjointX
	{
		static public bool _Be(IEnumerable<nilnul.fs.FolderI> folders)
		{
			if (nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return true;
			}
			return _Be(folders.First(), nilnul.obj.seq_.headed._TailX._Tail(folders));
		}


		static public bool Be(nilnul.objs_.EnumerableI<nilnul.fs.FolderI> folders)
		{
			return _Be(folders);
		}

		public static bool Be(FolderI[] folders)
		{
			return _Be(folders);
			//throw new NotImplementedException();
		}


		static bool _Be(nilnul.fs.FolderI folder, IEnumerable<nilnul.fs.FolderI> _disjointFinite)
		{
			return _disjointFinite.All(
				element => nilnul.fs.folder.re_._DisjointX.Re(element, folder)
			);
		}




	}

	public class Disjoint : nilnul.fs.folders.BeI, BeOfSeqI
	{
		public bool be(FoldersI obj)
		{
			return _DisjointX.Be(obj.toArr());
			//throw new NotImplementedException();
		}

		public bool be(IEnumerable<FolderI> obj)
		{
			return _DisjointX._Be(obj);

			;
		}

		static public Disjoint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Disjoint>.Instance;
			}
		}

	}
}
