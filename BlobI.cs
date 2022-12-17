using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs
{
	/// <summary>
	/// a str of bits. Often the bits is chunk by chunk, and the min block is byte.
	///  It's in fact the stored form of data.
	///  Blob is the content of file; and often contains meta data.
	/// </summary>
	interface IBlob
	{
	}
}
