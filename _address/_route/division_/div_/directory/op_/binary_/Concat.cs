using System.Linq;

namespace nilnul.fs._address.directory.op_.binary_
{
	public class Concat : BinaryI
	{
		public DirectoryI op(DirectoryI par, DirectoryI par1)
		{
			return new nilnul.fs._address.Directory(par.Dirs().Concat(par1.Dirs()));
			//throw new NotImplementedException();
		}

		public DirectoryI op(DirI par, DirectoryI par1)
		{
			return op(directory_._DirX.Directory(par), par1);
			//throw new NotImplementedException();
		}

		static public Concat Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Concat>.Instance;
			}
		}

	}
}
