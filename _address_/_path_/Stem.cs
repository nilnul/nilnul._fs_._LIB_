using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_
{
	/// <summary>
	/// a str of dir
	/// </summary>
	public class Stem
		:nilnul.fs._address_._path.DstsI
	{


		static public char SEPARATOR = System.IO.Path.DirectorySeparatorChar;

		private _path.Dsts _dirs;

		public _path.Dsts dirs
		{
			get { return _dirs; }
			//set { _childs = value; }
		}

		public Stem(_path.Dsts childs)
		{
			_dirs = childs;
		}

		public Stem(IEnumerable<_path.Dst> dsts):this(
			new _path.Dsts(dsts)
		)
		{

		}

		public Stem() : this(
			new _path.Dsts()
		)
		{

		}

		public override string ToString()
		{
			return _dirs.ToString();
		}
		/// <summary>
		/// empty or ends with backslash.
		/// </summary>
		/// <returns></returns>
		public string toTxt_endWithBackslash()
		{

			return string.Join("", _dirs.ed.Select(dir => dir.toTxt_endWithSepeartor()));

		}

		static public Stem Parse(string name)
		{
			var split = name.Split('\\','/');

			return CreateFromDirs(split);

		}

		public static Stem CreateFromDirs(IEnumerable<string> stemParts)
		{
			return new Stem(stemParts.Select(x => new _path.Dst(x)));

		}

	}
}


