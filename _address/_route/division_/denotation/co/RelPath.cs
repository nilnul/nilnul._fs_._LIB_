using nilnul.fs._address.divDivision;
using nilnul.fs.path_.division_.div;
using System;

namespace nilnul.fs._address.denotation.co
{


	static public class _RelPathX
	{
		
		static public nilnul.fs.path_.division_.div.StepAppended RelPath_srcAsDiv(DenotationI src, DenotationI dst)
		{
			return division.co_.divDenotation.DuctX.RelPath(

				new _address.Div(src)

				, dst

				);
		}

		static public nilnul.fs.path_.division_.div.StepAppended RelPath_froContainer(DenotationI src, DenotationI dst)
		{
			return division.co_.divDenotation.DuctX.RelPath(src.div, dst);
		}


		static public nilnul.fs.path_.division_.div.StepAppended RelPath_froContainer(DocumentI src, DocumentI dst)
		{
			return RelPath_froContainer(
				fs._address.denotation._OfDocumentX.Denotation(src)
				,
				_OfDocumentX.Denotation(dst)
			) ;
		}

		public static StepAppended RelPath_srcAsDiv(DocumentI denotation, DocumentI document)
		{
			return RelPath_srcAsDiv(
				_address.denotation._OfDocumentX.Denotation(denotation)
				,
				_address.denotation._OfDocumentX.Denotation(document)
			);
		}
	}
}
