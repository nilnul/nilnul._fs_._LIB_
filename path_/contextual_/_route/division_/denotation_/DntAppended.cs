using nilnul.fs.path_.division_._div._dir;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.path_.contextual_._route.division_.denotation_
{
	//[Obsolete("",true)]
	public class DntAppended :
		path_.contextual_.DivisionI
		//,
		//path_.contextual_.IDivision
		,
		IEnumerable<path_.division_._div._dir.IStep>
	{
		private path_.division_.Div _container;
		public path_.division_.Div container
		{
			get { return _container; }
			set { _container = value; }
		}



		private nilnul.fs._address._route.division_._div._dir.IDnt _dnt;
		public nilnul.fs._address._route.division_._div._dir.IDnt dnt
		{
			get { return _dnt; }
			set { _dnt = value; }
		}

		public DntAppended(path_.division_.Div relPath, nilnul.fs._address._route.division_._div._dir.IDnt doc)
		{
			_container = relPath;
			_dnt = doc;
		}

		public path_.division_.Div toDeckEnded()
		{
			return new path_.division_.Div(

				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					_container
					,
					new path_.division_._div.Dir(
						_dnt

					)
				)
			);
		}

		static public DntAppended Parse(string s)
		{
			var lastIndexPlus = s.LastIndexOfAny(new[] { '\\', '/' }) + 1;
			return new DntAppended(
				 path_.division_.Div.Parse(s.Substring(0, lastIndexPlus))
				,
				new nilnul.fs._address._route.division_._div._dir.Dnt(s.Substring(lastIndexPlus))
			);
		}
		public override string ToString()
		{
			return $"{_container}{_dnt}";
		}

		public _address._route.division_.div.Dnted _toLiteral1()
		{
			var shrunk =toShrink();
			return  _address._route.division_.div.Dnted._OvAssumeStarted(
				shrunk.Select(
					s=> fs._address._route.division_._div._dir.dnt.op_.of_._CoerceX.DntI(s)
				)
			);
			
		}

		public DntAppended toShrink()
		{
			return new DntAppended(
				this.container.toShrink()
				,
				this.dnt
			);
			
		}

		public IEnumerator<IStep> GetEnumerator()
		{
			foreach (var item in nilnul.objs.op_.unary_._AppendX.Append<IStep>(
				this.container.Select(d => d.step)
				,
				this.dnt
			))
			{
				yield return item;
			}

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new System.NotImplementedException();
		}

		public _address.DivisionI toLiteral()
		{
			return nilnul.fs._address._route.division_.denotation._RegressionsX.ToDocument( _toLiteral1() );
		}
	}
}