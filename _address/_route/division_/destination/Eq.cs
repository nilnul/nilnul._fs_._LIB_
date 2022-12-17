using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.destination
{
	[Obsolete()]
	public class Eq : IEqualityComparer<DestinationI>
	{
		public bool Equals(DestinationI x, DestinationI y)
		{

			if (x is _address.DirectoryI directory)
			{
				if (y is _address.DirectoryI directory1)
				{
					return nilnul.fs._address.directory.Eq.Singleton.Equals(
						directory
						,
						directory1
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
			else if (x is _address.DocumentI document)
			{
				if (y is _address.DirectoryI)
				{
					return false;

				}
				else if (y is _address.DocumentI document1)
				{
					return _address.document.Eq.Singleton.Equals(
						document
						,
						document1
					);
				}
				else
				{
					throw new UnexpectedTypeException();
				}

			}
			throw new UnexpectedTypeException();
		}

		public int GetHashCode(DestinationI obj)
		{
			switch (obj)
			{
				case _address.DocumentI document:
					return _address.document.Eq.Singleton.GetHashCode(
					document
				);
				case _address.DirectoryI directory:
					return _address.directory.Eq.Singleton.GetHashCode(directory);

				default:
					throw new UnexpectedTypeException();

					break;
			}
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
