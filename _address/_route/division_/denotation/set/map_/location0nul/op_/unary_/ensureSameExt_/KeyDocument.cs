using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.empty.destinations._link
{
	/// <summary>
	/// when the value of location is file,
	///		the ext of the key should be the same as file.
	/// </summary>
	///
	[Obsolete()]
	static public class _KeyIsDocumentX
		//:IPac
	{
		static public nilnul.fs._address.document.Dict<nilnul.fs.ILocation> EnsureDweltExt(nilnul.fs._address.document.Dict<nilnul.fs.ILocation> dict)
		{

			var r = new nilnul.fs._address.document.Dict<nilnul.fs.ILocation>();

			dict.Select(
				d =>
				{
					switch (d.Value)
					{
						case nilnul.fs.FileI file
							when _address.doc_._exted.ext.be_.empty.Anto.Singleton.be(
								_address.doc_.exted._ExtX.Ext(file.file.en.sprig.document.doc)
							)
							 &&
							!nilnul.fs._address.doc_._exted.ext.Eq.Singleton.Equals(
								_address.doc_.exted._ExtX.Ext(d.Key.doc)
								,
								_address.doc_.exted._ExtX.Ext(file.file.en.sprig.document.doc)
							):
							return new KeyValuePair<_address.DocumentI, ILocation>(
									new _address.Document(
										d.Key.div
										,
										_address.doc_.exted.op_.unary_._EnsureGivenNonemptyX._MainExt_assumeNe(
											d.Key.doc,

											_address.doc_.exted._ExtX.Ext(file.file.en.sprig.document.doc)
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
