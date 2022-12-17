using System;
using System.Collections.Generic;

namespace nilnul.fs._address.destination.eq_
{
	/// <summary>
	/// is deemed the same if they all have the same str of denote
	/// </summary>
	///
	[Obsolete()]
	public class Location1 : IEqualityComparer<_address.DestinationI>
	{
		public bool Equals(_address.DestinationI x, _address.DestinationI y)
		{

			return directory.Eq.Singleton.Equals(
				Directory.Ov(x)
				,Directory.Ov(y)
			);
			//return div.Eq.Singleton.Equals(
			//	div_._DivisionX.Fro(x)
			//	,div_._DivisionX.Fro(y)
			//);


		}

		public int GetHashCode(DestinationI obj)
		{
			return directory.Eq.Singleton.GetHashCode(Directory.Ov(obj));
			//return div.Eq.Singleton.GetHashCode(div_._DivisionX.Fro(obj));
		}

		static public Location1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Location1>.Instance;
			}
		}
	}
}