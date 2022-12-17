using System;
using System.Collections.Generic;

namespace nilnul.fs._address.route_
{

	/// related to root. a root-based container. such as:
	///		"/", "/a/", "/a/b/"
	///		
	public class Stem1 :
		nilnul.obj.Box1<_route.division_.DivI>
		, nilnul.fs._address.route_.StemI1
	{

		public Stem1(_route.division_.DivI val) : base(val)
		{
		}
		public Stem1() : this(new nilnul.fs._address._route.division_.Div())
		{

		}

		public Stem1(IEnumerable<_route.division_._div.DirI> enumerable) : this(new _route.division_.Div(enumerable))
		{
		}

		public Stem1(_route. DivisionI x) : this(nilnul.fs._address._route.division_.div.op_.of_._DivisionX._Of(x))
		{

		}

		public Stem1(_route.division_.div.IDnted  denotation):this(
			new _address._route.division_.Div(denotation)
		)
		{
		}

		public _address._route.division_.DivI div
		{
			get { return boxed; }
		}

		public _route. DivisionI division
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

		public static Stem1 Parse(string sTEM_since_Base)
		{
			nilnul.obj.vow_.True.Vow(
				sTEM_since_Base.StartsWith("\\") || sTEM_since_Base.StartsWith("/")
			);


			return new Stem1(
				nilnul.fs._address._route.division_.Div.Parse(
					sTEM_since_Base.Substring(1)
				)
			);

			throw new NotImplementedException();
		}

		static public route_.StemI1 Of(_address.RouteI1 route)
		{

			return new route_.Stem1(

				_route.division_.div.op_.of_._DivisionX._Of(
					route.division
				));

		}


	}
}
