using System.Collections.Generic;

namespace nilnul.fs.folder
{
	public interface EqI : IEqualityComparer<nilnul.fs.FolderI>
	{

	}
	public class Eq : EqI
	{
		public bool Equals(FolderI x, FolderI y)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(x.address.en, y.address.en);
			//throw new NotImplementedException();
		}

		public int GetHashCode(FolderI obj)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.GetHashCode(obj.address.en);
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Eq>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Eq>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
