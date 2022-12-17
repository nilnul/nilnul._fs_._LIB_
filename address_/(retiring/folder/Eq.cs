using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.folder
{
	public class Eq
		: IEqualityComparer<nilnul.fs.address_.Folder>
	{
		public bool Equals(Folder x, Folder y)
		{
			return nilnul.fs._address.root.Eq.Singleton.Equals(x.root, y.root)

				&&

				nilnul.fs._address.stem.Eq.Singleton.Equals(x.stem, y.stem);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Folder obj)
		{
			return nilnul.fs._address.root.Eq.Singleton.GetHashCode(obj.root) 
				& 
			nilnul.fs._address.stem.Eq.Singleton.GetHashCode(obj.stem);
			//throw new NotImplementedException();
		}

		public bool Equals(string x, string y) {
			return Equals(
				nilnul.fs.address_.Folder.Parse(x)
				,
				nilnul.fs.address_.Folder.Parse(y)
			);
		}

		public bool Equals(string x, nilnul.fs.address_.Folder y) {
			return Equals(
				nilnul.fs.address_.Folder.Parse(x)
				,
				(y)
			);
		}



		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
