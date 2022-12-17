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
	public class Dir 

		:nilnul.obj.Box<DstI>
		,DirI

	{

		public Dir(DstI dst):base(dst)
		{
		}


		static public Dir Parse(string x) {
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

			return new Dir(
				new Dst(
					x.Substring(0, x.Length-1)
				)
			);
		}

		[Obsolete()]
		static public Dir CreateFroDst(string dst) {
			return new Dir(
				new Dst(dst)
			);
		}
	


		public DstI dst
		{
			get { return boxed; }
		}



		public override string ToString()
		{
			return $"{dst}{System.IO.Path.DirectorySeparatorChar}";
		}

		static public string ToTxt(DstI dst) {

			return $"{dst}{System.IO.Path.DirectorySeparatorChar}";

		}

		
	}
}
