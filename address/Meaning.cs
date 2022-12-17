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
	static public class _MeaningX
	{
		static public Tuple<Lazy<byte[]>, IEnumerable<DivisionI>> MeaningLazy(nilnul.fs.AddressI address)
		{
			if (nilnul.fs.address.be_.Occupied.Singleton.be(address))
			{
				var m = nilnul.fs.address_.occupied._MeaningX.Bituple(
						address
					);
				return new Tuple<Lazy<byte[]>, IEnumerable<DivisionI>>(
					m.Item1
					,
					m.Item2
				);
			}
			return null;


		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="address"></param>
		/// <returns>
		///		
		///	 (null, null)
		///		spear occupied by a folder
		///		
		///	 (blob, null)
		///		spear occupied by a file
		///		
		///	 (null, divisions)
		///		shield occupied by a folder
		///		
		///	 (blob, divisions empty)
		///		shield occupied by a file
		///
		/// 
		///	in other words
		///		item2
		///			is divisions:
		///				a shield
		///					empty divisions if occupied by file
		///			is null
		///				a spear
		///			
		///		item1
		///			is null:
		///				occupied by folder
		///			blob
		///				occupied by file
		///			
		/// </returns>
		static public Tuple<byte[], IEnumerable<DivisionI>> Meaning(nilnul.fs.AddressI address)
		{

			if (nilnul.fs.address.be_.Occupied.Singleton.be(address))
			{
				var meant = nilnul.fs.address_.occupied._MeaningX.Meaning(
					address
				);

				if (nilnul.fs.address.be_.Shield.Singleton.be(address) )
				{
					/// if a file: (bytes, empty)
					///		meant is null
					/// if a folder (null, maybe empty)
					///		meant is divisions
					///
					if (meant is null)
					{
						return new(
							nilnul.fs.file._BlobX.Blob(
								new nilnul.fs.File(
									nilnul.fs.address_.SpearA.OfSpear(
										nilnul.fs.address.op_.unary_.Shrink.Op(address)
									)
								)
							),
							new DivisionI[0]
						);
					}


					return new (null, (IEnumerable<DivisionI>)meant);

				}
				/// if a file, (bytes, null)
				///		meant is bytes
				/// if a folder (null, null)
				///		meant is null
				return new ((byte[]) meant, null) ;
			}

			///virtual file for spear, virtual fodler for shield
			///

			return null;
		}

	}

}
