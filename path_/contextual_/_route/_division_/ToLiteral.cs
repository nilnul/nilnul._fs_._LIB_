using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_._division_
{
	public interface ToLiteralI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="nameof(InvalidCastException)">
		///		even when shrunk, some step is still nonliteral; and when cast, exception is thrown
		/// </exception>
		nilnul.fs._address.DivisionI toLiteral();
	}
}
