using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address_.path_;

namespace nilnul.fs.address_._driveEntry_.entry_.container.dst
{
	public class Element
		:
		EntryA,
		
		ElementI
	{

		private entry_.Container _container;

		public entry_.Container container
		{
			get { return _container; }
			set { _container = value; }
		}

		private nilnul.fs._address.DstI _dst;

		public nilnul.fs._address.DstI dst
		{
			get { return _dst; }
			set { _dst = value; }
		}


		public Element(
			entry_.Container container
			,
			nilnul.fs._address.DstI dst

		)
		{

			_container = container;
			_dst = dst;

		}

		public override string ToString()
		{
			return $"{_container}{dst}";
		}

		public static Element CreateFroContainerDoc(string sTEM_since_Base, string dOC)
		{
			return new Element(
				entry_.Container.Parse(sTEM_since_Base)
				,
				new _address.Dst(dOC)
			);
			throw new NotImplementedException();
		}
	}
}
