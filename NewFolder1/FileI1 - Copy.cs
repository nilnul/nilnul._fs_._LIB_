using nilnul.fs.address_;
using nilnul.fs.address_.spear.be_.file.vow;
using System;
using System.IO;

namespace nilnul.fs
{
	/// <summary>
	/// a composition of address and blob, by supplying an address which references to a blob
	/// this is not the inner content of the file, but the external handler/ref to the file
	/// </summary>
	///

	[Obsolete()]
	public interface FileI : _file_.BlankI, File0FolderI
	{

		nilnul.fs.address_.spear.be_.file.vow.En file { get; }



	}
	[Obsolete()]
	public class File :
		nilnul.fs.address_.spear.be_.file.vow.En,
		FileI
	{
		public File(SpearI val) : base(val)
		{
		}

		public File(string address) : this(
			nilnul.fs.address_.Spear.Parse(address)
		)
		{

		}

		public File(FileInfo fileInfo) : this(new nilnul.fs.address_.Spear(fileInfo))
		{

		}

		public En file => this;
	}
}
