﻿using System;

namespace nilnul.fs._address
{
	/// <summary>
	/// in each folder, there are multple children, each of which is called Dst (destination). A dest is either a dir (part of folder), or a doc (part of file). 
	/// </summary>
	///
	[Obsolete()]
	public interface IDst {

	}
	[Obsolete()]
	public interface DstI1 : _dst_.CaptionI,DestinationI, IDst
	{

	}
}
