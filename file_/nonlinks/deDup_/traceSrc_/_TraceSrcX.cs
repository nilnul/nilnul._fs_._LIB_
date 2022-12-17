using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace nilnul.fs.file_.nonlinks.dedup_.traceSrc_
{
	static public class _HardLinkX
	{
		static public void _Void(
			IEnumerable<string> _files_nonlink
			,
			TraceSource log
		)
		{
			_Void(_files_nonlink.Select(x => new nilnul.fs.File(x)), log);
		}
		static public void _Void(
			IEnumerable<nilnul.fs.File> _files_nonlink
			,
			TraceSource log
		)
		{
			var partiton = nilnul.set.partite_._InnerEqDefaultX.Partite(
				_files_nonlink
				,
				nilnul.fs.file.eq_.Binary.Singleton
			);

			foreach (var part in partiton)
			{

				var ordered = part
					.OrderBy(
						x=> x.file.en.sprig.document.div.dirs.Count()
					)
					.OrderBy(
					x =>
					nilnul.fs.file.to_.ToFileInfo.Singleton.to(x).LastWriteTime
				);

				var kept = ordered.First(); /// !important in that the newer ones may become symbolink and will not be kept


				ordered.Skip(1).ForEach(
					y =>
					{
						log.TraceInformation("");
						log.TraceInformation(nilnul.txt.op_.unary_.RepeatX.Repeat("-", 20));
						log.TraceInformation("\t");
						log.TraceInformation($"deleting:{y}");
						nilnul.fs.file.del_._RecyclableX.Del(y);
						log.TraceInformation("\t");
						log.TraceInformation($"deleted:{y}");
						log.TraceInformation("\t");
						log.TraceInformation($"creating link: {y} -> {kept}");

						nilnul.fs.file_.link_.hard._CreateX.Create(
							y.file.en
								,
							kept

						);
						log.TraceInformation("\t");
						log.TraceInformation($"created link: {y} -> {kept}");
						log.TraceInformation(nilnul.txt.op_.unary_.RepeatX.Repeat("-", 20));
						log.TraceInformation("");

					}
				);
			}

		}


	}
}

