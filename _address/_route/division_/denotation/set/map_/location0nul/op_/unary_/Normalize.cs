using nilnul.fs._address;
using nilnul.fs._address.destination.dict_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_.denotation.set.map_.location0nul.op_.unary_
{
	/// <summary>
	/// when the value of lication is file,
	///		the ext of the key should be the same as file.
	/// </summary>
	static public class _EnsureExtX
	{

		/// <summary>
		/// ensure ext
		/// </summary>
		/// <param name="dict"></param>
		/// <returns></returns>
		static public nilnul.fs._address._route.division_.denotation.set.map_.Location0nul EnsureExt(
			nilnul.fs._address._route.division_.denotation.set.map_.Location0nul dict
		)
		{

			var r = new nilnul.fs._address._route.division_.denotation.set.map_.Location0nul ();

			dict.Select(
				d =>
				{
					switch (d.Value)
					{

						case nilnul.fs.FileI1 file  //key must be document
							when nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.be_.empty.Anto.Singleton.be(
								nilnul.fs._address._route.division_._div._dir.dnt_._exted._ExtX.Ext(file.file.ee.sprig.denotation.dnt)
							)
							:
							var keyDocument = (_address._route.division_.div.DntedI)(d.Key);

							if (
								!nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.Eq.Singleton.Equals(
									nilnul.fs._address._route.division_._div._dir.dnt_._exted._ExtX.Ext(
										((_address._route.division_.div.DntedI)(d.Key)).dnt
									)
									,
									nilnul.fs._address._route.division_._div._dir.dnt_._exted._ExtX.Ext(
										file.file.ee.sprig.denotation.dnt
									)
								)
							)
								return new KeyValuePair<_address._route.division_.div.DntedI, ILocation>(
										new _address._route.division_.div.Dnted(
											keyDocument.div
											,
											_address._route.division_._div._dir.dnt_.exted.op_.unary_._EnsureGivenNonemptyX._MainExt_assumeNe(
												keyDocument.dnt,

												nilnul.fs._address._route.division_._div._dir.dnt_._exted._ExtX.Ext(file.file.ee.sprig.denotation.dnt)
											)
										)
										,
										file
									);
							break;
						default:
							break;
					}
					return d;

				}
			).ForEach(x => r.Add(x.Key, x.Value))
		;
			return r;


		}


	}



}
