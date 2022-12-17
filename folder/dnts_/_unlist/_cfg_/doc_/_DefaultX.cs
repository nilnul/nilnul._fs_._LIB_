using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.dnts_._neglect._cfg_.doc_
{

	static public class _DefaultX
	{

	

		public static string[] Captions(nilnul.fs.FolderI s)
		{
			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnul");
			var spearAsTxt = spear.ToString();
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				try
				{
					return _doc._BlobX.Captions(
						XDocument.Load(spearAsTxt)
					);

				}
				catch (Exception)
				{

					Trace.TraceError($"{spearAsTxt} is not a valid xml when processed as neglect settings.");
				}
			}
			return new string[0];



		}

		public static string[] Captions(nilnul.fs.address_.ShieldI s)
		{
			return Captions(new nilnul.fs.Folder(s));
		}


		public static string[] Captions_ofAddress(string s)
		{
			return Captions(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}

	}


}
