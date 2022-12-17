using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.split_
{
	static public class _Stream2streamX

	{
		static public void _Split_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1 file, int bytesBounding)
		{

			//var newest = nilnul.fs.folder.dir_.vered_.newest._EnsureEmptyX.Folder(
			//	file.parent
			//	,
			//	$"_{file.dnt}_"

			//);
			var newest = nilnul.fs.folder.dnt_.vered_.newest_._folder._EnsureNewestBeFolderX.Folder_ofNom(
				file.parent
				,
				$"_{file.dnt}_"

			);

			var path = file.ToString();
			var info = new System.IO.FileInfo(path);

			var size = info.Length;
			if (size==0)
			{
				return;
			}

			var floorOfCount = Math.DivRem(size, bytesBounding, out long remained);
			var countNormalized = remained == 0 ? floorOfCount : floorOfCount + 1;

			var eachSize = size / countNormalized;

			using (var fs = info.OpenRead())
			{
				using (var reader = new System.IO.BinaryReader(fs))
				{
					int i = 0;
					for (; i < floorOfCount; i++)
					{


						using (var writer = System.IO.File.Create(
							Path.Combine(
								newest.ToString()
								,
								$"part{i}"
							)
						))
						{

							var reaminedToRead = eachSize;
							var nextRead = (int)Math.Min(int.MaxValue, reaminedToRead);
							while (nextRead > 0)
							{
								writer.Write(
									reader.ReadBytes(
										nextRead
									)
									,
									0
									,
									nextRead

								);
								reaminedToRead -= nextRead;
								nextRead = (int)Math.Min(int.MaxValue, reaminedToRead);

							}
						}


					}
					if (remained > 0)
					{
						using (var writer = System.IO.File.Create(
							Path.Combine(
								newest.ToString()
								,
								$"part{i}"
							)
						))
						{
							var reaminedToRead = remained;
							var nextRead = (int)Math.Min(int.MaxValue, reaminedToRead);
							while (nextRead > 0)
							{
								writer.Write(
									reader.ReadBytes(
										nextRead
									)
									,
									0
									,
									nextRead

								);
								reaminedToRead -= nextRead;
								nextRead = (int)Math.Min(int.MaxValue, reaminedToRead);

							}
							
						}

					}


				}

			}





		}

		static public void _Split1drop_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1 file, int bytesBounding)
		{

			_Split_assumeFile_assumePositive(file, bytesBounding);

			nilnul.fs.file.drop_._RecyclableX.RecycleIfFile(file);



		}

		static public void _Split1drop_assumeFile_assumePositive(string file, int bytesBounding)
		{

			_Split_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1.Parse(file), bytesBounding);




		}


		static public void Split(nilnul.fs.FileI<nilnul.fs.address_.spear_.based_.Child1> file)
		{



		}

	}
}
