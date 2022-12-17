using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.folder._cfg_.directory_.active
{
	/// <summary>
	/// assume the cfg active dir exists;
	/// </summary>
	/// <remarks>
	/// currently we don't allow a dir to be cognomened as empty such that, say, "abc/def" is equiv to "abc/(ddd)/def(comment)"
	/// </remarks>
	static public class _EnsureX
	{
	
		static public List< (string ver, IEnumerable<string> exts) > _Ver9extsEs_addressAssumeFolder_assumeNubs(
			string folder
			,
			IEnumerable<string> _eachDntAssumeNub
		) {
			var r = new List<(string ver, IEnumerable<string> exts)>();

			foreach (var nub in _eachDntAssumeNub)
			{
				var ensuredDir= div.dir_.active._EnsureX._Ver9exts_folderOfAddress_assumeNub(folder, nub);

				r.Add(ensuredDir);

				folder = System.IO.Path.Combine(
					 folder
					 ,
					 fs.folder._cfg_._DntX._Dnt_assumeNub_assumeExts(nub, ensuredDir)
					
				);

			}
			return r;

		}

		static public List< (string ver, IEnumerable<string> exts) > _Ver9extsEs_assumeNubs(
			nilnul.fs.FolderI1 folder
			,
			IEnumerable<string> _eachDntAssumeNub
		) {
			return _Ver9extsEs_addressAssumeFolder_assumeNubs(folder.ToString(),_eachDntAssumeNub);
		}
	}
}
