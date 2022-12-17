using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_.vered_
{
	/// <summary>
	/// when there is only version, not nom, the dir denotes a subfolder to contain some misc items, such that parent folder's size does not go up too large.
	/// items that are significant and need to be explicitly noticed shall go into a named sub-directory rather than unnamed 
	/// eg:
	///		21
	///			built in year 21. This is build in year 21. but may contain past or future items such as those from yr20 or yr24. In this folder named "21", you can further create dir named 24 to denote this folder is for yr24; or you can further create dir named m8 to denote this folder is for month 8 of the contectual year (which is 21)
	///			
	/// </summary>
	class Unnamed
	{
	}
}
