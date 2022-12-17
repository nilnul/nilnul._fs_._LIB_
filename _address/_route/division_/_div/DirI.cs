using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	[Obsolete()]
	public interface DirI:DstI

	{
		DstI dst { get; }
		
	}
}
