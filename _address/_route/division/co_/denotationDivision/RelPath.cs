using nilnul.fs._address.divDivision;
using System;

namespace nilnul.fs._address.division.co_.denotationDivision
{
	

	static public class RelPathX
	{
		/// <summary>
		/// src.doc is not considered.
		/// </summary>
		/// <param name="src"></param>
		/// <param name="dst"></param>
		/// <returns></returns>
		static public division.co._duct.IPass RelPath(DocumentI src, DivisionI dst)
		{

			return  nilnul.fs._address.division.co_.divDivision.RelPathX.RelPath(
				src.div
				,
				dst
			);
		}

		static public path_.contextual_.DivisionI Division_sinceSrcContainer(DenotationI src, DivisionI dst)
		{

			return  nilnul.fs._address.division.co_.divDivision.RelPathX.Division(
				src.div
				,
				dst
			);
		}


		static public path_.contextual_.DivisionI Division_sinceSrcContainer(IDenotation src, DivisionI dst)
		{
			return Division_sinceSrcContainer(
				  DenotationIX.Ov(src),dst
			);

			
		}

		//static public path_.contextual_.DivisionI Division_srcMadeDiv(DenotationI src, DivisionI dst)
		//{

		//	return  nilnul.fs._address.division.co_.divDivision.RelPathX.Division(
		//		new fs._address.Div(src)
		//		,
		//		dst
		//	);
		//}
		static public path_.contextual_.DivisionI Division_srcMadeDiv(DenotationI src, DivisionI dst)
		{

			return  nilnul.fs._address.division.co_.divDivision.RelPathX.Division(
				new nilnul.fs._address.Div(
				src
				)
				,
				dst
			);
		}

		static public path_.contextual_.DivisionI Division_srcMadeDiv(IDenotation src, DivisionI dst)
		{

			return  nilnul.fs._address.division.co_.divDivision.RelPathX.Division(
				new nilnul.fs._address.Div(
				src
				)
				,
				dst
			);
		}

		static public division.co._duct.IPass RelPath(IDenotation src, DivisionI dst)
		{
			switch (src)
			{
				case DocumentI document:
					return RelPath(document,dst);

				default:
					return RelPath(Document.Parse(src.ToString()), dst);

					break;
			}

		}




		

	}
}
