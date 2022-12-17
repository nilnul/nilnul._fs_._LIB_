using System;
using System.Linq;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted._stub.txt
{
	public class Be
		: nilnul.txt.BeI
	{

		static public char[] chars2exclude = System.IO.Path.GetInvalidFileNameChars();

		static nilnul.txt.be_.Exclude Excluding = new nilnul.txt.be_.Exclude(chars2exclude);

		static public bool __IsStartedAllDots(string name)
		{
			return name.Length > 0 && name.All(x => x == '.');
		}
		static public bool _NotStartedAllDots(string name)
		{
			return !__IsStartedAllDots(name);
		}

		public bool be(string obj)
		{
			return Excluding.be(obj);// && _NotStartedAllDots(obj);
									 //throw new NotImplementedException();
		}


		static private Lazy<Be> _Lazy = new Lazy<Be>();
		static public Be Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
