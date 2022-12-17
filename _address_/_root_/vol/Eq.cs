using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._root_.vol
{
	public class Eq : IEqualityComparer<Vol>
	{
		public bool Equals(Vol x, Vol y)
		{
			return nilnul.character.eq_.CaseInsensitive.Singleton.Equals(x.letter,y.letter);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Vol obj)
		{

			return nilnul.character.eq_.CaseInsensitive.Singleton.GetHashCode(obj.letter);
			//throw new NotImplementedException();
		}

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
