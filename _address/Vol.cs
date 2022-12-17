using nilnul.exception_;
using nilnul.fs._address._vol_._name.txt.be;
using System;

namespace nilnul.fs._address
{
	//extern alias bit;
	/*extern alias obj;*/
	/// <summary>
	/// the logical drives inside a partion of a disk.
	/// </summary>
	/// 
	[Serializable]
	public class Vol :
		/*obj::*/nilnul.obj.Box<_vol_._name.txt.be.En>
		,
		VolI
	{
		//private nilnul.character.en_.Letter _letter;

		[Obsolete("for a server there might be more than 26 drives and we have to name it as AA")]
		public nilnul.character.en_.Letter letter
		{
			get
			{
				return new nilnul.character.en_.Letter(boxed.en[0]);

			}
			//set { _letter = value; }
		}

		public En name => this.boxed;

		public Vol(_vol_._name.txt.be.En name) : base(name)
		{

		}

#pragma warning disable CS0612 // 'Ed' is obsolete
		public Vol(nilnul.txt.op_.trim.Ed s) : this(new En(s))
#pragma warning restore CS0612 // 'Ed' is obsolete
		{

		}
#pragma warning disable CS0612 // 'Ed' is obsolete
		public Vol(string s) : this(new nilnul.txt.op_.trim.Ed(s))
#pragma warning restore CS0612 // 'Ed' is obsolete
		{

		}

		public Vol(nilnul.character.en_.Letter letter)
			: this(
				new En(letter.avowed.ToString())
			)
		{
			// _letter = letter;

		}



		public Vol() : this('C')
		{

		}

		public Vol(char c) : this(
			new character.en_.Letter(c)
		)
		{

		}
		static public implicit operator Vol(string txt)
		{
			return Parse(txt.Trim());
		}


		public override string ToString()
		{
			return name.ToString() + ":";
		}

		static public Vol Parse_fromTrimmed(string s)
		{
			new /*bit::*/nilnul.bit.vow_.True1<ParseException>(
				new nilnul.exception_.ParseException("vol is not ended with ':'.")).vow(s.EndsWith(":")
			);

			new/*bit::*/nilnul.bit.vow_.True1<ParseException>(
				new ParseException("vol length is not 2.")
			).vow(s.Length == 2);
			try
			{
				return new Vol(
					new character.en_.Letter(s[0])
				);

			}
			catch (nilnul.obj_.xpn_.UnacceptableException)
			{

				throw new nilnul.obj_.xpn_.ParseException(
					$"{s[0]} is not vol"
				);
			}

		}

		static public Vol OvDisk(string s) {
			return new Vol(s);
		}

		static public Vol Parse(string s)
		{
			nilnul.obj.aver_.True.Aver(s.EndsWith(":"));

			nilnul.obj.aver_.True.Aver(s.Length == 2);

			return new Vol(
				new character.en_.Letter(s[0])
			);

		}

	}
}
