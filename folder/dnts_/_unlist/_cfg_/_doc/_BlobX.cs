using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.dnts_._neglect._cfg_._doc
{

	/// <summary>
	/// unlisted dirs
	/// </summary>
	static public class _BlobX
	{

		public static string[] Captions(XDocument xdoc)
		{
			var xpath = @"/*/*[local-name()='dnts_']/*[local-name()='neglect']";

			var xel = xdoc.XPathSelectElements(
				xpath
			);
			if (xel.Skip(1).Any())
			{
				Trace.TraceError(
					$"multiple {xpath} found; only the last will be effective."
				);

			}
			var xel1 = xel.LastOrDefault();
			if (xel1 is null)
			{
				return new string[0];
			}
			var v = xel1.Value;
			if (v is null)
			{
				return new string[0];
			}
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(v).ToArray();

		}

		public static string[] _Captions_blobOfNulable(string blob0nul)
		{
			if (blob0nul is null)
			{
				return new string[0];
			}

			var xdoc = XDocument.Load(
				 new StringReader(blob0nul)
			);

			return Captions(xdoc);



		}

	

	}


}
