using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.file_.nonlinks
{
	static public class _DelDupX
	{
		static public void _Void(
			IEnumerable<string> _files_nonlink
			,
			StreamWriter log
		)
		{
			_Void(_files_nonlink.Select(x => new nilnul.fs.File(x)), log);
		}
		static public void _Void(
			IEnumerable<nilnul.fs.File> _files_nonlink
			,
			StreamWriter log
		)
		{
			var partiton = nilnul.set.partite_._InnerEqDefaultX.Partite(
				_files_nonlink
				,
				nilnul.fs.file.eq_.Binary.Singleton
			);

			foreach (var part in partiton)
			{

				var ordered = part.OrderBy(
					x =>
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTime
				);

				var kept = ordered.First(); /// !important in that the newer ones may become symbolink and will not be kept


				ordered.Skip(1).ForEach(
					y =>
					{
						log.WriteLine();
						log.WriteLine(nilnul.txt.op_.unary_.RepeatX.Repeat("-", 20));
						log.Write("\t");
						log.WriteLine($"deleting{y}");
						nilnul.fs.file.del_._RecyclableX.Del(y);
						log.Write("\t");
						log.WriteLine($"deleted{y}");
						log.Write("\t");
						log.WriteLine($"creating link {y} -> {kept}");
						nilnul.fs.file_.link_._SymX.Create(
							y.file.en
								,
							kept

						);
						log.Write("\t");
						log.WriteLine($"created link {y} -> {kept}");
						log.WriteLine(nilnul.txt.op_.unary_.RepeatX.Repeat("-", 20));
						log.WriteLine();

					}
				);
			}

		}


	}
}

