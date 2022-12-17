using System;
using System.Collections.Generic;

namespace nilnul.fs._address._route.division_.div
{

	/// <summary>
	/// "a", "a\b"
	/// exclude:
	///		"", "a\", "a\b\"
	/// </summary>
	/// 

	public interface DntedI :
		DestinationI
		//,
		//DivisionI
		, _dnted_.DivI
		//,
		//_denotation_.DntI
		//, fs._address.IDenotation
		, _dnted_.DntI
		,
		IDnted
	{


	}

	
}



