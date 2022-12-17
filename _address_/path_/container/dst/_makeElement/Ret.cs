using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path_.container.dst._makeElement
{
	public class Ret
	{
		private nilnul.fs._address_.path_.Container _container;

		public nilnul.fs._address_.path_.Container container
		{
			get { return _container; }
			set { _container = value; }
		}

		private nilnul.fs._address_._path.DstI _dst;

		public nilnul.fs._address_._path.DstI dst
		{
			get { return _dst; }
			set { _dst = value; }
		}


		public Ret(
			nilnul.fs._address_.path_.Container container
			,
			nilnul.fs._address_._path.DstI dst
		)
		{
			_container = container;
			_dst = dst;
		}

		public override string ToString()
		{


			return nilnul.txts.accumulate_.join_.Path.Singleton.accumulate(
				_container.ToString()
				,
				_dst.ToString()
			);
		}



	}
}
