using nilnul.fs._address;
using nilnul.fs._address.route_;
using nilnul.fs.address_.shield.be_.nonRt;
using nilnul.fs.address_.shield_._nonRt_;

namespace nilnul.fs.address_.shield_
{
	public interface NonRtI : ShieldI
		, _nonRt_.EnI
	{
	}

	public class NonRt : address_.shield.be_.nonRt.En, NonRtI
	{
		public NonRt(ShieldI val) : base(val)
		{
		}

		public StemI stem => this.en.stem;

		public VolI vol => this.en.vol;

		public RouteI route => this.en.route;

		En EnI.en => this;
	}
}
