using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._route.division_._div._dir._dnt.txt.be_._valid.cha_
{
	///*extern alias character;*/
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
				,'"'		// this might be admissible? the answer is no in that: when in windows File Explorer, if we create a dir and try to key in this character, an error message is thrown
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
				//|| char.IsSurrogate(element);  //🐟 is valid, composed of a surrogate pair. this shall not be checked here. but should be done as rune.
				;
		}


	}
}
