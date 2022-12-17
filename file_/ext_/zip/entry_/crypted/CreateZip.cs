using Ionic.Zip;
using System;

namespace nilnul.fs.file_.zip.entry_.crypted
{
	static public class _CreateZipX
	{
		static public string ZipFile(
			string file2zip
			,
			string password
		)
		{
	

			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(file2zip);
			var main = nilnul.fs._address.doc_.exted._MainX.Main(parentDoc.doc);

	

			var tgtParent = new nilnul.fs.folder.dir_.Vered(
				parentDoc.parent
				
			).shield_ensureDir_ofNom(main.ToString());


			var tgt = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(
				tgtParent
			).address("crypted",".zip");


			using (ZipFile zip = new ZipFile())
			{

				zip.Password = password;
				zip.AddFile(
					file2zip
					,"" //direct in the root folder
				);

				//zip.AddDirectory(@"C:\Test\Report_CCLF5\");
				zip.Save(tgt);
			}

			return tgt;

			//nilnul.fs.file.explore_._SelX.Vod(tgt);
			



		}
	}
}
