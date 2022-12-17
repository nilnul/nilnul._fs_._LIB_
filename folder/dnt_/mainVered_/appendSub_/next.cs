using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using nilnul.fs._address.doc_;

namespace nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_
{
	public class Next
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI _parent
;
		public nilnul.fs.FolderI parent
		{
			get => _parent;
			set => _parent = parent;
		}

		public Next(
			nilnul.fs.FolderI folder
		)
		{
			_parent = folder;
		}

		public Next(
			nilnul.fs.address_.ShieldI parent
		) : this(
			new nilnul.fs.Folder(parent)
		)
		{

		}

		public static Next OvAddress(string address)
		{
			return new Next(nilnul.fs.Folder.FroAddress(
				address
				)
			);
		}



		public DirectoryInfo parentAsInfo => new DirectoryInfo(_parent.ToString());

	
	

		public nilnul.Num ver(string main, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return new denote_.MainVered(this.parent).nextVer_ofGerm(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(main)
				, 
				//(nilnul.fs._address.doc_._exted.ExtI)
				ext
			);
		}

		public nilnul.Num ver(nilnul.fs._address.doc_.MainExt doc)
		{
			return ver(doc.main,doc.ext);
		}

		public nilnul.Num ver(nilnul.fs._address.DocI doc)
		{
			return ver( _address.doc_.MainExt.Ov(doc));
		}








		public string denote(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return new denote_.MainVered(this.parent). next_ofGerm(nilnul.txt_._vered.Name._CreateByAppendingUnderscoreIfNecessary(prefix), ext);
		}




		public string denote(nilnul.fs._address.doc_.MainExt doc)
		{
			return denote(doc.main, doc.ext);
		}

		public string denote(string doc)
		{
			return denote(nilnul.fs._address.doc_.MainExt.Parse(doc) );
		}


		public string denote(nilnul.fs._address.DocI doc)
		{
			return denote(MainExt.Ov(doc));
		}

		public string denote(string prefix, nilnul.fs._address.doc_._exted.Ext ext)
		{
			return denote(
				(prefix),

				(_address.doc_._exted.ExtI)(
					ext
				)

			);
			//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		}

		public string denote(string prefix, string ext)
		{
			return denote(
				(prefix),
				new nilnul.fs._address.doc_._exted.Ext
				(
					ext
				)

			);
		}
	

		public string address(string prefix, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return new denote_.MainVered(this.parent).nextAddress(prefix,ext);
		}



		public string address(string prefix, string ext)
		{
			return new denote_.MainVered(this.parent).nextAddress(prefix,ext);

		}
		public string address(MainExt mainExt)
		{
			return address(mainExt.main, mainExt.ext);
		}
		public string address(nilnul.fs._address.DocI doc)
		{
			return address(
				 nilnul.fs._address.doc_.MainExt.Ov(doc)
			);
		}

		public string address(string doc)
		{
			return address(
				 nilnul.fs._address.doc_.MainExt.Parse(doc)
			);
		}



	}
}
