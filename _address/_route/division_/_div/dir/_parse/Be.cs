using System.Linq;

namespace nilnul.fs._address.dir._parse
{

	public class Be
		:
		nilnul.txt.BeI
	{


#pragma warning disable CS0108 // 'Dir.Parse(string)' hides inherited member 'DstA.Parse(string)'. Use the new keyword if hiding was intended.
		/// <summary>
		/// ended with sep
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public bool be(string x)
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
				return false;
			}

			return nilnul.fs._address._dst._denote.txt.be_.Valid.Singleton.be(x.Substring(0, x.Length - 1));
			
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
