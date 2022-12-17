using nilnul.fs.path_.contextual_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.rted.be_
{
	/// <summary>
	/// end with deck
	/// </summary>
	public class Stem : rted.BeI
	{
		public bool be(path_.contextual_.IRted obj)
		{
			return obj switch {
				path_.Rted rted =>( rted.division is division_.Div ),

				_=> throw new UnexpectedTypeException()
				
				
				
			};
		}

		static public Stem Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Stem>.Instance;
			}
		}

	}
}
