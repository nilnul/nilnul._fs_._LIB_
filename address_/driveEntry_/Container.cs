using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.driveEntry_
{
	public class Container:ContainerI
	{
		private nilnul.fs.address_._driveEntry_.Drive _drive;

		public nilnul.fs.address_._driveEntry_.Drive drive
		{
			get { return _drive; }
			set { _drive = value; }
		}

		private nilnul.fs.address_._driveEntry_.entry_.Container _entry;

		public nilnul.fs.address_._driveEntry_.entry_.Container entry
		{
			get { return _entry; }
			set { _entry = value; }
		}

		public Container(
			nilnul.fs.address_._driveEntry_.Drive drive
			,
			nilnul.fs.address_._driveEntry_.entry_.Container entry

		)
		{
			_drive = drive;
			_entry = entry;


		}

		static public Container Parse(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
		{

			return new Container(
				 _driveEntry_.Drive.Parse(s.processed.Substring(0, 2))
					
				, nilnul.fs.address_._driveEntry_.entry_.Container.Parse(s.processed.Substring(2))
				
			);


		}

		static public Container CreateFroContainerDirectory(
			Container container
			,
			nilnul.fs._address.Dsts dsts
			
		) {
			return new Container(
				container.drive
				,
				new _driveEntry_.entry_.Container(
					new _address.Dsts(
						container.entry.dsts.Concat(dsts)
					)
				)
			);
		}


	static public Container CreateFroContainerDirectory(
			Container container
			,
			nilnul.fs.address_._driveEntry.Directory directory
			
		) {
			return new Container(
				container.drive
				,
				new _driveEntry_.entry_.Container(
					new _address.Dsts(
						container.entry.dsts.Concat(directory.dsts)
					)
				)
			);
		}



		static public Container Parse(string s)
		{

			return Parse( new nilnul.txt.op_.trim.ed_.WhiteTrimmed(s));


		}
		public override string ToString()
		{
			return $"{_drive}{_entry}";
		}
	}
}
