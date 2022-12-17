using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;
using nilnul.fs.address_._shield_;

namespace nilnul.fs.address_.container_
{
	public class ContainerDiv:ContainerI1
	{
		private ContainerI1 _container;

		public ContainerI1 container
		{
			get { return _container; }
			set { _container = value; }
		}

		private nilnul.fs._address.DivI _div;

		public nilnul.fs._address.DivI div
		{
			get { return _div; }
			set { _div = value; }
		}

		public VolI vol => _container.vol;

		public RouteI route => stem;

		public nilnul.fs._address.route_.StemI stem =>  nilnul.fs._address.route_.stem_._RouteX.Fro( 
			_container.stem
		);


		public ContainerDiv(ContainerI1 container, nilnul.fs._address.DivI div)
		{
			_container = container;
			_div = div;
		}


		public ContainerDiv(ContainerI1 container):this(container, new _address.Div())
		{
		}

		public override string ToString()
		{
			return $"{_container}{_div}";
		}

		static public ContainerDiv OfContainerAddress_DivDivision(string containerAddress, string divDivision) {
			return new ContainerDiv(
				 nilnul.fs.address_.Container1.FroAddress(containerAddress)
				 ,
				 nilnul.fs._address.div_._DivisionX.Fro(divDivision)
			);
		}


	}
}
