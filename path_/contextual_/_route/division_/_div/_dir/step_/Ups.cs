using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.division_._div._dir.step_
{
	public class Ups
	{

		private IEnumerable<Up> _vals;

		public IEnumerable<Up> vals
		{
			get { return _vals; }
			set { _vals = value; }
		}
		public Ups(params Up[] vals):this(vals as IEnumerable<Up>)
		{

		}
		public Ups(IEnumerable<Up> vals)
		{
			_vals = vals;
		}


		static public Ups CreateFroCount(int _natural) {
			return new Ups(
				Enumerable.Repeat(new Up(),_natural)
			);
		}
		public override string ToString()
		{
			return string.Join(
				System.IO.Path.DirectorySeparatorChar.ToString()
				,_vals//.Select(x=>x.ToString())
			);
		}

	}
}
