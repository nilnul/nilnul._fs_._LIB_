using System.Linq;

namespace nilnul.fs._address.dir._parse
{

	public class Check
		:
		nilnul.obj._parse.CheckI
	{


#pragma warning disable CS0108 // 'Dir.Parse(string)' hides inherited member 'DstA.Parse(string)'. Use the new keyword if hiding was intended.
		/// <summary>
		/// ended with sep
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public string check(string x)
#pragma warning restore CS0108 // 'Dir.Parse(string)' hides inherited member 'DstA.Parse(string)'. Use the new keyword if hiding was intended.
		{
			if (
				!(
					x.EndsWith(
						nilnul.characters_.DirSeperator.Chars.First().ToString()
					)
					||
					x.EndsWith(
						nilnul.characters_.DirSeperator.Chars.Last().ToString()
					)
				)
			)
			{
				return $"{x} as dir not ends with {nilnul.characters_.DirSeperator.Chars.First()} or {nilnul.characters_.DirSeperator.Chars.Last()}";
			}

			var denoteCheck = nilnul.fs._address._dst.denote._parse.Check.Singleton.check(x.Substring(0, x.Length - 1));
			if (denoteCheck != "")
			{
				return $"the caption error:{denoteCheck}";
			}
			return "";
		}


		static public Check Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Check>.Instance;
			}
		}

	}
}
