using System;

namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted
{
	public interface IExt { }
	public interface ExtI:IExt
	{
		//_ext.txt.En txt { get; }
	}

	/// <summary>
	/// </summary>
	public class Ext
		: _ext.txt.be.vow.En
		,
		ExtI
	{
		//public En txt => this;

		public Ext(
			string txt = ""
		) : base(
			_ext.txt.op_.unary_.PrependDotIfNeed.Singleton.op(txt)

		)
		{

		}

		static public implicit operator string(Ext ext)
		{
			return ext.en;
		}

		static public   Ext Of(doc_._exted.ExtI val)
		{

			return new Ext(val.ToString());
		}
	}


}
