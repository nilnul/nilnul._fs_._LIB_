using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_._route.division_
{
	/// <summary>
	/// eg:
	///		""
	///		a
	///		a\b
	///		
	/// </summary>
	/// <see cref="TypeNameFormatFlags(nilnul.fs.path_.division_._div._dir.Steps)"/>
	public class Spliced : List<path_.division_._div._dir.Steps.Dnts>
		,
		_address.DivisionI

	{

		public _address.Dnts dnts
		{
			get { return boxed; }
			set { boxed = value; }
		}

		public Spliced(Dnts val) : base(val)
		{
		}

		public Spliced(IEnumerable<IDnt> enumerable):this(new Dnts(enumerable) )
		{
		}

		public override string ToString()
		{
			return string.Join( System.IO.Path.DirectorySeparatorChar.ToString(), boxed);
		}
	}
}
