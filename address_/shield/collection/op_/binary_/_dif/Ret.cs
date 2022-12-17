namespace nilnul.fs.address_.shield.collection.op_.binary_._dif
{
	public class Ret : nilnul.obj._call_.argArg1_.ClosedA<CollectionI>
		, CollectionI
	{
		public Ret(CollectionI arg, CollectionI arg1) : base(arg, arg1)
		{
		}

		public bool contain(ShieldI element)
		{
			return nilnul.bit.op_.binary_.Gt.Singleton.op(
				arg.contain(element)
				,
				arg1.contain(element)
			);
			//throw new NotImplementedException();
		}

		public bool contain_ofAddress(string x)
		{
			return contain(nilnul.fs.address_.shield_._AddressX1.Create(x));
		}



	}
}
