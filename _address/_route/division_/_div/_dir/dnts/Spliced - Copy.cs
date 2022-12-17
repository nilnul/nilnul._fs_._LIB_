using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dnts
{
	/// <summary>
	/// eg:
	///		""
	///		a
	///		a\b
	///		
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs._address._route.division_._div._dir.dnts.Spliced))]
	public class Spliced : nilnul.obj.Box1<_address.Dnts>
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
