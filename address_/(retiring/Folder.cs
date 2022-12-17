using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nilnul.fs._address;

namespace nilnul.fs.address_
{
	[Obsolete()]
	public class Folder
		: AddressI,FolderI
	{

		static public bool IsValid(string s)
		{

			try
			{
				Path.GetFullPath(s);//it will throw exceptions if the path is invalid.
				if (Path.IsPathRooted(s))
				{
					return true;

				}
				return false;
			}
			catch (Exception)
			{

				return false;
			}

			//To disallow relative paths(such as Word), call Path.IsPathRooted.

		}

		private Root _root;

		public Root root
		{
			get { return _root; }
			set { _root = value; }
		}

		private _address.Stem _stem;

		public _address.Stem stem
		{
			get { return _stem; }
			set { _stem = value; }
		}



		public Folder(Root root, _address.Stem stem)
		{
			_root = root;
			_stem = stem;

		}

		public Folder(Root root, IEnumerable<DirName> dirs):this(root,new Stem(dirs))
		{

		}

		public override string ToString()
		{
			return $"{_root.ToString()}{ _stem.ToString()}";
		}

		public string toTxt_endWithBackSlash() {
			return $"{_root}{_stem.toTxt_endWithBackslash()}";
		}

		static public Folder ParseNullable(string path_noTrailSlash ) {
			try
			{
				return Parse(path_noTrailSlash);
			}
			catch (FormatException e) {
				return null;
			}
			catch (Exception)
			{
				return null;
				//throw;
			}

		}

		static public Folder Parse(string obj_noTrailSlashExceptRoot) {
			var firstSlash = obj_noTrailSlashExceptRoot.IndexOf(
				System.IO.Path.DirectorySeparatorChar
			);

			if (firstSlash < 0)
			{
				throw new ArgumentException();
			}

			return new Folder(  
				new _address.Root(
					_address.Vol.Parse_fromTrimmed(
						obj_noTrailSlashExceptRoot.Substring(0, firstSlash)
					)
				)
				,
				 _address.Stem.Parse(
					obj_noTrailSlashExceptRoot.Substring(firstSlash + 1)
				)
			);
		}

		static public Folder CreateFroVolStem(_address.Vol vol, _address.Stem stem)
		{
			return new Folder(
				new Root( vol),stem
			);

		}

		static public Folder CreateFroFolderStem(Folder folder, _address.Stem stem) {

			return new Folder(
				folder.root
				,
				nilnul.fs._address.stem.co_.Concat.Eval(folder.stem, stem)
			);
		}
	}
}
