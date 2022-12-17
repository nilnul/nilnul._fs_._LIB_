using nilnul.fs._address.route_.stem.be_.noRt;

namespace nilnul.fs._address.route_.stem_
{
	public interface NoRtI
	{
		stem.be_.noRt.En en { get; }
	}

	public class NoRt :
		stem.be_.noRt.En
		,
		NoRtI
	{
		public NoRt(StemI val) : base(val)
		{
		}

		En NoRtI.en => this;
	}
}
