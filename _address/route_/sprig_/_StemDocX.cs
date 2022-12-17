namespace nilnul.fs._address.route_.sprig_
{

	static public class _StemDocX

	{





		public static Sprig Create(StemI deckedDiv, nilnul.fs._address.DocI doc)
		{

			return new Sprig(
				 new Document(
					deckedDiv.div
				 ,
				 doc
				 )
			);
		}

		public static Sprig Create(StemI deckedDiv, nilnul.fs._address.Doc doc)
		{

			return Create(deckedDiv, (DocI)doc);
		}

		public static Sprig Create(StemI deckedDiv, string doc)
		{

			return Create(
				deckedDiv
				,
				new _address.Doc(doc)
			);
		}






	}
}
