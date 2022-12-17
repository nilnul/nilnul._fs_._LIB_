using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using F = nilnul.fs.FileI;

namespace nilnul.fs.file
{
	/// <summary>
	/// the blob of the file
	/// </summary>
	static public class _BlobX 
	{
		static public  byte[]  Blob(string file)
		{
			return System.IO.File.ReadAllBytes(file);
		}

		public static byte[] Blob(F file)
		{
			return System.IO.File.ReadAllBytes(file.file.en.ToString());

		}

		public static byte[] Blob(SpearI spearI)
		{
			return Blob(spearI.ToString());
		}
	}
}
