using System;
using System.Collections.Generic;

namespace nilnul.fs._address.route_
{

	/// related to root. a root-based container. such as:
	///		"/", "/a/", "/a/b/"
	///
	[Obsolete()]
	public class Stem :
		nilnul.obj.Box<DivI>
		, nilnul.fs._address.route_.StemI
	{

		public Stem(DivI val) : base(val)
		{
		}
		public Stem() : this(new nilnul.fs._address.Div())
		{

		}

		public Stem(IEnumerable<DirI> enumerable) : this(new Div(enumerable))
		{
		}

#pragma warning disable CS0618 // '_DivisionX.Fro(DivisionI)' is obsolete: 'defending against obsolete types'
		public Stem(DivisionI x) : this(nilnul.fs._address.div_._DivisionX.Fro(x))
#pragma warning restore CS0618 // '_DivisionX.Fro(DivisionI)' is obsolete: 'defending against obsolete types'
		{

		}

		public Stem(IDenotation denotation):this(
			new _address.Div(denotation)
		)
		{
		}

		public _address.DivI div
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
			return $"{_route._SeparatorX.Default}{div}";
		}

		public static Stem Parse(string sTEM_since_Base)
		{
			nilnul.obj.vow_.True.Vow(
				sTEM_since_Base.StartsWith("\\") || sTEM_since_Base.StartsWith("/")
			);


			return new Stem(
				nilnul.fs._address.Div.Parse(
					sTEM_since_Base.Substring(1)
				)
			);

			throw new NotImplementedException();
		}

		static public route_.StemI Ov(RouteI route)
		{

			return new route_.Stem(
				DivisionX.ToDiv(
					route.division
				));

		}


	}
}
