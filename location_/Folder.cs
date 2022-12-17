using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nilnul.fs.location_
{
	[Obsolete()]
	public  class Folder: _folder.address.be_.Exist.En
	{
		public Folder(address_.Folder val) : base(val)
		{

		}

		public Folder(string s):this( address_.Folder.Parse(s))
		{

		}

		public DirectoryInfo toDirectoryInfo() {
			return new DirectoryInfo(this.ToString());
		}

		public override string ToString()
		{
			return this.avowed.ToString();
		}

		static public Folder ParseNullable(string addressTxt) {
			try
			{
				return Parse(addressTxt);

			}
			catch (FormatException formatException) {
				return null;
			}
			catch (Exception)
			{
				return null;
			}
		}

		static public Folder Parse(string s) {

			return new Folder(
				nilnul.fs.address_.Folder.Parse(s)	
			);
		}
		public static string AppendSeperator(string location) {
			return location + System.IO.Path.DirectorySeparatorChar;
		}

		public static bool _Eq_caseInsensitive(
			string _locationOfFolder
			,
			string _locationOfFolder1	
		) {
			return 	nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
				_locationOfFolder

				,
				_locationOfFolder1

			);

		}

	}
}
