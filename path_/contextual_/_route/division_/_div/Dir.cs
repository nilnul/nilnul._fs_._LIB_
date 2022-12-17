using nilnul.fs.path_.division_._div._dir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.division_._div
{
	public interface IDir {

	}
	public class Dir
		: nilnul.obj.Box1<IStep>
	{
		public Dir(IStep val) : base(val)
		{
		}

		public IStep step
		{
			get { return boxed; }
			set { boxed = value; }
		}


		public static Dir Parse(string x)

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

				 _dir.StepX.Parse(
					x.Substring(0, x.Length - 1)
				)
			);
		}

		public override string ToString()
		{
			return $"{boxed}{ _address._route._SeparatorX.Default}";
		}
	}
}
