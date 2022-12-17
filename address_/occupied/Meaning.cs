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
	static public class _MeaningX
	{
		static public object Meaning(nilnul.fs.address_.Occupied address)
		{
			if (nilnul.fs.address.be_.Spear.Singleton.be(address.ee))
			{
				//means blob.
				if (nilnul.fs.address.be_.Folder.Singleton.be(address.ee))
				{

					return null;
				}


				// a file
				//else
				//{
				return nilnul.fs.file._BlobX.Blob(
					nilnul.fs.address_.SpearA.OfSpear(
						address.ee
					)
				);
				//}


			}

			//address is shield, meaning divisions

			if (nilnul.fs.address.be_.Folder.Singleton.be(address.ee))
			{

				return nilnul.fs.folder._DivisionsX.Divisions_assumeShield(address.ee);
			}

			return null;


		}
		public static object Meaning(AddressI address)
		{
			return Meaning(new Occupied(address));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="address"></param>
		/// <returns>
		/// item1 is null for folder, not null for file
		/// item2 is null for spear, not null for shield
		/// </returns>
		static public (Lazy<byte[]>, IEnumerable<DivisionI>) Bituple(nilnul.fs.address_.Occupied address)
		{
			if (nilnul.fs.address.be_.Spear.Singleton.be(address.ee))
			{
				//means blob.

				if (nilnul.fs.address.be_.Folder.Singleton.be(address.ee))
				{

					return (null,null);
				}


				// a file
				//else
				//{
				return  (
					new(
						()=>
						nilnul.fs.file._BlobX.Blob(
							nilnul.fs.address_.SpearA.OfSpear(
								address.ee
							)
						)
					)
					,
				null);
				//}


			}

			//address is shield, meaning divisions

			if (nilnul.fs.address.be_.Folder.Singleton.be(address.ee))
			{

				return (
					new Lazy<byte[]>(()=> new byte[0])
					,
					nilnul.fs.folder._DivisionsX.Divisions_assumeShield(address.ee)

				);
			}

			return (null, new DivisionI[0] );


		}
		public static (Lazy<byte[]>, IEnumerable<DivisionI>) Bituple(AddressI address)
		{
			return Bituple(new Occupied(address));
		}

	}

}
