using nilnul.fs._address.division.co._duct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path.co_.starT_.spear_.enD_.denotation_.dntAppended
{
	/// <summary>
	/// get the relpath of two files.
	/// </summary>
	static public class _ConcatX
	{

		static public nilnul.fs.path_.full_.tipped_.DntEnd Full(
			nilnul.fs.address_.spear_.ParentDoc origin
			,
			nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended route
		)
		{
			return starT_.shield_.enD_.denotation_.dntAppended._ConcatX.Full(origin.parent,route);
		}

		static public nilnul.fs.path_.full_.tipped_.DntEnd Full(
			nilnul.fs.address_.SpearI origin
			,
			nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended route
		)
		{
			return Full(  new address_.spear_.ParentDoc(origin), route);
		}

		static public nilnul.fs.address_.Spear  Spear(
			nilnul.fs.address_.spear_.ParentDoc origin
			,
			nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended route
		)
		{
			return Full(origin,route).toSpear();
		}

		static public nilnul.fs.address_.Spear  Spear(
			nilnul.fs.address_.SpearI origin
			,
			nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended route
		)
		{
			return Full(origin,route).toSpear();
		}


		static public nilnul.fs.address_.Spear  Spear(
			string origin
			,
			string route
		)
		{
			return Spear(
				 nilnul.fs.address_.spear_.ParentDoc.Parse(origin)
				 ,
				 nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended.Parse(route)
			);
		}


	
	}

	
}
