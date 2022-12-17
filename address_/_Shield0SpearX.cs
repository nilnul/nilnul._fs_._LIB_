using System;

namespace nilnul.fs.address_
{
	

	static public class _Shield0SpearX
	{
		[Obsolete()]
		static public nilnul.fs.address_.Shield0SpearI CheckByBreak(nilnul.fs.address_.Shield0SpearI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.ShieldI shield:
					return shield;
				case nilnul.fs.address_.SpearI spear:
					return spear;
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		[Obsolete()]

		static public nilnul.fs.address_.Shield0SpearI Parse(string address)
		{
			if (nilnul.fs.address.be_._shield.txt._EndWithSepX.Be(address))
			{
				return nilnul.fs.address_.Shield.Parse(address);
			}
			return nilnul.fs.address_.Spear.Parse(address);

		}

		[Obsolete()]

		static public nilnul.fs.address_.Shield0SpearI Parse(nilnul.fs.AddressI address)
		{
			switch (address)
			{
				case nilnul.fs.address_.Shield0SpearI shield0Spear:
					return shield0Spear;

				default:
					return Parse(address.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}




	}
}