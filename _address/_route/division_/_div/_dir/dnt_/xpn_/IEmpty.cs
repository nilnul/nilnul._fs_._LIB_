using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir.dnt_.xpn_
{

	/// <summary>
	/// were a filename empty,our address would look like:
	///		c:\a\\\c
	///			the sep wouldnot work
	///				in fact it can work, if we just think there are "" inbetween consecutive slashes.
	///				but for robustness among different fs, we dont allow empty dnt
	/// </summary>
	[Serializable]
	public class EmptyException : Exception
	{
		public EmptyException():this("We dont allow empty dnt for robustness among different fs@os.") { }
		public EmptyException(string message) : base(message) { }
		public EmptyException(string message, Exception inner) : base(message, inner) { }
		protected EmptyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
