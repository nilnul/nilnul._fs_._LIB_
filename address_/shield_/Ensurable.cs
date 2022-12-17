using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.shield_
{
	/// <summary>
	/// a folder, or not occupied
	/// </summary>
	public class Ensurable : nilnul.fs.address_.shield.be_.ensurable.vow.Ee
		,ShieldI
		,
		IFolderable
	{
		public Ensurable(ShieldI val) : base(val)
		{
		}

		public static Ensurable OfAddress(string address) {
			return new Ensurable(nilnul.fs.address_.Shield.FroAddress(address));
		}

		public StemI stem => ee.stem;

		public VolI vol => ee.vol;

		public RouteI route => ee.route;
	}
}
