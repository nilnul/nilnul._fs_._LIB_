using System.Collections.Generic;

namespace nilnul.fs._address.division
{
	public class Eq : IEqualityComparer<DivisionI>
	{
		public bool Equals(DivisionI x, DivisionI y)
		{
			if (x is _address.DivI)
			{
				if (y is _address.DivI)
				{
					return nilnul.fs._address.div.Eq.Singleton.Equals(
						(_address.DivI)x
						,
						(_address.DivI)y
					);
				}
				else if (y is _address.DocumentI)
				{
					return false;
				}
				else
				{
					throw new UnexpectedTypeException();
				}

			}
			else if (x is _address.DocumentI)
			{
				if (y is _address.DivI)
				{
					return false;

				}
				else if (y is _address.DocumentI)
				{
					return document.Eq.Singleton.Equals(
						(_address.DocumentI)x
						,
						(_address.DocumentI)y
					);
				}
				else
				{
					throw new UnexpectedTypeException();
				}

			}
			throw new UnexpectedTypeException();
			//throw new NotImplementedException();
		}

		public int GetHashCode(DivisionI obj)
		{
			switch (obj)
			{
				case _address.DocumentI document:
					return _address.document.Eq.Singleton.GetHashCode(
					(Document)obj
				);
				case _address.DivI div:
					return _address.div.Eq.Singleton.GetHashCode((_address.DivI)obj);

				default:
					throw new UnexpectedTypeException();

#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}


		}

		//throw new NotImplementedException();


#pragma warning disable CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
		public static Eq Singleton => nilnul.obj.SingletonByDefault<Eq>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Eq>' is obsolete: 'Singleton'
	}

}
