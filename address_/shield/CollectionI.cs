namespace nilnul.fs.address_.shield
{
	public interface CollectionI
		: nilnul.obj._collection_.ContainI<nilnul.fs.address_.ShieldI>
	{

	}

	static public class CollectionX
	{
		static public bool Contain_ofAddress(this CollectionI collection, string address)
		{
			return collection.contain(
				nilnul.fs.address_.shield_._AddressX1.Create(address)
			);
		}
		static public bool Contain_ofShield(this CollectionI collection, string address)
		{
			return collection.contain(
				nilnul.fs.address_.Shield.Parse(address)
			);
		}


	}
}
