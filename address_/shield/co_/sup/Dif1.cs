namespace nilnul.fs.address_.shield.co_.sup
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DifX
	{
		static public nilnul.fs._address.Div _ofSupSub(
			nilnul.fs.address_.ShieldI sup
			,
			nilnul.fs.address_.ShieldI sub
		)
		{
			return nilnul.fs._address.route_.stem.duo_.sup._DifX._ofSupSub(sup.stem, sub.stem);
		}

		static public nilnul.fs._address.Div _ofShields(
			string sup
			,
			string sub
		)
		{
			return _ofSupSub(
				nilnul.fs.address_.Shield.Parse(sup)
				,
				nilnul.fs.address_.Shield.Parse(sub)
			);
		}

		static public nilnul.fs._address.Div _ofAddresses(
			string sup
			,
			string sub
		)
		{
			return _ofShields(
				nilnul.fs.address_.shield_._AddressX1.Txt(sup)
				,
				nilnul.fs.address_.shield_._AddressX1.Txt(sub)
			);
		}

		static public nilnul.fs._address.Div _ofAddresses(
			nilnul.fs.address_.ShieldI sup
			,
			string sub
		)
		{
			return _ofSupSub(
				sup
				,
				nilnul.fs.address_.shield_._AddressX1.Create(sub)
			);
		}



	}
}
