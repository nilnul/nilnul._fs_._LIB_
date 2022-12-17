using System;
using System.IO;

namespace nilnul.fs._disk._part.vol_.xpN_
{
	[Serializable]
	public class DiscFullException : IOException
	{
		public DiscFullException() { }
		public DiscFullException(string message) : base(message) { }
		public DiscFullException(string message, Exception inner) : base(message, inner) { }
		protected DiscFullException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
