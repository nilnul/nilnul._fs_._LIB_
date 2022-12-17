using System.Collections.Generic;

namespace nilnul.fs._address.vol
{
	public class Eq : IEqualityComparer<Vol>, IEqualityComparer<VolI>
	{
		public bool Equals(Vol x, Vol y)
		{
#pragma warning disable CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
#pragma warning disable CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
			return nilnul.character.eq_.CaseInsensitive.Singleton.Equals(x.letter, y.letter);
#pragma warning restore CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
#pragma warning restore CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
			//throw new NotImplementedException();
		}
		public bool Equals(VolI x, VolI y)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
				x.ToString()
				,
				y.ToString()
			);
			//throw new NotImplementedException();
		}


		public int GetHashCode(Vol obj)
		{

#pragma warning disable CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
			return nilnul.character.eq_.CaseInsensitive.Singleton.GetHashCode(obj.letter);
#pragma warning restore CS0618 // 'Vol.letter' is obsolete: 'for a server there might be more than 26 drives and we have to name it as AA'
			//throw new NotImplementedException();
		}

		public int GetHashCode(VolI obj)
		{
			return nilnul.txt.eq_.CaseInsensitive.Singleton.GetHashCode(
				obj.ToString()
			);
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Eq>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
			}
		}


	}
}
