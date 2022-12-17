using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.container_
{
	[Obsolete(nameof(shield_.baseDiv_._DivInDivision))]
	static public class _ContainerDivisionX
	{
		

		static public ContainerDiv CreateContainer(string containerAddress, string divDivision) {
			return CreateContainer(
				 nilnul.fs.address_.Container1.FroAddress(containerAddress)
				 ,
				 nilnul.fs._address.div_._DivisionX.Fro(divDivision)
			);
		}

		static public ContainerDiv CreateContainer(nilnul.fs.address_.ContainerI1 containerAddress, nilnul.fs._address.DivisionI divDivision) {
			return new ContainerDiv(
				 (containerAddress)
				 ,
				 nilnul.fs._address.div_._DivisionX.Fro(divDivision)
			);
		}



	}
}
