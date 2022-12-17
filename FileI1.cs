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
	public interface FileI1 : _file_.BlankI, File0FolderI
	{

		nilnul.fs.address_.spear.be_.file.vow.Ee1 file { get; }



	}
	public class File1 :
		nilnul.fs.address_.spear.be_.file.vow.Ee1
		,
		FileI1
	{
		public File1(SpearI1 val) : base(val)
		{
		}

		public File1(string address) : this(
			nilnul.fs.address_.Spear1.Parse(address)
		)
		{
		}

		public File1(FileInfo fileInfo) : this(new nilnul.fs.address_.Spear1(fileInfo))
		{
		}

		public Ee1 file  => this;
	}
}
