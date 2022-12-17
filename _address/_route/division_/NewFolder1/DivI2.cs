using System;

namespace nilnul.fs._address
{

	[Obsolete()]
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
	[Obsolete()]
	public interface DivI
		: DivisionI
		,IDiv
	{

		nilnul.fs._address.dir.str_.SeqI dirs
		{
			get
			;
		}


	}
}
