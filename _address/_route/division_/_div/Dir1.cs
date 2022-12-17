using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	[Obsolete()]
	public class Dir1 

		:nilnul.obj.Box<DocI>
		,DirI1

	{

		public Dir1(DocI dst):base(dst)
		{
		}


		static public Dir1 Parse(string x) {
			nilnul.obj.vow_.True.Vow(
				x.EndsWith(
					nilnul.characters_.DirSeperator.Chars.First().ToString()
				)
				||
				x.EndsWith(
					nilnul.characters_.DirSeperator.Chars.Last().ToString()
				)
				,
				$"{x} as dir not ends with {nilnul.characters_.DirSeperator.Chars.First()} or {nilnul.characters_.DirSeperator.Chars.Last()}"


			);

			return new Dir1(
				new Doc(
					x.Substring(0, x.Length-1)
				)
			);
		}

		

		public DocI name => boxed;

		public override string ToString()
		{
			return $"{boxed}{System.IO.Path.DirectorySeparatorChar}";
		}

		

		
	}
}
