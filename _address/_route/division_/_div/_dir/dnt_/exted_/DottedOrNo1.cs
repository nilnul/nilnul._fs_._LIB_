namespace nilnul.fs._address.doc_.exted_
{
	public interface DottedOrNoI : DocI
	{

	}

	static public class DottedOrNoIX
	{
		static public DottedOrNoI Parse(string s)
		{

			var lastDot = s.LastIndexOf(".");

			if (lastDot < 0)
			{
				return new doc_.exted_.NoDot(s);
				//throw new ArgumentException();
			}
			else
			{

				return new doc_.exted_.Dotted(
					s.Substring(0, lastDot)
					,
					s.Substring(lastDot + 1)  ///per doc, 如果 startIndex 等于此实例的长度，则为 Empty。

				);
			}
		}

		static public DottedOrNoI Ov(nilnul.fs._address.DocI s)
		{
			return Parse(s.denote);
		}



	}
}
