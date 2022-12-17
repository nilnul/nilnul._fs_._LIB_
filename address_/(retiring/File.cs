using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	/// <summary>
	/// construct an address for a file.
	/// </summary>
	/// 
	public class File
		: AddressI
	{
		private Folder _folder;

		public Folder folder
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private _address.DocNameI _doc;

		public _address.DocNameI doc
		{
			get { return _doc; }
			set { _doc = value; }
		}

		public File(
			Folder folder,
			_address.DocNameI doc

		)
		{
			_folder = folder;
			_doc = doc;
		}

		public File(
			Folder folder,
			string doc

		) : 
		this(
			folder
			,
nilnul.fs._address.DocNameA.Parse(doc)
		)
		{

		}


		public override string ToString()
		{
			return $"{folder.toTxt_endWithBackSlash()}{doc}";
		}

		static public File Parse(string file)
		{
			var lastStub = file.LastIndexOf(System.IO.Path.DirectorySeparatorChar);

			if (lastStub < 0)
			{
				throw new ArgumentException();
			}
			else
			{
				return new address_.File(

					Folder.Parse(
						file.Substring(0, lastStub)
					)
					,
					_address.DocNameA.Parse(
						file.Substring(lastStub + 1)
					)
				);
			}
		}

		static public File CreateFroContainerDoc(string container, string doc) {
			return new File(
				nilnul.fs.address_.Folder.Parse(container)
				,
				doc
			);
		}

		static public File Parse_nullIfException(string file)
		{
			try
			{
				return Parse(file);
			}
			catch (Exception)
			{
				return null;
			}
		}


	}
}
