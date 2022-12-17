namespace nilnul.fs.address_
{
	public interface ShieldI1
		: _shield_.StemI1, _address_.VolI
		,
		AddressI1
		,
		address_.Shield0SpearI
	{

	}

	static public class ShieldIX1
	{
		static public ShieldI1 FroAddress(Shield0SpearI address)
		{
			switch (address)
			{
				case ShieldI1 shield:
					return shield;
				case SpearI1 spear:
					return nilnul.fs.address_.shield.op_.of_._SpearX.Shield(spear);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

	}


}
