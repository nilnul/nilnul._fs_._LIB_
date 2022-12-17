using nilnul.fs.path_.division_._div._dir;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace nilnul.fs.path_.division_.div
{
	public class StepAppended :


		path_.contextual_.DivisionI
		,
		IEnumerable<IStep>
	{
		private path_.division_.Div _container;
		public path_.division_.Div container
		{
			get { return _container; }
			set { _container = value; }
		}

		private nilnul.fs.path_.division_._div._dir.IStep _toe;
		public nilnul.fs.path_.division_._div._dir.IStep toe
		{
			get { return _toe; }
			set { _toe = value; }
		}

		public StepAppended(path_.division_.Div relPath, _div._dir.IStep doc)
		{
			_container = relPath;
			_toe = doc;
		}

		public StepAppended(path_.division_.Div relPath, _address.IDnt doc):this(
			relPath
			,
			(_div._dir.IStep)doc
		)
		{
			
		}

		 public path_.division_.Div toDeckEnded() {
			return new Div(

				nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					_container
					,
					new _div.Dir(
						_toe

					)
				)
			);
		}

		static public StepAppended Parse(string s) {
			var lastIndexPlus = s.LastIndexOfAny(new []{ '\\','/'})+1;


			return new StepAppended(
				 path_.division_.Div.Parse(s.Substring(0,lastIndexPlus) )
				,
				 nilnul.fs.path_.division_._div._dir.StepX.Parse(s.Substring(lastIndexPlus) )
			);
		}
		public override string ToString()
		{
			return $"{_container}{_toe}";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="nameof(InvalidCastException)">
		/// step_.nonLiteral cast to literal
		/// </exception>
		public _address.dnts.Spliced  _toLiteral()
		{
			return new _address.dnts.Spliced(
				_div._dir.steps.Shrink.Singleton._op(this)
				.Cast<_address.IDnt>()
			);
			//throw new NotImplementedException();
		}

		public path_.division_._div._dir.Steps toShrink()
		{
			return new Steps(
				_div._dir.steps.Shrink.Singleton._op(this)
				//.Cast<_address.IDnt>()
			);
			//throw new NotImplementedException();
		}

		public _address.DivisionI toLiteral()
		{
			return _toLiteral();
			//throw new NotImplementedException();
		}

		public IEnumerator<IStep> GetEnumerator()
		{
			foreach (var item in this._container.Select(dir=>dir.step))
			{
				yield return item;

			}
			yield return _toe;

			//return nilnul.objs.op_.unary_._AppendX.Append<IStep>(
			//	this._container.Select(dir=>dir.step),this._toe
			//).GetEnumerator();
			//throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new System.NotImplementedException();
		}
	}
}