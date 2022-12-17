using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._doc.ext
{
	[Obsolete()]
	public class Eq :
		nilnul.obj.eq_.Homomorph<Ext,string, nilnul.txt.nulable.eq_.CaseInsensitive>
		//,
		//IEqualityComparer<Ext>
	{

		public Eq():base(x=> x.name)
		{

		}





		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}


	}
}
