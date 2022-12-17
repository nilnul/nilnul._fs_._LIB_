using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.of_
{
	static public class _EnvVarEdX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_withEnvVar">
		/// eg:
		///		"%SystemRoot%\\Something"
		/// </param>
		/// <returns></returns>
		/// <remarks>
		/// eg:
		///		
		/// </remarks>
		static public string Txt_ofEnvVarEd(string _withEnvVar) {
			return Environment.ExpandEnvironmentVariables(
				_withEnvVar
			);
		}
	}
}
