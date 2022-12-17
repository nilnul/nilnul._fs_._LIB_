using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_
{
	public class File:nilnul.fs._file.address.be_.Exist.En
	{
		public File(address_.File val) : base(val)
		{
		}

		public File(string address):this( address_.File.Parse(address))
		{

		}

		static public bool Exists(nilnul.fs.address_.File file) {

			return System.IO.File.Exists(
				file.ToString()	
			);
		}

		public string address {
			get {
				return this.avowed.ToString();
			}
		}

		public override string ToString()
		{
			return this.avowed.ToString();
		}


		static public File Parse(string s) {

			
				return new File(
					address_.File.Parse(s)	
				);
			

		}

		static public File Parse_nullIfException(string s) {

			try
			{
				return new File(
					address_.File.Parse(s)	
				);
			}
			catch (Exception)
			{

				return null;
			}

		}
	}
}
