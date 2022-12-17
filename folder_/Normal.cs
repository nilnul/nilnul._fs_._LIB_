using nilnul.fs.address_;
using nilnul.fs.folder.be_.normal.vow;

namespace nilnul.fs.folder_
{
	public interface NormalI
	{
		nilnul.fs.folder.be_.normal.vow.En normal { get; }
	}
	/// <summary>
	/// nonlink
	/// </summary>
	public class Normal
		: nilnul.fs.folder.be_.normal.vow.En
		,
		NormalI
	{
		public Normal(FolderI val) : base(val)
		{

		}
		public Normal(ShieldI shield) : base(shield)
		{

		}
		static public Normal FroShield(string shield)
		{
			return new Normal(
				nilnul.fs.address_.Shield.Parse(shield)
			);
		}

		static public Normal FroAddress(string shield)
		{
			return FroShield(
				nilnul.fs.address_.shield_._AddressX1.Txt(shield)
			);
		}



		public En normal => this;
	}
}
