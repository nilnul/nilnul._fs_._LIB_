using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.vol_
{
	static public class _SysX
	{
		public const string ENV_VAR = "%SystemDrive%";

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// eg:
		///		C:
		/// </returns>
		static public string Txt_ovEnvVar() {
			return Environment.ExpandEnvironmentVariables(ENV_VAR);
		}
	}
}
