using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file._address_._doc_._main.txt.be_
{
	public class Valid
		: nilnul.txt.BeI
	{

		static public char[] chars2exclude = System.IO.Path.GetInvalidPathChars();

		static nilnul.txt.be_.Exclude Excluding = new nilnul.txt.be_.Exclude(chars2exclude);

		public bool be(string obj)
		{
			return Excluding.be(obj)
				&& !IsStartedAllDots(obj);
			;
			//throw new NotImplementedException();
		}

		static public bool IsStartedAllDots(string name) {
			return name.Length > 0 && name.All(x=>x=='.');
		}


		static private Lazy<Valid> _Lazy = new Lazy<Valid>();
		static public Valid Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
