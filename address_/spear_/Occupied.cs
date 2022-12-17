namespace nilnul.fs.address_.spear_
{
	public class Occupied :
		nilnul.fs.address_.spear.be_.occupied.vow.En
		,
		_location_.BlankI
	{
		public Occupied(SpearI val) : base(val)
		{
		}

		public Occupied(Spear address) : this((SpearI)address)
		{
		}

		public Occupied(string address) : this(new Spear(address))
		{
		}


	}
}
