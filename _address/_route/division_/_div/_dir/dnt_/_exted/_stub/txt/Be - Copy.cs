using System;
using System.Linq;

namespace nilnul.fs._address.doc_._exted._main.txt
{
	[Obsolete()]
	public class Be
		: nilnul.txt.BeI
	{

		static public char[] chars2exclude = System.IO.Path.GetInvalidFileNameChars();

#pragma warning disable CS0618 // 'Exclude' is obsolete: 'NotContain'
#pragma warning disable CS0618 // 'Exclude' is obsolete: 'NotContain'
		static nilnul.txt.be_.Exclude Excluding = new nilnul.txt.be_.Exclude(chars2exclude);
#pragma warning restore CS0618 // 'Exclude' is obsolete: 'NotContain'
#pragma warning restore CS0618 // 'Exclude' is obsolete: 'NotContain'

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
