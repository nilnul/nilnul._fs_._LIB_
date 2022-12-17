namespace nilnul.fs.address_.spear_
{
	static public class _AddressX
	{


#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public SpearI Create(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		{
			return Create(s.processed);
		}


		static public SpearI Create(AddressI address)
		{
			return new Spear(
				address.vol
				,
				_address.route_.sprig_._RouteX2.Fro(
					address.route
				)
			);
		}

		static public SpearI Create(string address)
		{
			return Create(nilnul.fs.AddressA.Parse(address));
		}



	}
}
