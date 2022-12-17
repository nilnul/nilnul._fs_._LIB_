namespace nilnul.fs.address_.shield.collection.op_.binary_
{
	public class Dif : BinaryI
	{
		public CollectionI op(CollectionI par, CollectionI par1)
		{
			return ret(par, par1);
			//throw new NotImplementedException();
		}

		public _dif.Ret ret(CollectionI par, CollectionI par1)
		{
			return new _dif.Ret(par, par1);
			//throw new NotImplementedException();
		}



		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
