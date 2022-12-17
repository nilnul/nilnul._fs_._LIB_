using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{


	/// <summary>
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public interface IDnts 
	{
	}
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// vs Denotation:
	///		Denotation has at least one dnt.
	///	vs Div
	///		div is a collection of dir, joined by "", where dir is suffixedDnt
	///	<seealso cref="division.co._duct.IPass"/>
	/// </remarks>
	public class Dnts :
		nilnul.obj.Box1<IEnumerable<IDnt>>
		,
IEnumerable<IDnt>
		
	{
		public Dnts(IEnumerable<IDnt> val) : base(val)
		{
		}

		public override string ToString()
		{
			return string.Join(
				_address._route._SeparatorX.AsTxt
				,
				this.boxed
			);
		}

		public  string PhraseUsingSlash()
		{
			return string.Join(
				"/"
				,
				this.boxed
			);
		}

		public IEnumerator<IDnt> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
