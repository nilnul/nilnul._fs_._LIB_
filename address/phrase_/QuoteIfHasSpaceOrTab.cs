namespace nilnul.fs.address.phrase_
{
	public class QuoteIfHasSpaceOrTab
#pragma warning disable CS0618 // 'PhraseI<AddressI>' is obsolete: 'ObjI'
		: nilnul.obj.PhraseI<
			nilnul.fs.AddressI
		>
#pragma warning restore CS0618 // 'PhraseI<AddressI>' is obsolete: 'ObjI'
	{
		public string phrase(AddressI obj)
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
