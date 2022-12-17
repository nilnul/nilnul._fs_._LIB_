using System.Collections.Generic;

namespace nilnul.fs.address_.shield_.address
{
	public class Eq : IEqualityComparer<nilnul.fs.AddressI>
	{


		public bool Equals(string x, string y)
		{
			return Equals(
				nilnul.fs.AddressA.Parse(x)
				,
				nilnul.fs.AddressA.Parse(y)
			);

		}



		public bool Equals(AddressI x, AddressI y)
		{
			return shield.Eq.Singleton.Equals(_AddressX1.Create(x), _AddressX1.Create(y));
			//throw new NotImplementedException();
		}

		public int GetHashCode(AddressI x)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.GetHashCode(_AddressX1.Create(x));
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
