using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.folder.duo.route_
{
	public class Rel
	{
		private nilnul.fs.address.duo.route_._rel.Parents _parents;

		public nilnul.fs.address.duo.route_._rel.Parents parents
		{
			get { return _parents; }
			set { _parents = value; }
		}

		private nilnul.fs._address.Stem _stem;

		public nilnul.fs._address.Stem stem
		{
			get { return _stem; }
			set { _stem = value; }
		}

		public Rel(
			nilnul.fs.address.duo.route_._rel.Parents parents
			,
			nilnul.fs._address.Stem stem
		)
		{
			_stem = stem;
			_parents = parents;
		}

		public override string ToString()
		{
			if (_parents.vals.Count()==0)
			{
				return $"{_stem}";
			}
			if (_stem.dirs.Count()==0)
			{
				return $"{_parents}";
			}
			return $"{_parents}{nilnul.fs._address.Separator.AsTxt}{_stem}";
		}

		static public nilnul.fs.address_.Folder GenFolder(
			nilnul.fs.address_.Folder origin
			,
			Rel rel  
		) {

			var originBackstepped = new nilnul.fs.address_.Folder(
				origin.root
				,

				origin.stem.dirs.Take( origin.stem.dirs.Count()- rel.parents.vals.Count())
			);
			return Folder.CreateFroFolderStem(
				originBackstepped
				,
				rel.stem


			);

		}


	}
}
