using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield_.xpn_
{

	[Serializable]
	public class ParseException : shield_.Xpn
	{
		public ParseException() { }
		public ParseException(string message) : base(message) { }
		public ParseException(string message, Exception inner) : base(message, inner) { }
		protected ParseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
