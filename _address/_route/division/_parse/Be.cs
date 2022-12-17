using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs._address.division._parse
{
	public class Be : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			if (Regex.IsMatch(obj, @"[^\\\/]\z"))
			{

				return fs._address.document._parse.Be.Singleton.be(obj);
			}
			return fs._address.div._parse.Be.Singleton.be(obj);
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
