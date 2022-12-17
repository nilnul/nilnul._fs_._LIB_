using System;

namespace nilnul.fs._address
{

	/// <summary>

	/// </summary>
	/// 
	[Obsolete()]
	public static class DivisionX
	{

		static public DivI ToDiv(DivisionI division)
		{
			if (division is DivI)
			{
				return division as DivI;
			}
			if (division is DocumentI /*document_.DivDoc*/) //documentI
			{
				var divisionAsDocument = division as DocumentI;// document_.DivDoc;
				return new Div(
					dirs.op_.binary_.Concat.Singleton.op(
						divisionAsDocument.div.dirs
						,
						new Dir(
							DstA.Parse(divisionAsDocument.doc.ToString())
						)
					)


				);

			}

			throw new UnexpectedTypeException();
		}



	}


}
