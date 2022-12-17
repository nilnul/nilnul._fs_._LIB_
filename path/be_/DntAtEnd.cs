using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.be_
{
	public class DntAtEnd : path.BeI
	{
		public bool be(IPath obj)
		{
			return obj switch 
			{
				path_.contextual_.IDivision division => path_.division.be_.DntAtEnd.Singleton.be(division)
				,
				path_.contextual_.IRted rted=> path_.rted.be_.DntAtEnd.Singleton.be(rted)
				,
				path_.IFull full =>path_.full.be_.DntAtEnd.Singleton.be(full)
				,
				_ => throw new UnexpectedTypeException()

				
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
