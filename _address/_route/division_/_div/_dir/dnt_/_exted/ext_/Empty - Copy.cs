namespace nilnul.fs._address.doc_._exted.ext_
{
	/// <summary>
	/// "". no dot in doc name, so the ext is "".
	/// </summary>
	public interface EmptyI : _exted.ExtI, _exted.Ext_emptyOrLedI
	{
	}
	public class Empty : EmptyI
	{


		static public Empty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty>.Instance;
			}
		}

	}


}
