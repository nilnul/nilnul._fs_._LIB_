using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.split
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		splice
	static public class _ReassembleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder">
		/// we don't allow root folder.
		/// this is parted:
		///		only docs, no dirs
		///		docs are vered by the same nom
		/// </param>
		static public string _Reassemble_assumeParted(
			nilnul.fs.folder_.based_.Child folder

		)
		{

			var docs = nilnul.fs.folder._DocsX.Docs(folder).OrderBy(
				d => nilnul.txt_.Vered3.Parse(d.caption).ver
				,
				nilnul.txt_.num_.radix.prefixed_.dec.ComparerWithPrefixCount.Singleton
			);

			var nameOfTgt1 = nilnul.txt_.vered._KeyX._Txt( folder.ee.child.caption ); //remove the trailing decimal integer

			if (nameOfTgt1.StartsWith("_"))
			{
				nameOfTgt1 = nameOfTgt1.Substring(1);
			}
			if (nameOfTgt1.EndsWith("_"))
			{
				nameOfTgt1= nameOfTgt1.Substring(0, nameOfTgt1.Length - 1);
			}
			if (nameOfTgt1 ==string.Empty)
			{
				nameOfTgt1 = "_";	///as the file name cannot be empty.
			}

			//var exted = nilnul.fs._address._route.division_._div._dir.dnt_.Exted.Parse(nameOfTgt1);

			//var stubAsTxt = exted.stub.ToString();
			//if (stubAsTxt.Any())
			//{
			//	if (char.IsDigit( stubAsTxt.Last() ))
			//	{
			//		nameOfTgt1 = exted.stub.ToString() + "_"+exted.ext.ToString();
			//	}
			//}

			
			//var nameOfTgt1 = doc1st.caption.en.Substring(0, nameOftgt);

			var targetAsAddress = new nilnul.fs.folder.dnt_.mainVered_.minVer_.Next(folder.ee.parent).address(nameOfTgt1);

			var mainOfNewfile = nilnul.fs.address_.spear._DocMainX.__Txt(targetAsAddress);

			var ver = nilnul.txt_.vered._VerX.Txt(mainOfNewfile);
			if (!string.IsNullOrWhiteSpace(ver) )
			{
				Trace.TraceWarning($@"
					target's main ver is not empty; check whether the original file being split is interrupted such that the original file is not recycled:
					{targetAsAddress}
				"
				);
			}

			using (var writer = System.IO.File.Create(targetAsAddress.ToString()))
			{
				foreach (var item in docs)
				{
					var d2read = System.IO.Path.Combine(
						folder.ee.ToString()
						,
						item.ToString()
					);
					using (var s = System.IO.File.OpenRead(d2read))
					{
							s.CopyTo(writer);
					}
				}
			}
			nilnul.fs.folder.drop_._RecyclableX.Drop(folder);
			return targetAsAddress;
		}

		public static string _Reassemble_assumeParted(Folder1 f)
		{
			return _Reassemble_assumeParted(
				(f.ee)
			);
		}

		public static string _Reassemble_assumeParted(ShieldI1 ee)
		{
			return _Reassemble_assumeParted(
				fs.folder_.based_.Child.Of(ee)
			);
		}

		static public string _Reassemble_folderOfAddressAssumeParted(
			string folder
			)
		{
			return _Reassemble_assumeParted(
				fs.folder_. based_.Child._OvAddress(folder)
			);
		}
	}
}