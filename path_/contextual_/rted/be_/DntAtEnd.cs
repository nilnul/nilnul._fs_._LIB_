using nilnul.fs.path_.contextual_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.rted.be_
{
	public class DntAtEnd : rted.BeI
	{
		public bool be(path_.contextual_.IRted obj)
		{
			return obj switch {
				path_.Rted rted =>path_.division.be_.DntAtEnd.Singleton.be( rted.division ),

				_=> throw new UnexpectedTypeException()
				
				
				
			};
		}

		static public DntAtEnd Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DntAtEnd>.Instance;
			}
		}

	}
}
