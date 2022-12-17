using System.Collections.Generic;

namespace nilnul.fs._address.division.eq_
{
	/// <summary>
	/// is deemed the same if they all have the same str of denote
	/// </summary>
	public class Location : IEqualityComparer<DivisionI>
	{
		public bool Equals(DivisionI x, DivisionI y)
		{
			return div.Eq.Singleton.Equals(
				div_._DivisionX.Fro(x)
				,div_._DivisionX.Fro(y)
			);
		}

		public int GetHashCode(DivisionI obj)
		{
			return div.Eq.Singleton.GetHashCode(div_._DivisionX.Fro(obj));
		}

		static public Location Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Location>.Instance;
			}
		}
	}
}