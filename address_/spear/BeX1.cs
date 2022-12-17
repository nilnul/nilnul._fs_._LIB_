using System;

namespace nilnul.fs.address_.spear
{
	static public class BeX1
	{
		[Obsolete(nameof(Be))]
		static public bool Be_ofAddress(this BeI1 be, string x)
		{
			return be.be(
				new nilnul.fs.address_.Spear1(x)
			);
		}

		static public bool Be(this BeI1 be, string x)
		{
			return be.be(
				new nilnul.fs.address_.Spear1(x)
			);
		}
		/// <summary>
		/// some implement both <see cref="BeI1"/> and <see cref="BeI"/>, thus extension methods <see cref="Be(BeI1, string)"/> would be able to be parsed as <see cref="BeX.Be(BeI, string)"/> as well, resuling an embarassing ambiguity.
		/// So use <see cref="Be1(BeI1, string)"/> instead. We increment the ver rather than rename published old name to avoid breaking changes.
		/// </summary>
		/// <param name="be"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public bool Be1(this BeI1 be, string x)
		{
			return be.be(
				new nilnul.fs.address_.Spear1(x)
			);
		}


	}
}
