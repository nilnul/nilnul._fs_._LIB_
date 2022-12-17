namespace nilnul.fs.address.op_.unary_
{
	
	static public class _UpX 
	{
		static public nilnul.fs.AddressI Op(nilnul.fs.AddressI address, nilnul.Num1 num)
		{
			return _assumeUpNatural(address, (int)(num.toBigint().en));


		}
		static public nilnul.fs.AddressI Op(string address, nilnul.Num1 num)
		{
			return Op(nilnul.fs.AddressA.Parse(address), num);


		}


		static public nilnul.fs.AddressI _assumeUpNatural(nilnul.fs.AddressI address, int _num)
		{
			if (_num ==0)
			{
				return address;
			}

			return _assumeUpNatural(nilnul.fs.address.op_.unary_._ParentX.Parent(address) , _num - 1);

		}

		

		static public nilnul.fs.address_.ShieldI Shield_upAssumePositive(nilnul.fs.address_.SpearI address, int _num)
		{
			var container = nilnul.fs.address_.spear._ContainerX.Shield(address);
			if (_num ==1)
			{
				return container;
			}


			return nilnul.fs.address_.shield.op_.unary_.Up.Op(
				container
				,
				_num-1

			);

		}



		static public nilnul.fs.AddressI _assumeUpNatural(string address, int _num)
		{
			return _assumeUpNatural( nilnul.fs.AddressA.Parse(address), _num);


		}

		

	}
}
