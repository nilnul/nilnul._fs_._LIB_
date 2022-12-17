using nilnul.fs._address;
using nilnul.fs._address.route_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield_
{
	public class BasedDirectory :
		ShieldA
	//,
	//ShieldI
	{
		private ShieldI _basis;

		public ShieldI basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private nilnul.fs._address.DirectoryI _descendent;

		public nilnul.fs._address.DirectoryI descendent
		{
			get { return _descendent; }
			set { _descendent = value; }
		}

		public override VolI vol => _basis.vol;


		public override StemI stem => new nilnul.fs._address.route_.stem_.ParentDiv1(
				_basis.stem.div
				,
				_descendent

		);

		public BasedDirectory(ShieldI container, nilnul.fs._address.DirectoryI div)
		{
			_basis = container;
			_descendent = div;
		}


		public BasedDirectory(VolI vol, IEnumerable<DirI> enumerable)
			: this(
				 new shield_.Vol1(vol), new nilnul.fs._address.Directory(enumerable)
			 )
		{

		}
		public BasedDirectory(AddressI en, IEnumerable<DirI> enumerable):this( nilnul.fs.address_.Shield.Ov(en), new nilnul.fs._address.Directory(enumerable))
		{
		}

		public BasedDirectory(ShieldI en, IEnumerable<Dir> enumerable):this(
			en
			,
			enumerable.Select(d=>(DirI)d)
		)
		{
		}


		

		public BasedDirectory(ShieldI en, DocumentI key) : this(
			en
			,
			_address.directory_._DocumentX.Exe(key)
		)
		{
		}



		public override string ToString()
		{
			return $"{_basis}{_descendent}";
		}

		static public BasedDirectory Of_directoryOfDnts(
			nilnul.fs.AddressI basis
			,
			IEnumerable<string > dnts
		) {

			return new BasedDirectory(basis, dnts.Select(d=>  Dir.OvDenote(d)));

		}

		static public BasedDirectory Of_directoryOfDnts(nilnul.fs.AddressI basis, params string[] dnts) {

			return Of_directoryOfDnts(basis, dnts as IEnumerable<string> );

		}




	}
}
