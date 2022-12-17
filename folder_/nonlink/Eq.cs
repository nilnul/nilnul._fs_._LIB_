using System;
using System.Collections.Generic;

namespace nilnul.fs.folder_.nonlink
{
	public interface EqI : IEqualityComparer<nilnul.fs.folder_.Normal>
	{
	}

	public class Eq : EqI
	{
		public bool Equals(Normal x, Normal y)
		{
			return nilnul.fs.folder.Eq.Singleton.Equals(x.en, y.en);
			//throw new NotImplementedException();
		}

		public bool eq(nilnul.fs.FolderI a, nilnul.fs.FolderI b) {
			return Equals(
				nonlink.coerce_._TgtX.Normal(a)
				,
				nonlink.coerce_._TgtX.Normal(b)
			);
		}

		public int GetHashCode(Normal obj)
		{
			return nilnul.fs.folder.Eq.Singleton.GetHashCode(obj.en);
			throw new NotImplementedException();
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
