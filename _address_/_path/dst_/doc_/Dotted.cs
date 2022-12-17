using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.fs._address_._path.dst_.doc_
{
	/// <summary>
	/// name and ext
	/// </summary>
	public  class Dotted
		:
		DocA,
		DocI
	{


		public const char Seperator='.';
		public _dotted.Main mainMember;
		public _dotted.Ext extMember;

		public override string main
		{
			get
			{
				return mainMember.name;
				//throw new NotImplementedException();
			}
		}

		public override string ext
		{
			get
			{
				return extMember.name;
				//throw new NotImplementedException();
			}
		}

		public Dotted(_dotted.Main name,
		  _dotted.Ext extMember
			)
		{
			this.mainMember = name;
			this.extMember = extMember;
		}

		public Dotted(string main, string ext)
			:this(
				new _dotted.Main(main)
				 ,
				new _dotted.Ext(ext) 
			)
		{

		}

		public override string ToString()
		{
			return $"{mainMember}.{ext}";
		}

		static public Dotted Parse(string main, string ext) {

			return new Dotted(
				new _dotted.Main(main)
				,
				new _dotted.Ext(ext)	
			);
		}

		


	}
}
