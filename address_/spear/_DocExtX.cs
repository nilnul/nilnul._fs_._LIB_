namespace nilnul.fs.address_.spear
{
	/// <summary>
	/// retrun the ext of doc
	/// </summary>
	public class _DocExtX
	{
		static public nilnul.fs._address.doc_._exted.ExtI Ext(nilnul.fs.address_.SpearI spear)
		{
			return nilnul.fs._address.doc_.exted._ExtX.Ext(spear.sprig.document.doc);
		}
		static public nilnul.fs._address.doc_._exted.ExtI Ext(string spear)
		{
			return Ext(new Spear(spear));
		}


	}
}
