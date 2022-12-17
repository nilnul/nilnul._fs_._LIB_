using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs
{
	/// <summary>
	/// relative path or absolute path
	/// avoid use Path to avoid conflict with Path.
	/// Note: for a duo of files, there is a path.
	/// 
	/// But path may not apply to a given duo. sometimes, for one file thru a path will we go to nowhere. For example, c:\a\d.txt  +  ..\..\..\..\..\..\b\..\d\
	/// </summary>
	/// <remarks>
	/// alias:
	///		shortcut
	///		trail
	///		way
	///		road
	///		journy
	///		itenerary
	///		path:
	///			nomenclature:
	///				path is "partial"
	/// </remarks>
	///
	public interface IPath { 
	}
	

	[Obsolete(nameof(nilnul.fs.address.co._traject.IShortcut))]
	public interface AnchorI
		:
		address.co._traject.IShortcut
		,
		IPath
	{
	}
}
