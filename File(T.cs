using nilnul.fs.address_;
using nilnul.fs.address_.spear.be_.file.vow;
using System.IO;

namespace nilnul.fs
{
	/// <summary>
	/// a composition of address and blob, by supplying an address which references to a blob
	/// this is not the inner content of the file, but the external handler/ref to the file
	/// </summary>
	/// 
	public interface FileI<TSpear> : _file_.BlankI, File0FolderI
		where TSpear: nilnul.fs.address_.SpearI1

	{

		nilnul.fs.address_.spear.be_.file.vow.Ee<TSpear> file { get; }



	}
	public class File<TSpear> :
		nilnul.fs.address_.spear.be_.file.vow.Ee<TSpear>
		,
		FileI<TSpear>

		where TSpear: nilnul.fs.address_.SpearI1
	{
		public File(TSpear val) : base(val)
		{
		}

		

		

		public Ee<TSpear> file  => this;
	}
}
