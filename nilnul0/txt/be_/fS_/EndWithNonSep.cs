using System.Text.RegularExpressions;

namespace nilnul.txt.be_.fS_
{
	public class EndWithNonsep : nilnul.txt.BeI
	{
		public bool be(string route)
		{

			return Regex.IsMatch(
				route
				,
				@"[^\\\/]\z"
			);
			
		}


		static public EndWithNonsep Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EndWithNonsep>.Instance;
			}
		}

	}
}
