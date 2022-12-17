using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.nulable.re_
{
	/// <summary>
	/// ignore whitespace lines
	/// </summary>
	public class JointOnPadded : nilnul.txt.ReI
	{

		public bool _re_ofTrimmed(string a, string b)
		{
			if (a == string.Empty )
			{
				return false;
			}
			if (b==string.Empty)
			{
				return false;
			}

			return nilnul.fs.address.re_.Joint.Singleton.re(
				a,b
			);

			//throw new NotImplementedException();
		}


		/// <summary>
		/// assume all whitespaces or padded address
		/// </summary>
		/// <param name="a">
		///   padded address. or just all whitespace.
		/// </param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(string a, string b)
		{
			return _re_ofTrimmed(a.Trim(),b.Trim());
		}

		

		static public JointOnPadded Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<JointOnPadded>.Instance;
			}
		}

	}
}
