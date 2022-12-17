using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// see location
/// </summary>
namespace nilnul.fs.address
{
	static public class _CategorizeX
	{
		static public object Obj(nilnul.fs.AddressI address)
		{
			if (nilnul.fs.address.be_.Occupied.Singleton.be(address))
			{

				return nilnul.fs.address_.occupied._CategorizeX._Obj_assumeOccupied(
					address
				);
			}
			return new nilnul.fs.address.be_.unoccupied.vow.Ee(address);


		}
		static public _categorize.Category Category(nilnul.fs.AddressI address)
		{
			if (nilnul.fs.address.be_.occupied.Anto.Singleton.be(address))
			{

				return _categorize.Category.Unoccupied;
			}

			return nilnul.fs.address_.occupied._CategorizeX._Category_assumeOccupied(
				address
			);



		}

	}

}
