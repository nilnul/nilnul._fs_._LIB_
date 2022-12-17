using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Linq.Expressions;
using nilnul.fs._address.division.co._duct._pass.step;
using System;
using nilnul.fs._address;
using nilnul.fs._address._route.division_._div._dir.dnts;

namespace nilnul.fs.path_.division_._div._dir
{
	/// <summary>
	/// eg:
	///		""
	///		a
	///		a/b
	///		
	/// </summary>
	public class Steps :
		nilnul.obj.Box1< IEnumerable<IStep>>
		,
		nilnul.fs.path_.contextual_.DivisionI
		
	{
		public Steps(IEnumerable<IStep> val) : base(val)
		{
		}

		public path_.division_.Div toDeckEnded() {
			return new path_.division_.Div(
				boxed.Select(s=> new path_.division_._div.Dir(s) )
				
			);
		}

		static public IEnumerable<IStep> OvUpsForwards(int backs, IEnumerable<_address.DocI> forwards) {
			return nilnul.obj.str_._ArrX.Generate(
				backs,
			_dir.step_.Up.Singleton
			).Cast<IStep>().Concat(forwards);
		}

		public static IEnumerable<IStep> OvUpsForwards(int backs, IEnumerable<_address.IDnt> forwards)
		{
			return nilnul.obj.str_._ArrX.Generate(
				backs,
			_dir.step_.Up.Singleton
			).Cast<IStep>().Concat(forwards);

		}
		

		static public Steps Parse(string s) {
			return new Steps(
				s.Split(new []{ '\\','/'}).Select(x=> StepX.Parse(x) )
			);

			
		}
		public override string ToString()
		{
			return string.Join( nilnul.fs._address._route._SeparatorX.AsTxt, boxed);
		}

		public DivisionI toLiteral()
		{
			return new _address._route.division_._div._dir.dnts.Spliced(
				_div._dir.steps.Shrink.Singleton._op(this.boxed)
				.Cast<_address.IDnt>().Select(d=> nilnul.fs._address._route.division_._div._dir.dnt._RegressionsX.ToNew(d))
			).ToOldDivision();

		}
		public Steps toShrink()
		{
			return new Steps(
				_div._dir.steps.Shrink.Singleton._op(this.boxed)
			);
		}
	}
}