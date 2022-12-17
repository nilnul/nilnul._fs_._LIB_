namespace nilnul.fs.address_.shield
{


	public static class _DocumentX
	{


		static public nilnul.fs.address_.SpearI Spear_ofParentDocument(
			nilnul.fs.address_.ShieldI container
			,
			nilnul.fs._address.DocumentI document

		)
		{
			return new nilnul.fs.address_.spear_.ParentDocument(container, document);
		}





		public static nilnul.fs.address_.SpearI Spear_ofParentDocument(nilnul.fs.address_.ShieldI container, string document)
		{
			return Spear_ofParentDocument(container, nilnul.fs._address.Document.Parse(document));
		}
	}
}
