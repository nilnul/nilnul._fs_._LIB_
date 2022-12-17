using nilnul.fs.address_;

namespace nilnul.fs.folder.documents.copy_.link_.hard_.intoDisjoint_
{
	static public class _NotedX
	{
		public static void _Void_assumeTgtDisjoint(
			nilnul.fs.FolderI src
			,
			nilnul.fs.FolderI target

		)
		{
			nilnul.fs.folder._DocumentsX.Documents(src).ForEach(
				document =>
				{
					var doc = _address.doc_.MainExt.Ov( document.doc );

					nilnul.fs.file_.link_.hard._CreateX.Void(

						new nilnul.fs.address_.spear_.ParentDocument(
							target.address.en
							,

							new _address.Document(

								document.div
								,
								new _address.doc_.MainExt(
									nilnul.fs.file.copy_.link_.hard_.newMain._NotedX.__CreateNewMain(
										doc.main
									)
									,

									doc.ext
								)
							)

						)
						,
						new nilnul.fs.address_.spear_.ParentDocument(
							src.address.en
							,
							
							document

						)
					); 

				}
			);
		}

		public static void _Void_assumeTgtDisjoint(
			ShieldI src,
			Folder tgt
		)
		{
			_Void_assumeTgtDisjoint(
				new nilnul.fs.Folder(src)
				,
				(FolderI)tgt
			);


		}


		public static void _Void_targetAddress_assumeDisjoint(
			nilnul.fs.address_.ShieldI src
			,
			string tgt
		)
		{
			_Void_assumeTgtDisjoint(
				(src)
				,
				nilnul.fs.Folder.FroAddress(tgt)
			);
		}

		public static void _Void_ofAddresses_assumeDisjoint(
			string src
			,
			string tgt
		)
		{
			_Void_targetAddress_assumeDisjoint(
				nilnul.fs.address_.shield_._AddressX1.Create(src)
				,
				(tgt)
			);
		}
	}
}
