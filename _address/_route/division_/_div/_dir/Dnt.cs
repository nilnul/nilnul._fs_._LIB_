namespace nilnul.fs._address._route.division_._div._dir
{
	/// <summary>
	///in the form of a doc. for a folder, the doc is a denote exists on Disk. for an address, dont use Doc but Denote
	/// </summary>
	///
	public class Dnt 
		: nilnul.fs._address._route.division_._div._dir._dnt.txt.be_.valid.vow.En

		,
		DntI
	{
		public Dnt(string s)
			: base(s)
		{
		}

		public Dnt(string main, string ext) : this(main + ext)
		{

		}

		public Dnt(DstA dst) : base(dst.caption)
		{
		}

		public Dnt(DstI doc) : this(doc.caption)
		{
		}

		public Dnt(Dnt doc) : this(doc.en)
		{
		}


		public Dnt caption => this;


		static public Dnt Ov(IDnt dnt)
		{
			return dnt switch
			{

				Dnt doc => doc
				,
				_ => new Dnt(dnt.ToString())
			};
		}

		internal static Dnt Ov(DstA dst)
		{
			return dst switch
			{

				DirI doc => doc.caption
				,
				_ => new Dnt(dst.ToString())
			};

		}



		static public Dnt Ov(_dir.DntI dnt)
		{
			return dnt switch
			{

				Dnt doc => doc
				,
				_ => new Dnt(dnt.ToString())
			};

		}

	}


}
