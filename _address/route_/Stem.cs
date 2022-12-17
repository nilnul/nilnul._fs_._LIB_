using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.document_;

namespace nilnul.fs._address.route_
{

	/// related to root. a root-based container. such as:
	///		"/", "/a/", "/a/b/"
	///		
	[Obsolete()]
	public class Stem1 :
		nilnul.obj.Box<DivI1>
		, nilnul.fs._address.route_.StemI1
	{

		public Stem1(DivI1 val) : base(val)
		{
		}
		public Stem1():this(new nilnul.fs._address.Div1())
		{

		}

		public Stem1(IEnumerable<DirI1> enumerable):this(new Div1(enumerable))
		{
		}

		public _address.DivI1 div
		{
			get { return boxed; }
		}

		public DivisionI division
		{
			get
			{
				return div;
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return $"{System.IO.Path.DirectorySeparatorChar}{div}";
		}

		public static Stem1 Parse(string sTEM_since_Base)
		{
			nilnul.obj.vow_.True.Vow(
				sTEM_since_Base.StartsWith("\\") || sTEM_since_Base.StartsWith("/")
			);


			return new Stem1(
				nilnul.fs._address.Div1.Parse(
					sTEM_since_Base.Substring(1)
				)
			);

			throw new NotImplementedException();
		}

	}
}
