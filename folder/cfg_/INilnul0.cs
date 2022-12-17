using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.cfg_
{
	/// <summary>
	/// nilnul configuration for a folder.
	/// the configuration can be delegated to lower hierarchy.
	/// it's:
	///		*) varied format such as .xml, .json, .ini
	///		1) hierarchy
	/// eg:
	///		a doc named ".nilnul.ini"
	///			,in which [ignored] section would contain a list.
	///		can be delegated to a dir named
	///			._nilnul_
	///				in which a file named ignored.xml would contain a list of ignored divisions.
	///				in which ".ignored.ini" would be dedicated as part of the top doc, and the [ignored] section must be specified there. It can also include other sections, but semantically it's intended for [ignored] only.
	///				don't count on putting this inside .git/ as we may be in a nonrepo folder.
	///			
	/// </summary>
	public interface INilnul0
	{
	}
}
