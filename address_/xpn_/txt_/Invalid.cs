using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.xpn_.txt_
{
	[Serializable]
	public class InvalidException : fs.address_.Xpn
	{
		public InvalidException() { }
		public InvalidException(string message) : base(message) { }
		public InvalidException(string message, Exception inner) : base(message, inner) { }
		protected InvalidException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}	
	
}
