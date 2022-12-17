using nilnul.fs._address;
using nilnul.fs._address.destination.dict_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.empty.destinations._link
{
	/// <summary>
	/// when the value of lication is file,
	///		the ext of the key should be the same as file.
	/// </summary>
	///
	[Obsolete()]
	static public class _KeyIsDestionationX
	{

		static public nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation> Key2DirectoryIfNeed(nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation> dict)
		{

			var r = new nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation>();

			dict.Select(
				d =>
				{
					switch (d.Value)
					{
						case null:
							return new KeyValuePair<_address.DestinationI, ILocation>(
															 _address.Directory.Ov(
																d.Key
															)
															,
															null
														);
							break;
						case nilnul.fs.FolderI file
							:
							return new KeyValuePair<_address.DestinationI, ILocation>(
									 _address.Directory.Ov(
										d.Key
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

		static public void KeyVowDocumentIfValIsFile(nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation> dict)
		{



			dict.ForEach(
				d =>
				{
					switch (d.Value)
					{
						case nilnul.fs.FileI file
							:
							nilnul.obj_.bit.vow_._TrueX.Vow(
								d.Key is _address.DocumentI
								,
								"when value is file, the key cannot be directory"
							);

							break;

					}

				}
			)
		;


		}

		/// <summary>
		/// ensure ext
		/// </summary>
		/// <param name="dict"></param>
		/// <returns></returns>
		static public nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation> EnsureDweltExt_assumeKeyFormated(nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation> dict)
		{

			var r = new nilnul.fs._address.destination.dict_.AsDenote<nilnul.fs.ILocation>();

			dict.Select(
				d =>
				{
					switch (d.Value)
					{

						case nilnul.fs.FileI file  //key must be document
							when _address.doc_._exted.ext.be_.empty.Anto.Singleton.be(
								_address.doc_.exted._ExtX.Ext(file.file.en.sprig.document.doc)
							)
							:
							var keyDocument = (_address.DocumentI)(d.Key);

							if (
								!nilnul.fs._address.doc_._exted.ext.Eq.Singleton.Equals(
									_address.doc_.exted._ExtX.Ext(((_address.DocumentI)(d.Key)).doc)
									,
									_address.doc_.exted._ExtX.Ext(file.file.en.sprig.document.doc)
								)
							)
								return new KeyValuePair<_address.DestinationI, ILocation>(
										new _address.Document(
											keyDocument.div
											,
											_address.doc_.exted.op_.unary_._EnsureGivenNonemptyX._MainExt_assumeNe(
												keyDocument.doc,

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
