using System.Collections.Generic;

namespace nilnul.fs._address._route.division_.destination.eq_
{
	/// <summary>
	/// is deemed the same if they all have the same str of denote
	/// </summary>
	public class AsDnts : IEqualityComparer<_address._route.division_. DestinationI>
	{
		
			public bool Equals(_route.division_.DestinationI x, _route.division_.DestinationI y)
			{


				return _address._route.division_.div_. directory.Eq.Singleton.Equals(
				_address._route.division_.div_.Directory.Of(x)
				, _address._route.division_.div_.Directory.Of(y)
			);
			//return div.Eq.Singleton.Equals(
			//	div_._DivisionX.Fro(x)
			//	,div_._DivisionX.Fro(y)
			//);

		}


		

		public int GetHashCode(_address._route.division_.DestinationI obj)
		{
			return _address._route.division_.div_.directory.Eq.Singleton.GetHashCode(_address._route.division_.div_. Directory.Of(obj));
			//return div.Eq.Singleton.GetHashCode(div_._DivisionX.Fro(obj));
		}


		static public AsDnts Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<AsDnts>.Instance;
			}
		}
		static public AsDnts Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<AsDnts>.Instance;
			}
		}




	}
}