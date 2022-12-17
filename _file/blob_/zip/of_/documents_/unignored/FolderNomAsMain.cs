using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.blob_.zip.of_.documents_.unignored
{
	static public class _FolderNomAsMain0docX
	{
		static public fs._address.doc_.exted_.Dotted DocAsDotted(nilnul.fs.address_.ShieldI shield) {
	string name;

			var div = shield.stem.div;

			if (div.dirs.Any())
			{
				 name = div.dirs.Last().denote.en;
			}
			else
			{
				name = "";
			}
			return nilnul.fs._address.dnt_.exted_.dotted._EnsureExtX._Doc_ofMain0doc_ofExtWithLeadingDotOptional(
							name,
							".zip"
						);

		}

		public static nilnul.fs._address.doc_.exted_.Dotted DocAsExted(
			 nilnul.fs.FolderI folder
			,
			nilnul.fs.address_.shield_.Ensurable zipFileContainer
		)
		{

			var doc = DocAsDotted(folder.address.en);
			
			_UnignoredX.Vod(folder
				,
				new fs.address_.spear_.newable_.ext_.Zip(
					new nilnul.fs.address_.spear_.ParentDoc(
						zipFileContainer
						,
						doc
					)
				)
			);
			return doc;
		}

		public static nilnul.fs._address.doc_.exted_.Dotted DocAsExted(
			 nilnul.fs.FolderI folder
			,
			nilnul.fs.FolderI zipFileContainer
		)
		{

			var doc = DocAsDotted(folder.address.en);
			
			_UnignoredX.Vod_tgtAssumeContainerExist(folder
				,
				new fs.address_.spear_.newable_.ext_.Zip(
					new nilnul.fs.address_.spear_.ParentDoc(
						zipFileContainer.address.en
						,
						doc
					)
				)
			);
			return doc;
		}




	}
}
