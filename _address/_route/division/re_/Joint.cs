using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division.re_
{
	public class Joint : _address.division.ReI
		,
		division.ReI
		
		
	{
		public bool re(_address.DivisionI a, _address.DivisionI b)
		{
			var dnts = _address.division._DenotesX.Seq(a);

			var dnts1 = _address.division._DenotesX.Seq(b);

			var numerator = dnts.GetEnumerator();
			var numerator1 = dnts1.GetEnumerator();

			while (numerator.MoveNext())
			{
				if (numerator1.MoveNext())
				{
					if (
						!nilnul.fs._address._dst.denote.Eq.Singleton.Equals(
							numerator.Current,numerator1.Current
						)
					)
					{ 
						return false;
					}
				}
				else
				{
					return true;
				}
			}

			//if (numerator1.MoveNext())
			//{
			//	return true;

			//}

			return true
				;
			//throw new NotImplementedException();
		}

		public bool re(DivisionI a, DivisionI b)
		{
			var dnts = _address._route.division._DntsX.Seq(a);

			var dnts1 = _address._route.division._DntsX.Seq(b);

			var numerator = dnts.GetEnumerator();
			var numerator1 = dnts1.GetEnumerator();

			while (numerator.MoveNext())
			{
				if (numerator1.MoveNext())
				{
					if (
						!nilnul.fs._address._route.division_._div._dir.dnt.Eq.Singleton.Equals(
							numerator.Current, numerator1.Current
						)
					)
					{
						return false;
					}
				}
				else
				{
					return true;
				}
			}
			return true;
			//throw new NotImplementedException();
		}

		static public Joint Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint>.Instance;
			}
		}

	}
}
