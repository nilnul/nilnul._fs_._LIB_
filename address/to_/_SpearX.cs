namespace nilnul.fs.address.to_
{
	public static class _SpearX
	{
		public static nilnul.fs.address_.SpearI Spear(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.SpearI spear:
					return spear;
				case nilnul.fs.address_.ShieldI shield:
					return nilnul.fs.address_.shield.to_._SpearX.Spear(shield);
				default:
					return Spear(nilnul.fs.AddressA.Parse(address.ToString()));
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}
	}
}
