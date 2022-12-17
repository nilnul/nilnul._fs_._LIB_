using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders_
{
	public class Disjoint :
		nilnul.fs.folders.be_.disjoint.vow.Ee
		, nilnul.fs.FoldersI
	{

		public Disjoint(FoldersI val) : base(val)
		{
		}

		public Disjoint(IEnumerable<FolderI> _disjoint) : this(
			new folders_.Enumable(_disjoint) as FoldersI
		)
		{
		}
		public Disjoint() : this(new Folders())
		{
		}

		public FolderI[] toArr()
		{
			return ed.toArr();
			//throw new NotImplementedException();
		}

		static public Disjoint Fro(IEnumerable<FolderI> folders)
		{
			if (nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return new Disjoint();
			}
			return new Disjoint(
				_Fro(
					nilnul.obj.seq_.headed._TailX._Tail(folders), nilnul.obj.seq_.headed._HeadX._Head(folders)
				)
			);
		}

		static public Disjoint OfAddresses(IEnumerable<string> folders)
		{
			return Fro(folders.Select(x => nilnul.fs.Folder.FroAddress(x)));

		}


		static public Disjoint Fro(FoldersI folders)
		{
			return Fro(folders.toArr());
		}

		//static public void Absorb(List<nilnul.fs.FolderI> _disjoint, nilnul.fs.FolderI candidate) {

		//	var t=_disjoint.RemoveAll( x => nilnul.fs.folder.re_.Sub.Singleton.re(x, candidate ));

		//	if (nilnul.obj.seq.be_._NoneX.None( _disjoint, x=> nilnul.fs.folder.re_.Sup.Singleton.re(x,candidate) ) )
		//	{
		//		_disjoint.Add(candidate);
		//	}

		//}

		static public IEnumerable<nilnul.fs.FolderI> _Fro(IEnumerable<nilnul.fs.FolderI> _disjoint, nilnul.fs.FolderI candidate)
		{

			var t = _disjoint.Where(x => nilnul.fs.folder.re_.sub.Complement.Singleton.re(x, candidate));

			if (nilnul.obj.seq.be_._NoneX.None(_disjoint, x => nilnul.fs.folder.re_.Sup.Singleton.re(x, candidate)))
			{
				return nilnul.obj.seq.convert_._AppendX.Append(
					t, candidate
				);
			}
			return t;
		}
	}
}
