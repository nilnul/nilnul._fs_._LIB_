using System.IO;

namespace nilnul.fs.folder.doc_.unoccupied.create
{
	static public class _WriterX
	{
		static public StreamWriter Writer(nilnul.fs.FolderI folder, nilnul.fs._address.DocI doc)
		{
			return nilnul.fs.address_.spear_.unoccupied._Create4TxtWriteX.TxtWriter(
				 nilnul.fs.folder._DocX.Spear(folder, doc)
			);
		}
		static public StreamWriter Writer(nilnul.fs.Folder folder, nilnul.fs._address.DocI doc)
		{
			return Writer((FolderI)folder, doc);
		}

		static public StreamWriter Writer(DirectoryInfo folder, nilnul.fs._address.DocI doc)
		{
			return Writer(
				new nilnul.fs.Folder(folder)
				,
				doc
			);
		}

		static public StreamWriter Writer(DirectoryInfo folder, _address.Doc doc)
		{
			return Writer(
				(folder)
				,
				(nilnul.fs._address.DocI)(doc)
			);
		}
		static public StreamWriter Writer(DirectoryInfo folder, string doc)
		{
			return Writer(
				(folder)
				,
				new nilnul.fs._address.Doc(doc)
			);
		}


	}
}
