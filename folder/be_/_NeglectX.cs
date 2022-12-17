using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.be_
{
	static public class _NeglectX
	{

		public static bool Be_ofXml(XDocument xdoc)
		{

			var xpath = @"/*/*[local-name()='neglect']";

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
				return false;
			}

			var v = xel1.Value;
			if (v is null)
			{
				return false;
			}
			return v.Trim()=="1";
	

		}

		public static bool Be(FolderI1 obj)
		{
			var spear = new address_.spear_.based_.Child1(obj.address.ee, ".nilnul");
			var spearAsTxt = spear.ToString();
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				try
				{
					return Be_ofXml(
						XDocument.Load(spearAsTxt)
					);

				}
				catch (Exception)
				{

					Trace.TraceError($"{spearAsTxt} is not a valid xml when processed as neglect settings.");
				}
			}
			return false;


		}

		public static bool Be(nilnul.fs.FolderI s)
		{
			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnul");
			var spearAsTxt = spear.ToString();
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				try
				{
					return Be_ofXml(
						XDocument.Load(spearAsTxt)
					);

				}
				catch (Exception)
				{

					Trace.TraceError($"{spearAsTxt} is not a valid xml when processed as neglect settings.");
				}
			}
			return false;



		}
	}

}
