using nilnul.fs._address_._path_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks> 
	/// alias: path
	/// </remarks>
	/// 
	[Obsolete()]
	public class Path : PathI
	{
		private Stem _stem;

		public Stem stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		/// <summary>
		/// it may be empty
		/// </summary>
		private Tip _tip;

		public Tip tip
		{
			get { return _tip; }
			set { _tip = value; }
		}

		public Path(_path_.Stem stem, _path_.Tip tip)
		{
			_stem = stem;
			_tip = tip;
		}

		public Path(_path_.Stem stem) : this(stem, new _path_.Tip())
		{

		}
		public Stem toStem()
		{
			if (nilnul.fs._address_._path_.tip.be_.Empty.Singleton.be(_tip))
			{
				return _stem;

			}

			return new Stem(
				_stem.dirs.ed.Concat(
					new[] {
						new _path.Dst(
							(_tip.val as nilnul.obj._opt_.val_.One<_path.Dst>).val.ToString()
						)
					}
				)
			);
		}

		public void makeFolderLike()
		{
			_stem = toStem();
			_tip = new Tip();
		}

		public Path toFolderLike()
		{
			return new Path(this.toStem());
		}

		/// <summary>
		/// remove last "\" when possible
		/// </summary>
		/// <returns></returns>
		public void makeFileLike()
		{
			if (nilnul.fs._address_._path_.tip.be_.Empty.Singleton.be(_tip))
			{
				if (_stem.dirs.ed.Any())
				{
					var new_stem = new Stem(_stem.dirs.ed.Take(_stem.dirs.ed.Count() - 1));
					_tip = new Tip(_stem.dirs.ed.Last());
					_stem = new_stem;
				}
			}
		}

		public Path toFileLike() {

			if (nilnul.fs._address_._path_.tip.be_.Empty.Singleton.be(_tip))
			{
				if (_stem.dirs.ed.Any())
				{
					return new Path(
						new Stem(_stem.dirs.ed.Take(_stem.dirs.ed.Count() - 1))
						,
						new Tip(_stem.dirs.ed.Last())
					);
				}
			}
			return this;
		}





		static public Path CreateEmpty()
		{
			return new Path(new Stem()
				,
				 new Tip()
			);
		}

		static public Path Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{

			if (s == "")
			{
				return Path.CreateEmpty(

				);
			}

			var sproutParts = s.processed.Split(System.IO.Path.PathSeparator);

			var stemParts = sproutParts.Take(sproutParts.Length - 1);

			var stem = Stem.CreateFromDirs(stemParts);

			var spear = new _path_.Tip(sproutParts.Last());
			return new Path(
				stem
				, spear
				);


		}
		/// <summary>
		/// note, there may be spaces on both ends
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public Path Parse(string s)
		{

			if (s == "")
			{
				return Path.CreateEmpty(

				);
			}

			var sproutParts = s.Split(System.IO.Path.DirectorySeparatorChar);

			var stemParts = sproutParts.Take(sproutParts.Length - 1);

			var stem = Stem.CreateFromDirs(stemParts);

			var tip = new Tip(sproutParts.Last());
			return new Path(
				stem
				, tip
				);


		}

		static public Path Parse_altSeperatorAllowed(string s)
		{

			if (s == "")
			{
				return Path.CreateEmpty(

				);
			}

			var sproutParts = s.Split(System.IO.Path.DirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar);

			var stemParts = sproutParts.Take(sproutParts.Length - 1);

			var stem = Stem.CreateFromDirs(stemParts);

			var tip = new Tip(sproutParts.Last());
			return new Path(
				stem
				, tip
				);


		}


		public override string ToString()
		{
			var stem = _stem.ToString();
			var sprout = _tip.ToString();
			if (stem == "")
			{
				return sprout;
			}
			return $"{stem}{System.IO.Path.DirectorySeparatorChar}{sprout}"
			;
		}

		public string toTxt()
		{
			return $"{_stem.toTxt_endWithBackslash()}{_tip}";
		}
	}
}
