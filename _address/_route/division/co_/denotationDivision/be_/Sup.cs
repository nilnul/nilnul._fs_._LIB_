using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division.co_.denotationDivision.be_
{
	/// <summary>
	/// sup, shorter
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public class Sup_trailingDif 
	{
		public bool be(_address.DocumentI supShorter, _address.DivisionI child0self)
		{
			switch (child0self)
			{
				case nilnul.fs._address.DivI subLonger :
					return nilnul.fs._address._route.division.co_.denotationDiv.be_.Sup_trailingDif.Singleton.be(supShorter,subLonger);

					break;
				case nilnul.fs._address.DocumentI subLongerDocument :

					return nilnul.fs._address._route.division_.denotation.re_.Sup.Singleton.re(supShorter,subLongerDocument);

					break;
				default:
					return be(
						supShorter, _address.DivisionA.Normal(child0self)
					);

					break;
			}
		}
		static public Sup_trailingDif Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sup_trailingDif>.Instance;
			}
		}
	}
}