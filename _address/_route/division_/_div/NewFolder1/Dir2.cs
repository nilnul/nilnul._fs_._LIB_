using System;
using System.Linq;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	///
	[Obsolete()]
	public class Dir

		:
		DstA
		,
		DirI
	{

		public Dir(_dst.Denote denote)
			: base(denote)
		{
		}

		public Dir(DstI dst) : base(dst.denote)
		{
		}

		public Dir(DstA dst) : base(dst.denote)
		{
		}

		public Dir(DocI doc) : this(doc.denote)
		{

		}
		public Dir(Doc doc) : this(doc.denote)
		{

		}
#if false
		///not allowed since string here is ambiguous:
		///	is it doc, say "a"? dir, say "a/"?  dst,say "a" or "a/"?  
		public Dir(string doc) : this(new Doc(doc) )
		{

		}

#endif


		public Dir(IDnt s):this(
			Doc.Ov(s)
		)
		{
		}

		

		public override string ToString()
		{
			return $"{boxed}{_route._SeparatorX.Default}";
		}

		public  string phraseUsingSlash()
		{
			return $"{boxed}/";
		}



#pragma warning disable CS0108 // 'Dir.Parse(string)' hides inherited member 'DstA.Parse(string)'. Use the new keyword if hiding was intended.
		/// <summary>
		/// ended with sep
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public static Dir Parse(string x)
#pragma warning restore CS0108 // 'Dir.Parse(string)' hides inherited member 'DstA.Parse(string)'. Use the new keyword if hiding was intended.
		{
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
				new _dst.Denote(
					x.Substring(0, x.Length - 1)
				)
			);
		}

		public static Dir OvDst(string dst)
		{
			return new Dir(DstA.Parse(dst));
		}

		public static Dir OvDenote(string denote)
		{
			return new Dir(new _dst.Denote(denote));
		}
	}
}
