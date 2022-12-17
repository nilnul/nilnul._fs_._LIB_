﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{

	/// <summary>
	/// align the dirs vertically not horizontally
	/// alias: 
	///		self or directory
	/// such as:
	///		"", "a\", "a\b\"
	/// </summary>
	/// 
	[Obsolete()]
	public interface DivI
		:DivisionI
	{

		 DirsI dirs
		{
			get
			;
		}


	}
}
