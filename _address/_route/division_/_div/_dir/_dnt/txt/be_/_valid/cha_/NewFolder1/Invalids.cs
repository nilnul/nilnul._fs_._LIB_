using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._dst._denote.txt.be_._valid.cha_
{
	///*extern alias character;*/
	///
	[Obsolete()]
	public class Invalids
		:
		///*character::*/
		nilnul.character_.cha.CollectionI
		
	{

		/// <summary>
		/// Something that a lot of people note with the Path class is that it has a method called ‘GetInvalidPathChars’, but the list doesn’t return two key values which obviously, are not allowed to be used as part of file names: ‘*’ and ‘?’.
		/// </summary>
		/*in visual studio, when you change a file name, you will be prompted what's invalid if it's invalid*/

		//static public IEnumerable<char> chars2exclude = System.IO.Path.GetInvalidFileNameChars().Concat(new[] { '.' });


		static internal IEnumerable<char> _SomeSpecialChars =
			System.IO.Path.GetInvalidFileNameChars().Concat(System.IO.Path.GetInvalidPathChars()).Concat(new char[] {
				'\\'
				,
				'/'
				,'?'
				,
				'*'
				//,'&'  
				,'"'
				,'<'
				,'>'
				,'|'
				//,'#'
				//,'%'
			
				//,				';'
				,
				':'
				//unicode control letters
				//invalid surrogate chars (but what about valid surrogates?)


			})
			;

		//static public nilnul.character_.cha.Set1 Set = new character_.cha.Set1(
		//	SpecialChars
		//);



		static private Lazy<Invalids> _Lazy = new Lazy<Invalids>();
		static public Invalids Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		static public Invalids Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Invalids>.Instance;
			}
		}


		//public IEqualityComparer<char> elementEq => throw new NotImplementedException();

		public bool contain(char element)
		{
			return (_SomeSpecialChars.Contains(element))
				//||
				//char.IsControl(element)
				/* \u0081 is admissible as
				"._ä¿¡æ¯æ•°æ®åº“-å¤§æ•°æ®Q1841éƒ­çºªæ¢-18080211" or
				"._ä¿¡æ\u0081¯æ•°æ\u008d®åº“-å¤§æ•°æ\u008d®Q1841éƒ­çºªæ¢\u0081-18080211"
				*/
				//|| char.IsSurrogate(element)	//🐟 is valid ,but is composed by two surrogate char
				//
				;
		}


	}
}
