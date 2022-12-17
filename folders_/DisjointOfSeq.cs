using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.folders_
{
	public class DisjointOfSeq :
		nilnul.fs.folders.be_.disjoint.vow.EeOfSeq
		, nilnul.fs.FoldersI
	{

		private DisjointOfSeq(FoldersI val) : base(val)
		{
		}

		private DisjointOfSeq(IEnumerable<FolderI> _disjoint) : this(
			new folders_.Enumable(_disjoint) as FoldersI
		)
		{
		}
		public DisjointOfSeq() : this(new Folders())
		{
		}

		public FolderI[] toArr()
		{
			return ed.toArr();
			//throw new NotImplementedException();
		}

		static public DisjointOfSeq Fro(IEnumerable<FolderI> folders)
		{
			if (nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return new DisjointOfSeq();
			}
			return new DisjointOfSeq(
				_Fro(
					nilnul.obj.seq_.headed._TailX._Tail(folders), nilnul.obj.seq_.headed._HeadX._Head(folders)
				)
			);
		}

		static public DisjointOfSeq OfAddresses(IEnumerable<string> folders)
		{
			return Fro(folders.Select(x => nilnul.fs.Folder.FroAddress(x)));

		}


		static public DisjointOfSeq Fro(FoldersI folders)
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
