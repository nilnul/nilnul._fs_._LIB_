using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._route.division_.div
{

	/// <summary>
	/// div and doc
	/// </summary>
	public class Dnted
		:
		DivisionI,

		DntedI
		,
		IEnumerable<_address._route.division_._div._dir. DntI>
	{
		private DivI _div;
		public DivI div
		{
			get { return _div; }
			set { _div = value; }
		}
		//private DntI _dnt;
		private _div._dir. DntI _dnt;

		public _div._dir. DntI dnt
		{
			get { return _dnt; }
			set { _dnt = value; }
		}

	

		public Dnted(
			DivI div,
			_div._dir.DntI doc
		)
		{
			_div = div;
			this._dnt = doc;
		}

		public Dnted(
			Div div,
			_div._dir.DntI doc
		):this((DivI)div, doc)
		{
			
		}

	
		public Dnted(Div div, _route.division_._div._dir. IDnt item2):this(div, division_._div._dir.Dnt.Ov( item2 ))
		{
			
		}

		public Dnted(IEnumerable<_div._dir.DntI> div, _div._dir. DntI dnt) : this(
			new Div(div),
			dnt
		)
		{
		}
		public Dnted((IEnumerable< _route.division_._div._dir. DntI>, division_._div._dir.DntI) p) : this(
			(p.Item1),
			p.Item2
		)
		{
		}
		public Dnted(IEnumerable<_div._dir.DntI> div, string dnt) : this(
			new Div(div),
			dnt
		)
		{
		}


		public Dnted(
			DivI div,
			_div._dir.Dnt doc
		) : this(div, (_div._dir. DntI)doc)
		{

		}



		public Dnted(Div div,_div._dir. Dnt name) : this(div as DivI, name)
		{

		}

		public Dnted(DivI div, string doc)
			: this(div, new _div._dir.Dnt(doc))
		{
		}
		

		public Dnted(Div div1, _div. DirI dirI1) : this(div1, dirI1.caption)
		{
		}


		public Dnted(IEnumerable<_div. DirI> enumerable, _div. DirI dirI1)
			: this(
				new Div(enumerable), dirI1
			)
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="div"> with sep at the end</param>
		/// <param name="doc"></param>
		public Dnted(string div, string doc)
			: this(Div.Parse(div), new _div._dir. Dnt(doc))
		{
		}

	

		public Dnted(_div._dir. DntI p) : this(
			new Div(),
			p
		)
		{
		}

		public Dnted(_div._dir. IDnt p) : this(
			new Div(),
			p
		)
		{
		}
		


		public override string ToString()
		{
			return $"{_div}{_dnt}";
		}




		//static public Dnted OvDnts(IEnumerable<string> dnts, string dnt) {
		//	return new Dnted(
		//		dnts.Select(x=>new _route.division_._div._dir.Dnt(x))
		//		,dnt
		//	);
		//}
		public static Dnted OvDnts((IEnumerable<string>, string) p)
		{
			return OvDnts(p.Item1, p.Item2);
		}
		static public Dnted OfStarted(IEnumerable<_div._dir.DntI> dnts) {
			return new Dnted(
				nilnul.objs_.started._TorsoTipX.TorsoTip(dnts)
			);
		}
		static public Dnted _OvAssumeStarted(IEnumerable<_div._dir.DntI> dnts) {
			return new Dnted(
				nilnul.objs_.started._TorsoTipX.TorsoTip(dnts)
			);
		}

		static public Dnted OvDnts(IEnumerable<string> dnts) {
			return _OvAssumeStarted(
				dnts.Select(x=>new _div._dir.Dnt(x))
			);
		}
		static public Dnted OvDnts(params string[] dnts)
		{
			return OvDnts(
				nilnul.obj.str_.started._TorsoTipX.TorsoTip(dnts)
			);
		}

		//static public Dnted Document(_route.division_._div._dir.IDnt denotation)
		//{
		//	return new Dnted(denotation);
		//}


		static public Dnted OvDnts(IEnumerable<string> dnts, string dnt)
		{
			return new Dnted(
				_route.division_.Div.OfDnts(dnts)
				,
				dnt
			);
		}
		static public Dnted OvDnts(string dnt, params string[] dnts)
		{
			return  OvDnts(
				nilnul.obj.str.op_.unary_._HeadX.Head(dnt,dnts)
			);
		}

		public static Dnted Of(DntedI denotation)
		{
			return denotation switch
			{
				Dnted x => x
				,
				_ => new Dnted(denotation.div,denotation.dnt )
			}
			;
		}
		static public Dnted Parse(string txt)
		{

			var split = txt.Split(nilnul.characters_.DirSeperator.Chars);

			return OvDnts(split);

			

		}
		public static Dnted Of(IDnted denotation)
		{
			return denotation switch
			{
				
				DntedI y => Of(y)
				,
				_ => Dnted.Parse(denotation.ToString())
			}
			;
		}



		public IEnumerator<_div._dir.DntI> GetEnumerator()
		{
			foreach (var item in this.div)
			{
				yield return item.caption ;  
			}
			yield return this.dnt;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
