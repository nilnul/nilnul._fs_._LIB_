using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.split_
{
	static public class _ThinToeX

	{
		/// <summary>
		/// 
		/// </summary>
		/// val:
		///		slice
		public const string NOM = "part";
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

			);  //this may result: _abc3_1

			///this must be positive,as size > bytesBounding.
			///
			var mainCount = nilnul.num_.positive.co.op_.to_.divide_._RemainderNonnilX._RemainderNonnil_assumePositives(size, bytesBounding, out long remained);
	

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
								$"{NOM}{i}"
							)
						))
						{
							var reaminedToRead = bytesBounding;
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
							$"{NOM}{i}"
						)
					))
					{

						var reaminedToRead = remained;
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

		public static nilnul.fs.Folder1 _Folder0nul_assumeFile_assumePositive(string path, long v)
		{
			return _Folder0nul_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1.Parse(path), v);

		}

		static public nilnul.fs.Folder1 _Folder0nul_Split1drop_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1 file, long bytesBounding)
		{

			var f = _Folder0nul_assumeFile_assumePositive(file, bytesBounding);
			if (!(f is null))
			{
				nilnul.fs.file.drop_._RecyclableX.RecycleIfFile(file);
			}
			return f;



		}

		static public Folder1 _Folder0nul_Split1drop_assumeFile_assumePositive(string file, long bytesBounding)
		{

			return _Folder0nul_Split1drop_assumeFile_assumePositive(nilnul.fs.address_.spear_.based_.Child1.Parse(file), bytesBounding);




		}

		public static Folder1 _Folder0nul_Split1drop_assumeFile_assumePositive(FileInfo d, long size)
		{
			return _Folder0nul_Split1drop_assumeFile_assumePositive(d.FullName, size);

		}
	}
}
