using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_.cfg_
{
	/// <summary>
	/// .nilnul/
	/// inside this, there can be multiple files,such as
	///		bak
	///			configuration for nilnul.bak
	///		abc.xml
	///			configuration for nilnul.abc, in the xml format.
	///	there can also be subdirs.
	///		def/
	///			next levels configuration for nilnul.def
	///		foo/bar/
	///			the configiration subsection for nilnul.foo.bar
	///		yaml
	///			similar to ini, but where indentation carries meaning.
	/// </summary>
	/// <remarks>
	/// we cannot put this into a ".git/" dir, as we might delete the bakked git module, and keep some records in our settings; thus we need to create a dedicated dir.
	/// </remarks>
	class IForNilnul
	{
	}
}
