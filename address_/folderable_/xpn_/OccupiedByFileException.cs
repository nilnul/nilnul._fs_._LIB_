using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.folderable_.xpn_
{

	/// <summary>
	/// the address is occupied by file so it's not a folder, and it cannot be created as a folder
	/// </summary>
	[Serializable]
	public class OccupiedByFileException : Exception
	{
		public OccupiedByFileException() { }
		public OccupiedByFileException(string message) : base(message) { }
		public OccupiedByFileException(string message, Exception inner) : base(message, inner) { }
		protected OccupiedByFileException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
