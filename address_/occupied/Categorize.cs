using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// see location
/// </summary>
namespace nilnul.fs.address_.occupied
{
	/// <summary>
	/// spear means blob. shield means divisions
	/// </summary>
	static public class _CategorizeX
	{
		static public object _Obj_assumeOccupied(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.SpearI spear:
					if (nilnul.fs.address_.spear.be_.Folder.Singleton.be(spear))
					{

						return new nilnul.fs.address_.spear.be_.folder.vow.Ee(spear);
					}
					return new nilnul.fs.address_.spear.be_.file.vow.Ee(spear);

				case nilnul.fs.address_.ShieldI shield:
					if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(shield))
					{

						return new nilnul.fs.address_.shield.be_.folder.vow.Ee(shield);
					}
					return new nilnul.fs.address_.shield.be_.file.vow.Ee(shield);

				default:
					throw new UnexpectedTypeException();

					break;
			}
		}
		static public address._categorize.Category _Category_assumeOccupied(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.SpearI spear:
					if (nilnul.fs.address_.spear.be_.Folder.Singleton.be(spear))
					{

						return fs.address._categorize.Category.SpearOccupiedByFolder;
					}
					return fs.address._categorize.Category.SpearOccupiedByFile;

				case nilnul.fs.address_.ShieldI shield:
					if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(shield))
					{

						return fs.address._categorize.Category.ShieldOccupiedByFolder;
					}
					return fs.address._categorize.Category.ShieldOccupiedByFile;

				default:
					throw new UnexpectedTypeException();

					break;
			}
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="address"></param>
		/// <returns>
		/// item1 is null for folder, not null for file
		/// item2 is null for spear, not null for shield
		/// </returns>
		static public object Obj(nilnul.fs.address_.Occupied address)
		{
			
			return _CategorizeX._Obj_assumeOccupied(address.ee);


		}
		public static object Obj(AddressI address)
		{
			return Obj(new Occupied(address));
		}

	}

}
