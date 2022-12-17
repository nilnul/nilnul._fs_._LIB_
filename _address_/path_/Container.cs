using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path_
{
	/// <summary>
	/// empty or slash ended.
	/// </summary>
	public class Container
	{
		private nilnul.fs._address_._path.DstsI1 _dsts;

		public nilnul.fs._address_._path.DstsI1 dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}

		public Container(
			nilnul.fs._address_._path.DstsI1 dsts
		)
		{
			_dsts = dsts;
		}

		public override string ToString()
		{


			return nilnul.txts.accumulate_.join_.Path.Singleton.accumulate(
				_dsts
			);
		}


	}


}
