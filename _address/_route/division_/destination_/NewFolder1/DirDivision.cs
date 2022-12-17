using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.destination_
{
	[Obsolete()]
	static public class _DirDivisionX
	{
		

		static public nilnul.fs._address.DestinationI Destination(_address.DirI dir, _address.DivisionI division) {

			switch (_address.DivisionA.Normal(division))
			{
				case DivI div1:
					return _address.directory_._DirDivX.Directory(dir, div1);
				case DocumentI document:
					return denotation_._DivDenotationX.Splice(dir, document);
				default:
					throw new UnexpectedTypeException();
					break;
			}


		}



	}
}
