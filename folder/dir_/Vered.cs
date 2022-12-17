using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.slider.to;
using nilnul.txt;
using nilnul.str;
using nilnul.str_.started;
using N = nilnul._num.bigint.be.Natural.Asserted;
using nilnul.fs.address_;
using nilnul.txt_._vered;

namespace nilnul.fs.folder.dir_
{

	/// <summary>
	/// 
	/// </summary>
	public class Vered
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.Folder _folder
;
		public nilnul.fs.Folder folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Vered(
			nilnul.fs.Folder folder
		)
		{
			_folder = folder;
		}




		public Vered(string address) : this(
			 Folder.FroAddress(
			address)

			)
		{
		}

		public Vered(ShieldI parent) : this(new Folder(parent))
		{
		}

		public DirectoryInfo getDirInfo()
		{
			{ return new DirectoryInfo(_folder.ToString()); }
		}



		public DirectoryInfo createNextDir(string prefix)
		{

			return getDirInfo().CreateSubdirectory(

				fs.folder.denote_.vered_.next_._SubIfNeedX.Stub(this.folder, prefix)
			//dsts.Ver(this.folder)
			//.getNextChildVerName(prefix)	
			)
		;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="nom">nom</param>
		/// <returns></returns>
		public IEnumerable<DirectoryInfo> getVersioned(string nom)
		{

			return getDirInfo().EnumerateDirectories().Where(
				x => nilnul.txt.Versioned1.IsVersioned(nom, x.Name)
			);

		}
		public nilnul.fs.address_.ShieldI shield_ensureDir(nilnul.txt_.Vered2 prefix)
		{
			var lastestOrDefault = veredNulableLatest(prefix)
			;
			if (lastestOrDefault is null)
			{
				var num = nilnul.fs.folder.denote_.vered_._NextX.Num(this.folder, prefix);

				var denote = new nilnul.txt_.Vered2(prefix.name, num).ToString();

				var shield = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(this.folder.address.en, denote);

				System.IO.Directory.CreateDirectory(
				 shield.ToString());
				return shield;

			}
			var shield1 = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(this.folder.address.en, lastestOrDefault);
			return shield1;



		}

		public nilnul.fs.address_.ShieldI shield_ensureDir_ofVered(string prefix)
		{
			return shield_ensureDir(
			 nilnul.txt_.Vered2.Parse(prefix)
			);
		}


		private ShieldI shield_ensureDir(Name prefix)
		{
			var lastestOrDefault = numNulableLatest(prefix)
				;
			if (lastestOrDefault is null)
			{
				var num = nilnul.fs.folder.denote_.vered_._NextX.Num(this.folder, prefix);

				var denote = new nilnul.txt_.Vered2(prefix, num).ToString();

				var shield = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(this.folder.address.en, denote);

				System.IO.Directory.CreateDirectory(
				 shield.ToString());
				return shield;

			}
			var shield1 = nilnul.fs.address_.shield_.BaseDir.Create_dirDenote(this.folder.address.en,
			prefix.ToString()+
			nilnul.num.phrase_._DecX.Phrase(
			new Num(

			lastestOrDefault.toBigint())
			)
			);
			return shield1;
		}
		public nilnul.fs.address_.ShieldI shield_ensureDir_ofNom(string prefix)
		{
			return shield_ensureDir(
			 nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(prefix)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix">as prefix</param>
		/// <returns></returns>
		public IEnumerable<txt.Versioned1> getVersionedChildFolders_retVersions(string prefix)
		{

			return getDirInfo().EnumerateDirectories().Select(x => x.Name).Select(x => nilnul.txt.Versioned1.Parse(x)
			).Where(y => y.prefix == prefix);

		}


		public IEnumerable<txt_.Vered2> vereds(nilnul.txt_.Vered2 vered)
		{

			return getDirInfo().EnumerateDirectories().Select(x => x.Name).Select(x => nilnul.txt_.Vered2.Parse(x)
			).Where(
				y => nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(y.name, vered.name)
				&&
				y.version.toBigint().en >= vered.num.toBigint().en
			);

		}


		public IEnumerable<nilnul.NumI1> nums(nilnul.txt_._vered.Name vered)
		{

			return getDirInfo().EnumerateDirectories().Select(x => x.Name).Select(x => nilnul.txt_.Vered2.Parse(x)
			).Where(
				y => nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(y.name, vered)
				
			).Select(z=>z.num);

		}


		public IEnumerable<Tuple<DirectoryInfo, N>> getVersionedChildFolders_retTuple(string prefix)
		{

			return getDirInfo().EnumerateDirectories().Select(

				x => new Tuple<DirectoryInfo, N>(
					x
					,
					nilnul.txt.Versioned.GetVersion(x.Name)
				)
			);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="prefix">assume prefix</param>
		/// <returns>nulable</returns>
		public Versioned1 getChildFolderLatest(string prefix)
		{

			return nilnul.txt.versioned.Set.GetLatestOrDefault(
				getVersionedChildFolders_retVersions(prefix)
			);

		}


		public nilnul.txt_.Vered2 veredNulableLatest(nilnul.txt_.Vered2 prefix)
		{

			return nilnul.txt_.vereds.NewestOrDefaultX.Vered(
				vereds(prefix)
			);

		}

		public nilnul.txt_.Vered2 veredNulableLatest_ofVered(string prefix)
		{

			return veredNulableLatest(
				 txt_.Vered2.Parse(prefix)
			);

		}

		public nilnul.NumI1 numNulableLatest(nilnul.txt_._vered.Name prefix)
		{

			return nilnul.objs._MaxOrDefaultX.Max(
				nums(prefix)
				,
				nilnul.num.Comparer2.Singleton
			);

		}


		/// <summary>
		/// nulable
		/// </summary>
		/// <param name="prefix"></param>
		/// <returns></returns>
		public DirectoryInfo getChildFolderLatest_retFolder(string prefix)
		{

			return getVersionedChildFolders_retTuple(prefix)
				.MaxBy_byAggregate(
					x => x.Item2
					,
					nilnul.num.Comparer1.Instance
			)?.Item1;
		}


		public nilnul.txt.Versioned1 _getLatest_assertExists(string prefix)
		{
			var versionedFiles = getVersionedChildFolders_retVersions(prefix);

			return versionedFiles._MaxBy_byAggregate(
									file => new nilnul._num.bigint.be.Natural.Asserted(file.version)
									,
									nilnul.num.Comparer1.Instance

			);
		}

		public DirectoryInfo _getLatest_assertExists_retDirInfo(string prefix)
		{
			var versionedFiles = getVersioned(prefix);

			return versionedFiles._MaxBy_byAggregate(
									file => file.Name
									,
									nilnul.txt.versioned.ComparerOfTxt.Singleton

			);
		}




	}
}
