using System;

namespace nilnul.fs._address
{
	/// <summary>
	/// the begining slash "/" or "\". Deck may be the same as Sep, or different from Sep
	/// </summary>
	public class Deck
	{
		static public bool Be(string s)
		{
			return s == System.IO.Path.DirectorySeparatorChar.ToString() || s == System.IO.Path.AltDirectorySeparatorChar.ToString();
		}

		static public bool Be(char s)
		{
			return s == System.IO.Path.DirectorySeparatorChar || s == System.IO.Path.AltDirectorySeparatorChar;
		}


		static public char ToChar()
		{
			return _route._SeparatorX.Default;
		}

		static public string ToTxt()
		{
			return ToChar().ToString();
		}

		static public void Vow(string s)
		{
			nilnul.obj.vow_.True.Vow(
				Be(
					s
				)
			);
		}

		public static void Vow(char v)
		{
			nilnul.obj.vow_.True.Vow(
				Be(
					v
				)
				,
				new exception_.ParseException($"{v} is not valid deck")
			);

			//throw new NotImplementedException();
		}

		public static void Vow(char v, Exception e)
		{
			nilnul.obj.vow_.True.Vow(
				Be(
					v
				), e
			);

			//throw new NotImplementedException();
		}

	}
}
