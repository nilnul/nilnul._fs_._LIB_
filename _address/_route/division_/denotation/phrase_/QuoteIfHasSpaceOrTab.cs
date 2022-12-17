namespace nilnul.fs._address.document.phrase_
{
	public class QuoteIfHasSpaceOrTab
#pragma warning disable CS0618 // 'PhraseI<DocumentI>' is obsolete: 'ObjI'
		: nilnul.obj.PhraseI<
			nilnul.fs._address.DocumentI
		>
#pragma warning restore CS0618 // 'PhraseI<DocumentI>' is obsolete: 'ObjI'
	{
		public string phrase(DocumentI obj)
		{
			return nilnul.txt.op_.unary_._QuoteIfHasSpaceTabX.Op(obj.ToString());

		}

		static public QuoteIfHasSpaceOrTab Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<QuoteIfHasSpaceOrTab>.Instance;
			}
		}

	}
}
