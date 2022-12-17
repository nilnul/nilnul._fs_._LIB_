using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path_
{
	/// <summary>
	/// 
	/// </summary>
	public class Element
	{
		private nilnul.fs._address_._path.dsts_.Started _dsts;

		public nilnul.fs._address_._path.dsts_.Started dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}


		public Element(
			nilnul.fs._address_._path.dsts_.Started dsts
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
