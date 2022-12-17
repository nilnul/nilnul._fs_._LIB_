using System;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public interface ShieldI
		: _shield_.StemI, _address_.VolI
		,
		AddressI
		,
		address_.Shield0SpearI
	{

	}

	[Obsolete()]
	static public class ShieldIX
	{
		static public ShieldI FroAddress(Shield0SpearI address)
		{
			switch (address)
			{
				case ShieldI shield:
					return shield;
				case SpearI spear:
					return nilnul.fs.address_.shield_._SpearX.Shield(spear);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

	}


}
