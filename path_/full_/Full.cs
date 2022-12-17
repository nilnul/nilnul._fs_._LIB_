using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_
{

	public class Abs:IFull
	{
		private nilnul.fs.address_.File _file;
		public nilnul.fs.address_.File file
		{
			get { return _file; }
			set { _file = value; }
		}

		public Abs(File file)
		{
			this._file = file;
		}

		public override string ToString()
		{
			return _file.ToString();
		}

		static public Abs Parse(string x) {

			return new Abs(nilnul.fs.address_.File.Parse(x));
		}


	}
}
