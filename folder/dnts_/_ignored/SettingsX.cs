using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dnts_._ignored
{
	static public class SettingsX
	{
		/// <summary>
		/// ".ignored", not ".ignore" (note the ending "d") is in that "d" means denote, and to better differentiate from ".gitignore" to avoid human confusion.
		/// </summary>
		public static string DefaultIgnoreDoc
		{
			get
			{
				return (string)(_ignored.Settings1.Default.Properties[nameof(_ignored.Settings1.ignoreDoc)].DefaultValue);
			}
		}
		public static fs._address.Doc Doc
		{
			get
			{
				fs._address.Doc doc;
				try
				{
					doc = new fs._address.Doc(_ignored.Settings1.Default.ignoreDoc);
				}
				catch (Exception)
				{


				}

				return new fs._address.Doc(DefaultIgnoreDoc);

			}
		}
		public static fs._address._route.division_._div._dir.Dnt  Dnt
		{
			get
			{
				fs._address._route.division_._div._dir.Dnt doc;
				try
				{
					doc = new fs._address._route.division_._div._dir.Dnt(_ignored.Settings1.Default.ignoreDoc);
				}
				catch (Exception)
				{


				}

				return new fs._address._route.division_._div._dir.Dnt(DefaultIgnoreDoc);

			}
		}


	}
}
