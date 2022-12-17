namespace nilnul.fs.address_.shield
{
	static public class _DocX
	{
		static public nilnul.fs.address_.SpearI Spear(ShieldI container, string doc)
		{

			return new Spear(
				container.vol,
				  new _address.route_.sprig_.StemDoc(container.stem, doc
				 )
			);
		}
		static public nilnul.fs.address_.SpearI Spear_ofParentAddress(string container, string doc)
		{

			return Spear(
				Shield.FroAddress(container), doc
			);
		}


	}
}
