using System.Collections.Generic;

namespace nilnul.fs._address._route.division_
{

	public interface IDiv
		:IDivision
	{ }

	/// <summary>
	/// align the dirs vertically not horizontally
	/// alias: 
	///		self or directory
	/// such as:
	///		"", "a\", "a\b\"
	/// </summary>
	/// <remarks>
	/// a str of dirs
	/// </remarks>
	/// 
	public interface DivI
		: DivisionI
		,IDiv
		,
		IEnumerable<_div.DirI>
	{

		


	}
}
