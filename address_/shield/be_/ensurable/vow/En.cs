namespace nilnul.fs.address_.shield.be_.ensurable.vow
{
	public class Ee : nilnul.fs.address_.shield.vow.ee_.VowDefault<ensurable.Vow>
	{
		

		public Ee(nilnul.fs.address_.ShieldI val) : base((val))
		{

		}


		static public Ee FroShield(string name)
		{
			return new Ee(
				 nilnul.fs.address_.Shield.Parse(name)
			);
		}
		static public Ee FroAddress(string name)
		{
			return new Ee(
				nilnul.fs.address_.shield_._AddressX1.Create(name)
			);
		}



	}
}
