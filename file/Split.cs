using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file
{
	static public class _SplitX

	{
		static public nilnul.fs.Folder1 _Folder0nul_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1 file, long bytesBounding)
		{
			const int bufferSize = 1024 * 4;

			//var newest = nilnul.fs.folder.dir_.vered_.newest._EnsureEmptyX.Folder(
			//	file.parent
			//	,
			//	$"_{file.dnt}_"

			//);

			var path = file.ToString();
			var info = new System.IO.FileInfo(path);

			var size = info.Length;
			if (size <= bytesBounding)
			{
				return null;
			}

			var newest = nilnul.fs.folder.dnt_.vered_.next._CreateFolderX.Folder_ofName(
				file.parent
				,
				$"_{file.dnt}_"

			);
			///this must be positive,as size > bytesBounding.
			///
			var floorOfCount = (int)Math.DivRem(size, bytesBounding, out long remained);

			long mainPartSize;
			long remained4lastPart;
		//	int countNormalized;
			int mainCount;
			if (remained == 0)
			{
				mainPartSize = bytesBounding;
				remained4lastPart = bytesBounding;

				mainCount = floorOfCount - 1;
				//countNormalized = floorOfCount;

			}
			else
			{
				mainCount = floorOfCount;
			var	countNormalized = floorOfCount + 1;

				mainPartSize = Math.DivRem(
					size, mainCount+1, out remained4lastPart
			   );

			}


			using (var fs = info.OpenRead())
			{
				using (var reader = new System.IO.BinaryReader(fs))
				{
					int i = 0;
					for (; i < mainCount; i++)
					{

						using (var writer = System.IO.File.Create(
							Path.Combine(
								newest.ToString()
								,
								$"part{i}"
							)
						))
						{
							var reaminedToRead = mainPartSize;
							var nextRead = (int)Math.Min(bufferSize, reaminedToRead);
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
								nextRead = (int)Math.Min(bufferSize, reaminedToRead);

							}
							//writer.Flush();
							//As soon as you leave the using block’s scope, the stream is closed and disposed. The Close() calls the Flush(), so you should not need to call it manually.
						}

					}

					using (var writer = System.IO.File.Create(
						Path.Combine(
							newest.ToString()
							,
							$"part{i}"
						)
					))
					{

						var reaminedToRead = remained4lastPart;
						var nextRead = (int)Math.Min(bufferSize, reaminedToRead);

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
							nextRead = (int)Math.Min(bufferSize, reaminedToRead);

						}

					}




				}

			}

			return newest;



		}

		public static nilnul.fs.Folder1 _Folder0nul_assumeFile_assumePositive(string path, int v)
		{
			return _Folder0nul_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1.Parse(path), v);

		}

		static public nilnul.fs.Folder1 _Folder0nul_Split1drop_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1 file, int bytesBounding)
		{

			var f = _Folder0nul_assumeFile_assumePositive(file, bytesBounding);
			if (!(f is null))
			{
				nilnul.fs.file.drop_._RecyclableX.RecycleIfFile(file);
			}
			return f;



		}

		static public Folder1 _Folder0nul_Split1drop_assumeFile_assumePositive(string file, int bytesBounding)
		{

			return _Folder0nul_Split1drop_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1.Parse(file), bytesBounding);




		}




	}
}
