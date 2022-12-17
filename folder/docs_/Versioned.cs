using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_.started._aggregate;
using System.IO;

namespace nilnul.fs.location_.folder.docs_
{
	public class Versioned
	{

		public nilnul.fs.location_.Folder _folder
		;
		public nilnul.fs.location_.Folder folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Versioned(
			nilnul.fs.location_.Folder folder	
		)
		{
			_folder = folder;
		}

		public string _getLatestFile_assertExists(string prefix)
		{
			var versionedFiles = getLocations(prefix);

			return versionedFiles._MaxBy_byAggregate(
									file => file.avowed.doc.ToString()
									,
									nilnul.txt.versioned.ComparerOfTxt.Singleton

			).ToString();
		}

		public nilnul.fs.File _getLatestFileLocation_assertExists(string prefix)
		{
			var versionedFiles = getLocations(prefix);

			return versionedFiles._MaxBy_byAggregate(
									file => file.avowed.doc.ToString()
									,
									nilnul.txt.versioned.ComparerOfTxt.Singleton

			);
		}


		public void ensureLatestFile_newUseTimestamp(string prefix)
		{
			var versionedFiles = getAddressTxts(prefix);

			if (versionedFiles.Any())
			{
				//return new StreamWriter(   versionedFiles._MaxBy_byAggregate(
				//	file=>  file.Name
				//	,
				//	nilnul.txt.versioned.ComparerOfTxt.Singleton

				//).FullName);
			}
			else
			{
				createTimedChildFile_close(prefix);

			}


		}

		public StreamWriter createTimedChildFile(string prefix)
		{
			return System.IO.File.CreateText(
				Path.Combine(
				_folder.ToString()

				,
				prefix +
				nilnul.time.to.Txt.ToTxtFull()
			)

				  );
		}
		public void createTimedChildFile_close(string prefix)
		{
			System.IO.File.Create(
			   Path.Combine(
			   _folder.ToString()

			   ,
			   prefix +
			   nilnul.time.to.Txt.ToTxtFull()
		   )

				 ).Dispose();
		}


		public string getEnsuredLatestFile(string prefix)
		{
			ensureLatestFile_newUseTimestamp(prefix);
			return _getLatestFile_assertExists(prefix);
		}
		public location_.File getEnsuredLatestLocation(string prefix)
		{
			ensureLatestFile_newUseTimestamp(prefix);
			return _getLatestFileLocation_assertExists(prefix);
		}

		public IEnumerable<string> getAddressTxts(string prefix)
		{

			return Directory.EnumerateFiles(_folder.ToString()).Where(
				x => nilnul.txt.Versioned.IsVersioned(prefix,  System.IO.Path.GetFileName( x))
			);

		}

		public IEnumerable<location_.File> getLocations(string prefix)
		{

			return Directory.EnumerateFiles( _folder.ToString()).Select( f=> location_.File.Parse(f) ).Where(
				x => nilnul.txt.Versioned.IsVersioned(prefix, x.avowed.doc.ToString())
			);

		}



	}
}
