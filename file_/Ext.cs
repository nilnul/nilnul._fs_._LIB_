using nilnul.fs.address_;
using nilnul.fs.address_.spear.be_.file.vow;
using System;

namespace nilnul.fs.file_
{
	/// <summary>
	/// a file with specified ext.
	/// </summary>
	public class Ext :
		nilnul.fs.file.be_.ext.vow.Ee
		,
		nilnul.fs.FileI
	{
		public Ext(FileI val, string ext) : base(val, ext)
		{
		}

		public Ext(FileI val, _address.doc_._exted.ExtI ext) : base(val, ext)
		{
		}

		public Ext(string s, string ext):this(
			new nilnul.fs.address_.Spear(s),ext
		)
		{

		}

		public Ext(Spear spear, string ext):this(new nilnul.fs.File(spear),ext)
		{
		}

		//public Ext(nilnul.fs.address_.spear_.Ext spear):base(new nilnul.fs.File(spear), spear.vow)
		//{

		//}

		public En file => this.ee.file;
	}
}
