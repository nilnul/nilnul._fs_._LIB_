using System.Linq;

namespace nilnul.fs.folder.documents
{

	/// <summary>
	/// for visual studio projects, compiler may generate identity files in the output build folder. In that case, this might unintendedly keep files in the interim ouput folder, while deleting files in the src folder.
	/// To avoid this problem,
	///		use <see cref="nameof(nilnul.fs.folder.docs._DeDupX)"/>
	///		or
	///		log every suspicous case of such kind.
	/// </summary>
	static public class _DelDuplicateX
	{
		static public void DelDuplicate_ofFolderAddress(
			string folder
		)
		{

			var shield = nilnul.fs.address_.shield_._AddressX1.Create(folder);
			var documents = nilnul.fs.folder._DocumentsX.Infos_ofAddress(folder);


			//partition the folder

			var partiton = nilnul.set.partite_._InnerEqDefaultX.Partite(
				documents.Select(x => new nilnul.fs.File(x))
				,
				nilnul.fs.file.eq_.Binary.Singleton
			);


			foreach (var part in partiton)
			{

				var ordered = part.OrderByDescending(
					x =>
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTime
				);

				var kept = ordered.First();

				var kept_ShieldDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(kept.file.en.ToString());

				var targetDocument1 = nilnul.fs.address_.shieldSpear_.sup._DifX._ofSupSub(
					shield
					,
					kept_ShieldDoc
				);

				ordered.Skip(1).ForEach(
					y =>
					{
						//var verOfFolder =  nilnul.fs.folder.denote_.MainVered.OvAddress(
						//	kept_ShieldDoc.shield.ToString()
						//);

						//var currentContainerDoc = nilnul.fs.address_.spear_.ShieldDoc1.Parse(y.file.en.ToString());

						//var toBeDelDocument = nilnul.fs.address_.shieldSpear_.sup._DifX._ofSupSub(

						//	shield
						//	,
						//	currentContainerDoc
						//);

						//var relPath = nilnul.fs._address.document.duo.RelPathX.RelPath(
						//	toBeDelDocument
						//	,
						//	targetDocument1
						//);

						//var linkName = verOfFolder.next(currentContainerDoc.doc);

						//var linkNameParsed = nilnul.fs._address.doc_.Dotted.Parse(linkName);

						nilnul.fs.file.del_._RecyclableX.Del(y);

						nilnul.fs.file_.link_._SymX.Create(
							y.file.en
								,
							kept


						);

					}
				);
			}

		}


	}
}
