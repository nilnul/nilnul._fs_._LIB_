using System;
using System.Linq;

namespace nilnul.fs._address.doc_.exted_._noDot._main.txt
{
	public class Be
		: nilnul.txt.BeI
	{

		static public char[] chars2exclude = System.IO.Path.GetInvalidFileNameChars();

#pragma warning disable CS0618 // 'Exclude' is obsolete: 'NotContain'
#pragma warning disable CS0618 // 'Exclude' is obsolete: 'NotContain'
		static nilnul.txt.be_.Exclude Excluding = new nilnul.txt.be_.Exclude(chars2exclude);
#pragma warning restore CS0618 // 'Exclude' is obsolete: 'NotContain'
#pragma warning restore CS0618 // 'Exclude' is obsolete: 'NotContain'




		public bool be(string obj)
		{
			return Excluding.be(obj) && !obj.Contains('.');// && _NotStartedAllDots(obj);
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
