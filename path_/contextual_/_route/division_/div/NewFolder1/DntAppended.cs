using nilnul.fs.path_.division_._div._dir;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.path_.division_.div
{
	//[Obsolete("",true)]
	public class DntAppended :
		path_.contextual_.DivisionI,

		path_.contextual_.IDivision
		,
		IEnumerable<_div._dir.IStep>
	{
		private path_.division_.Div _container;
		public path_.division_.Div container
		{
			get { return _container; }
			set { _container = value; }
		}



		private nilnul.fs._address.IDnt _dnt;
		public nilnul.fs._address.IDnt dnt
		{
			get { return _dnt; }
			set { _dnt = value; }
		}

		public DntAppended(path_.division_.Div relPath, _address.IDnt doc)
		{
			_container = relPath;
			_dnt = doc;
		}

		public path_.division_.Div toDeckEnded()
		{
			return new Div(

				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					_container
					,
					new _div.Dir(
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
				new nilnul.fs._address.Dnt(s.Substring(lastIndexPlus))
			);
		}
		public override string ToString()
		{
			return $"{_container}{_dnt}";
		}

		public _address.DivisionI toLiteral()
		{
			var shrunk = _div._dir.steps.Shrink.Singleton._op(this).Cast<_address.DntI1>();
			if (shrunk.Any())
			{
				return  _address.Denotation._OvAssumeStarted(shrunk);
			}
			return new _address.Div(
							
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
			throw new System.NotImplementedException();
		}
	}
}