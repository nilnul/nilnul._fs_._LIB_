using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.denote_.vered_
{
	/// <summary>
	/// 
	/// </summary>
	public class _NextX
	{
		static public nilnul.NumI1 Num(DirectoryInfo dirInfo, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x)
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt.Versioned1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
			)
			.Select(x => (nilnul.Num1)x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.stuffed._MaxX._Cumulate_byLoop(s) + (nilnul.Num1)1;
			}
			return (nilnul.Num1)0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dirInfo"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.Num1 Num(DirectoryInfo dirInfo, nilnul.txt_._vered.Name prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x)
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt.Versioned1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
			)
			.Select(x => (nilnul.Num1)x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.stuffed._MaxX._Cumulate_byLoop(s) + (nilnul.Num1)1;
			}
			return (nilnul.Num1)0;
		}

		static public nilnul.Num Num(DirectoryInfo dirInfo, nilnul.txt_._vered_.Name prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x)
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt.Versioned1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
			)
			.Select(x => (nilnul.Num)x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}
		/// <summary>
		/// this is useful as "" is not valid, but "1" is. so we can specify the prefix "" and the min version to "1", not "0"
		/// </summary>
		/// <param name="dirInfo"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.NumI1 Num(DirectoryInfo dirInfo, nilnul.txt_.Vered2 prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix.name, x)
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt_.Vered1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
			)
			.Select(x => x.version);
			if (s.Any())
			{
				var r = nilnul.nums_.stuffed._MaxX._Cumulate_byLoop(s.Select(x => new nilnul.Num1(x))) + (nilnul.Num1)1;
				if (r < new nilnul.Num1(prefix.version))
				{
					return new Num1(prefix.version);
				}
				return r;
			}
			return prefix.version;
		}
		static public nilnul.NumI1 _Num(DirectoryInfo dirInfo, nilnul.fs._address._dst.denote_.Vered1 prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix.name, x)
			)
			.Select(
#pragma warning disable CS0612 // 'Versioned1' is obsolete
				x => nilnul.txt_.Vered1.Parse(x)
#pragma warning restore CS0612 // 'Versioned1' is obsolete
			)
			.Select(x => x.version);
			if (s.Any())
			{
				var r = nilnul.nums_.stuffed._MaxX._Cumulate_byLoop(s.Select(x => new nilnul.Num1(x))) + (nilnul.Num1)1;
				if (r < new nilnul.Num1(prefix.num))
				{
					return new Num1(prefix.num);
				}
				return r;
			}
			return prefix.num;
		}

		static public nilnul.NumI1 Num(nilnul.fs.FolderI dirInfo, nilnul.fs._address._dst.denote_.Vered1 prefix)
		{
			return _Num(nilnul.fs.folder.to_._InfoX.To(dirInfo), prefix);
		}
		/// <summary>
		/// ofName
		/// </summary>
		/// <param name="dirInfo"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public nilnul.NumI1 Num_ofVered(DirectoryInfo dirInfo, string prefix)
		{
			return _Num(dirInfo, new nilnul.fs._address._dst.denote_.Vered1(prefix));
		}

		static public nilnul.NumI1 Num_ofName(DirectoryInfo dirInfo, string prefix)
		{
			return Num(dirInfo, new nilnul.txt_._vered.Name(prefix));
		}

		static public nilnul.NumI1 Num(FolderI dirInfo, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return Num(nilnul.fs.folder.to_._InfoX.To(dirInfo), (prefix));
		}

		[Obsolete()]
		static public nilnul.Num Num(DirectoryInfo dirInfo, nilnul.txt_.Vered prefix)
		{
			return (nilnul.Num)Num(dirInfo, new nilnul.txt_.Vered2(prefix));
		}



		public static Num Num(nilnul.fs.address_.ShieldI parent, nilnul.txt_.Vered prefix)
		{
			return Num(new nilnul.fs.Folder(parent), prefix);
		}

		public static Num Num(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return Num(parent
				,
				nilnul.txt_.Vered.Parse(
					prefix
				)
			);
		}

		public static Num Num(nilnul.fs.FolderI parent, string prefix)
		{
			return (Num)Num_ofVered(nilnul.fs.folder.to_.Info.Singleton.to(parent), prefix);
		}


		public static string Name(FolderI parent, nilnul.fs._address._dst.denote_.Vered1 prefix)
		{
			return $@"{prefix.name}{
				nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(new Num1(Num(parent, prefix).toBigint()))
			}";
		}

		public static string Name(FolderI parent, string prefix)
		{
			return Name(parent, new nilnul.fs._address._dst.denote_.Vered1(prefix));

		}
		public static string Name(Folder parent, string prefix)
		{
			return Name((FolderI)parent, (prefix));

		}
		static public string Name(DirectoryInfo dirInfo, string prefix)
		{
			return Name(new nilnul.fs.Folder(dirInfo), prefix);
		}
		static public string Name(nilnul.fs.address_.ShieldI dirInfo, nilnul.txt_.Vered prefix)
		{
			return Name(new nilnul.fs.Folder(dirInfo), prefix);
		}


		static public string Name(nilnul.fs.address_.ShieldI dirInfo, string prefix)
		{
			return Name(new nilnul.fs.Folder(dirInfo), prefix);
		}


		public static string Name(FolderI parent, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty((int)(Num(parent, prefix).toBigint().en))}";
		}


		public static string Name(FolderI parent, nilnul.txt_._vered.Name prefix)
		{
			return Name(parent, new _address._dst.denote_._vered.Germ(prefix) );
		}
		public static string Name(Folder parent, nilnul.txt_._vered.Name prefix)
		{
			return Name((FolderI)parent, (prefix) );
		}

		static public string Name(nilnul.fs.address_.ShieldI dirInfo, nilnul.txt_._vered.Name prefix)
		{
			return Name(new nilnul.fs.Folder(dirInfo), prefix);
		}

		static public string Address(nilnul.fs.FolderI parent, _address._dst.denote_.Vered1 prefix)
		{
			return $"{parent}{Name(parent, prefix)}";
		}

		static public string Address(nilnul.fs.FolderI parent, string prefix)
		{
			return Address(parent, new _address._dst.denote_.Vered1(prefix));
		}

		static public string Address(nilnul.fs.Folder parent, string prefix)
		{
			return Address((FolderI)(parent), prefix);
		}

		static public string Address(nilnul.fs.FolderI parent, nilnul.fs._address._dst.denote_._vered.Germ prefix)
		{
			return $"{parent}{Name(parent, prefix)}";
		}

		/// <summary>
		/// this given ver or bigger
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="vered"></param>
		/// <returns></returns>
		static public string Address(nilnul.fs.address_.ShieldI parent, nilnul.txt_.Vered vered)
		{
			return $"{parent}{Name(parent, vered)}";
		}
		static public string Address(nilnul.fs.Folder parent, nilnul.txt_.Vered prefix)
		{
			return Address((FolderI)(parent), prefix);
		}
		/// <summary>
		/// this given ver or bigger
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="prefix"></param>
		/// <returns></returns>
		static public string Address(System.IO.DirectoryInfo parent, nilnul.txt_.Vered prefix)
		{
			return Address(new nilnul.fs.Folder(parent), prefix);
		}
		static public string Address(System.IO.DirectoryInfo parent, string prefix)
		{
			return Address(new nilnul.fs.Folder(parent), (prefix));
		}


		static public string Address(nilnul.fs.address_.ShieldI parent, string prefix)
		{
			return Address(new nilnul.fs.Folder(parent), prefix);
		}

		static public string Address(nilnul.fs.AddressI parent, string prefix)
		{
			return Address(nilnul.fs.address_.Shield.FroAddress(parent), prefix);
		}

		static public string Address_ofAddress(string parent, string prefix)
		{
			return Address(nilnul.fs.address_.Shield.FroAddress(parent), prefix);
		}



	}

}
