using nilnul.fs._address.divDivision;
using System;

namespace nilnul.fs._address.division.co_.divDenotation
{
	

	static public class DuctX
	{
		static public nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc RelPath(DivI src, DocumentI dst)
		{
			return new nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc(
				nilnul.fs._address.div.co._RelPathX.Exe(src, dst.div)
				,
				dst.doc
			);
		}

		static public nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc RelPath(DivI src, Document dst)
		{
			return new nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc(
				nilnul.fs._address.div.co._RelPathX.Exe(src, dst.div)
				,
				dst.doc
			);
		}

		static public nilnul.fs.path_.division_.div.StepAppended RelPath(DivI src, DenotationI dst)
		{
			return new path_.division_.div.StepAppended(
				nilnul.fs._address.div.co._RelPathX.Div(src, dst.div)
				,
				dst.dnt
			);
		}

		static public nilnul.fs.path_.division_.div.StepAppended RelPath(DivI src, Denotation dst)
		{
			return new path_.division_.div.StepAppended(
				nilnul.fs._address.div.co._RelPathX.Div(src, dst.div)
				,
				dst.dnt
			);
		}


		static public nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc Denotation(DivI src, IDenotation dst)
		{
			switch (dst)
			{
				case nilnul.fs._address.DocumentI document:
					return RelPath(src, document);

				default:
					return RelPath(src, Document.Parse(dst.ToString()));
					break;
			}
		}

		static public nilnul.fs.path_.division_.div.StepAppended Denotation1(DivI src, IDenotation dst)
		{
			switch (dst)
			{
				case nilnul.fs._address.DenotationI document:
					return RelPath(src, document);

				default:
					return RelPath(src, _address.Denotation.Parse(dst.ToString()));
					break;
			}
		}

		

	}
}
