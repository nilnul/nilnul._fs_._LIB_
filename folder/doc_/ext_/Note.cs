using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.ext_
{
	/// <summary>
	/// sometimes we may want to denote something about the container, which is a folder; we simply put the note at the main name of the fille, no need to be in the content of the file (though we could). By so doing, we don't need to open the file.
	/// We append an ext, ".note", to distinguish such files from others.
	/// eg:
	///		this contains medias, no text.note
	/// </summary>
	interface INote
	{
	}
}
