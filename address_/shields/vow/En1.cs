namespace nilnul.fs.address_.shields.vow
{
	public class En1<TVow> : nilnul.obj.vow.En<nilnul.fs.address_.ShieldsI, TVow>
		where TVow : nilnul.fs.address_.shields.VowI1, new()
	{
		public En1(ShieldsI val) : base(val)
		{
		}

		public override string ToString()
		{
			return nilnul.fs.address.str._PhraseX.Phrase(this.en);
		}
	}
}
