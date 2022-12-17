using System.Linq;

namespace nilnul.fs.folder.docs_.normal
{
	static public class _DelDuplicateX
	{
		static public void DelDuplicate_ofFolderAddress(
			string folder
		)
		{
			//var folder = @"E:\170203\data\wyt._research_\(rt\fund_\prc_\nsf_\yr18\(GIT\_apply_\participant_";
			///delete repeated blobs
			///

			var docs = nilnul.fs.folder.docs_._NormalX.AsFileInfoS_ofAddress(folder);


			//partition the folder

			var partiton = nilnul.set.partite_._InnerEqDefaultX.Partite(
				docs.Select(x => new nilnul.fs.File(x))
				,
				nilnul.fs.file.eq_.Binary.Singleton
			);


			foreach (var part in partiton)
			{

				var ordered = part.OrderByDescending(
					x =>
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTime
				);

				var head = ordered.First();
				var headContainerDoc = new nilnul.fs.address_.spear_.ParentDoc(head.file.en);



				ordered.Skip(1).ForEach(
					y =>
					{
						var verOfFolder = nilnul.fs.folder.denote_.Vered.OvAddress(
							headContainerDoc.parent.ToString()
						);

						var currentContainerDoc = new nilnul.fs.address_.spear_.ParentDoc(y.file.en);

						var linkName = verOfFolder.getNextDst(currentContainerDoc.doc.ToString() + "_", "lnk");

						var linkNameParsed = nilnul.fs._address.doc_.exted_.Dotted.Parse(linkName);

						nilnul.fs.file_._shortcut.create_._InSameFolderX.Create(
							headContainerDoc.parent
							,
							linkNameParsed.main.ToString()
							,
							headContainerDoc.doc

						);

						nilnul.fs.file.del_._RecyclableX.Del(y);
					}
				);
			}

		}
	}
}
