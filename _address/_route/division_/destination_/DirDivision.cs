using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_.destination_
{
	static public class _DirDivisionX
	{
		

		static public nilnul.fs._address._route.division_.DestinationI Destination(_address._route.division_._div.DirI dir, _address._route.DivisionI division) {

			switch (_address._route.DivisionA.Normal(division))
			{
				case DivI div1:
					return _address._route.division_.div_.directory_._DirDivX.Directory(dir, div1);
				case _address._route.division_.div.DntedI document:
					return denotation_._DivDenotationX.Splice(dir, document);
				default:
					throw new UnexpectedTypeException();
					break;
			}


		}



	}
}
