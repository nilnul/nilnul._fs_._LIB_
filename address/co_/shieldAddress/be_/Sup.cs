using nilnul.fs.address_;
using System;

namespace nilnul.fs.address.co_.shieldAddress.be_
{
	/// <summary>
	/// </summary>
	public class Sup
	{
		
		/// <summary>
		/// <paramref name="container"/> is the sub of <paramref name="division"/>
		/// </summary>
		/// <param name="container"></param>
		/// <param name="division"></param>
		/// <returns></returns>
		public bool be(address_.ShieldI container, AddressI division)
		{
			return division switch
			{
				nilnul.fs.address_.ShieldI shield => nilnul.fs.address_.shield.re_.Sup.Singleton.re(container, shield)
				,
				nilnul.fs.address_.SpearI spear => nilnul.fs.address.co_.shieldSpear.be_.Sup.Singleton.be(container, spear)
,
				_ => throw new UnexpectedTypeException($"{division} is neither {typeof(nilnul.fs.address_.ShieldI)} nore {typeof(nilnul.fs.address_.SpearI)}")
			}
			;

		}

		public bool be(ShieldI x, AddressI1 sub)
		{

			return be(x, address._RegressionsX.ToVerNil(sub) );
			;

		}

		static public Sup Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sup>.Instance;
			}
		}

	}
}
