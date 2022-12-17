using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs.address.co_.addressShield_.sup
{

	static public class _RelPathX
	{

		/// <summary>
		/// assume address is containing the shield
		/// </summary>
		/// <param name="_base"></param>
		/// <param name="_document"></param>
		/// <returns></returns>
		static public Div Div(
			nilnul.fs.AddressI _base
			,
			nilnul.fs.address_.ShieldI _document
			)
		{


			return _base switch{
				fs.address_.ShieldI shield => address_.shield.co_.sup._DifX._ofSupSub(shield,_document)
				,
				fs.address_.SpearI spear => co_.spearShield_.containing._DifX.Div(
					spear,_document
				)
					
			};
		}

		
	}
}
