using System;

namespace nilnul.fs._address
{
	[Obsolete()]
	public interface IDir:IDst, IDirectory

	{

	}
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	[Obsolete()]
	public interface DirI : DstI,DestinationI, IDir
		
		//,DivI

	{

	}
}
