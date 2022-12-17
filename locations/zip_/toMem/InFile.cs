using System.IO;

namespace nilnul.fs.locations.zip_.toMem
{
	static public class _ToFileX
	{
		//Thanks to https://stackoverflow.com/a/12350106/222748 I got:
		static public void Void(
			nilnul.obj.Dict<
				nilnul.fs._address._dst.denote.str_.seq.Join
				,
				nilnul.fs._location_.BlankI
				,
				nilnul.fs._address._dst.denote.str_.seq.Eq
			> contents
			,
			nilnul.fs.address_.spear_.Creatable file
		)
		{
			var memStream = zip_._ToMemX.MemStream(contents);
			using (var fileStream = new FileStream(file.en.ToString(), FileMode.Create))
			{
				memStream.Seek(0, SeekOrigin.Begin);
				memStream.CopyTo(fileStream);
			}
		}
	}
}
