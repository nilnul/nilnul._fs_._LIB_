using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_
{
	[Obsolete(nameof(VolRoute))]
	public class DriveEntry
	{
		private nilnul.fs.address_._driveEntry_.Drive _drive;

		public nilnul.fs.address_._driveEntry_.Drive drive
		{
			get { return _drive; }
			set { _drive = value; }
		}

		private nilnul.fs.address_._driveEntry_.EntryI _entry;

		public nilnul.fs.address_._driveEntry_.EntryI entry
		{
			get { return _entry; }
			set { _entry = value; }
		}

		public DriveEntry(
			nilnul.fs.address_._driveEntry_.Drive drive
			,
			nilnul.fs.address_._driveEntry_.EntryI entry
			
		)
		{
			_drive = drive;
			_entry = entry;


		}

		

		public override string ToString()
		{
			return $"{_drive}{_entry}";
		}

	}
}
