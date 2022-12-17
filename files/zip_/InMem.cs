using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.files.zip_
{
	static public class _InMemX
	{
		//Thanks to https://stackoverflow.com/a/12350106/222748 I got:
		static public void InMem() {
			using (var memoryStream = new MemoryStream())
			{
				using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
				{
					var demoFile = archive.CreateEntry("foo.txt");

					using (var entryStream = demoFile.Open())
					using (var streamWriter = new StreamWriter(entryStream))
					{
						streamWriter.Write("Bar!");
					}
				}

				using (var fileStream = new FileStream(@"C:\Temp\test.zip", FileMode.Create))
				{
					memoryStream.Seek(0, SeekOrigin.Begin);
					memoryStream.CopyTo(fileStream);
				}
			}
		}//So we need to call dispose on ZipArchive before we can use it, which means passing 'true' as the third parameter to the ZipArchive so we can still access the stream after disposing it.





	}
}
