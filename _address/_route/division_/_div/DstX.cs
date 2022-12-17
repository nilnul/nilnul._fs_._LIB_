namespace nilnul.fs._address
{
	/// <summary>
	///parse from a txt and convert to child, or
	///	subtype of child:
	///		dir
	///		doc
	/// </summary>
	static public class DstX
	{

		static public DstI Parse(string s)
		{

			return DstA.Parse(s);
		}

#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public DstI Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'

			return Parse(s.processed);
		}


	}
}
