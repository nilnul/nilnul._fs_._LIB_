using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.route_.xpn_
{

	/// <summary>
	/// the path, when literalized, is invalid cuz of negation above the rt.
	/// eg:
	///		\..
	///			is invalid, as when associated with any origin, the result is still invalid.
	///		
	/// </summary>
	[Serializable]
	public class AboveRtException : Exception
	{
		public AboveRtException() { }
		public AboveRtException(string message) : base(message) { }
		public AboveRtException(string message, Exception inner) : base(message, inner) { }
		protected AboveRtException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
