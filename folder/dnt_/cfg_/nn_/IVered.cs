using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dnt_.cfg_.nn_
{
	/// <summary>
	/// let's say we have the following dir or docs:
	///		.nilnul
	///		.nilnul0
	///		.nilnul3
	///		.nilnul003
	///		.nilnul003.ini
	///		.nilnul03/
	///		.nilnul2/
	///	as 3 is the max ver, so the following will be taken into account:
	///		.nilnul3
	///		.nilnul003
	///		.nilnul003.ini
	///		.nilnul03/
	///	other dnts are vered old and are disregarded.
	/// </summary>
	class IVered
	{
	}
}
