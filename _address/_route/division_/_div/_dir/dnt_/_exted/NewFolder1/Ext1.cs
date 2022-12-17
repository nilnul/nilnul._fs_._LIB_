using System;

namespace nilnul.fs._address.doc_._exted
{
	[Obsolete()]
	public interface ExtI
	{
		//_ext.txt.En txt { get; }
	}

	/// <summary>
	/// </summary>
	[Obsolete()]
	public class Ext
		: _ext.txt.En
		,
		ExtI
	{
		//public En txt => this;

		public Ext(
			string txt = ""
		) : base(
			_ext.txt.op_.Normalize.Singleton.op(txt)

		)
		{

		}

		static public implicit operator string(Ext ext)
		{
			return ext.en;
		}


	}


}
