using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address_._path;

namespace nilnul.fs._address_._path_.stem_
{
	public class Started:
		nilnul.objs_.Started<nilnul.fs._address_._path.DstI, nilnul.fs._address_._path.DstsI>
		,
		StemI
	{
		

		public Started(nilnul.fs._address_._path.Dst head, _address_._path_.Stem tail)
			:base( head, tail  )
		{
		}


	}
}
