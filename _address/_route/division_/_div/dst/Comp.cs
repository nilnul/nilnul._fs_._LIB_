using System.Collections.Generic;

namespace nilnul.fs._address.dst
{
	public class Comp : IComparer<DstI>
	{
		public int Compare(DocI x, DstI y)
		{
			switch (y)
			{
				case DocI doc:
					return nilnul.fs._address.doc.Comp.Singleton.Compare(x, doc);
				case DirI dir:
					return -1;
				default:
					throw new UnexpectedTypeException();
			}
			//return nilnul.txt.comp_.CaseInsentive.Singleton.Compare(x.ToString(),y.ToString());
			//throw new NotImplementedException();
		}

		public int Compare(DirI x, DstI y)
		{
			switch (y)
			{
				case DocI doc:
					return 1;
				case DirI dir:
					return nilnul.fs._address.dir.Comp.Singleton.Compare(x, dir);
				default:
					throw new UnexpectedTypeException();
			}
			//return nilnul.txt.comp_.CaseInsentive.Singleton.Compare(x.ToString(),y.ToString());
			//throw new NotImplementedException();
		}

		public int Compare(DstI x, DstI y)
		{
			switch (x)
			{
				case DocI doc:
					return Compare(doc, y);
				case DirI dir:
					return Compare(dir, y);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
			//throw new NotImplementedException();
		}


		static public Comp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Comp>.Instance;
			}
		}


	}
}
