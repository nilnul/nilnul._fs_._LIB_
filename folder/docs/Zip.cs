using System.IO.Compression;

namespace nilnul.fs.folder.docs
{
	public class _ZipX
	{


		static public string Zip(nilnul.fs.Folder folder, string fileName)
		{

			var targetAddress = nilnul.fs.folder_._TmpX.Get();


			var zipAddress = nilnul.fs.folder.denote_.MainVered.OvAddress(System.IO.Path.GetTempPath()).nextAddress(fileName, ".zip");


			ZipFile.CreateFromDirectory(folder.ToString(), zipAddress);

			return zipAddress;


		}

		static public string Zip(string folder, string fileName)
		{
			return Zip(nilnul.fs.Folder.FroAddress(folder), fileName);
		}


		static public string Zip(nilnul.fs.Folder folder)
		{

			return Zip(
				folder
				,
				nilnul.fs.folder._LocalNameX.LocalName(folder)
			//folder.address.toFileLike().path.tip.ToString()
			);


		}





	}
}
