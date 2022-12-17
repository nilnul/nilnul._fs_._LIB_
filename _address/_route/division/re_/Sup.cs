using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.re_
{
	/// <summary>
	/// sup, shorter
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public class Sup_trailingDif : _address.division.ReI

	{
		public bool re(DivisionI supShorter, DivisionI child0self)
		{
			switch (supShorter)
			{
				case nilnul.fs._address.DivI supDiv:
					return _route.division.co_.divDivision.be_.Sup_trailingDif.Singleton.be(
						supDiv
						,
						child0self
					);
					break;
				case nilnul.fs._address.DocumentI supDocument:
					return _route.division.co_.denotationDivision.be_.Sup_trailingDif.Singleton.be(
						supDocument
						,
						child0self
					);
					break;

				default:
					return re(
						_address.DivisionA.Normal(supShorter), child0self
					);
					break;
			}


			/////

			//var dnts = division._DenotesX.Seq(supShorter);

			//var dnts1 = division._DenotesX.Seq(child0self);

			//var t = _address.dnts.re_._LedX.Re(
			//	dnts
			//	,
			//	dnts1
			//);

			//if (t)
			//{
			//	if (division.be_.Div.Singleton.be(child0self))
			//	{
			//		return true;
			//	}

			//	return division.be_.Document.Singleton.be(
			//		supShorter
			//	);

			//}
			//return false;


			//throw new NotImplementedException();
		}


		static public Sup_trailingDif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sup_trailingDif>.Instance;
			}
		}

	}
}
