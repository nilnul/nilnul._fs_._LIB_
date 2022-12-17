using System;

namespace nilnul.fs._address.doc_._exted.ext.be_
{
	[Obsolete()]
	public class Empty : be_.Ext
	{
		public Empty() : base("")
		{

		}


		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}




	}
}
