using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.ntfs_.flow_
{

	/************
	 * 
	 github.com/microsoft/WSL/issues/4609


	if you move files from ntfs to WSL, zoneFlow is copied.
	 Contents of the Zone Identifier file are as to be expected, my sample having the contents:

[ZoneTransfer]
ZoneId=3
ReferrerUrl=https://i.imgur.com/7uEP6ds.png
HostUrl=https://i.imgur.com/7uEP6ds.png
	 
	 */
	/// <summary>
	/// if you use :
	///		dir /r
	///	in the downloaded folder,
	///	you will see:
	///	详情请查看PDF.mp4
	///	详情请查看PDF.mp4:Zone.Identifier:$DATA
	///
	/// that is for each file, there is another flow file ending with :
	///		:Zone.Identifier:$DATA
	///
	///
	/// 
	/// </summary>
	class Unsafe
	{

	}
}
