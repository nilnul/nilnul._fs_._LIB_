using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.fs._address._dst.name.be_.valid;
using nilnul.fs._address.doc_._dotted;

namespace nilnul.fs._address.doc_
{
	/// <summary>
	/// name and ext
	/// </summary>
	/// 
	[Obsolete()]
	public  class Dotted1
		:
		DocA1
		,
		DottedOrNoI
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

		public override En name => new En(main+"."+ext);

		public Dotted1(_dotted.Main name,
		  _dotted.Ext extMember
			)
		{
			this.mainMember = name;
			this.extMember = extMember;
		}



		public Dotted1(string main, string ext)
			:this(
				new _dotted.Main(main)
				 ,
				new _dotted.Ext(ext) 
			)
		{

		}
		public Dotted1(_dotted.Main main, string ext)
			:this(
				main
				 ,
				new _dotted.Ext(ext) 
			)
		{

		}

		public Dotted1(string docMain, Ext ext1):this(new Main(docMain),ext1)
		{
		}

		public override string ToString()
		{
			return $"{mainMember}.{ext}";
		}

		static public Dotted1 Parse(string main, string ext) {

			return new Dotted1(
				new _dotted.Main(main)
				,
				new _dotted.Ext(ext)	
			);
		}


		static public Dotted1 Parse(string all) {

			var split = all.LastIndexOf('.');
			return Parse(all.Substring(0,split) , all.Substring(split +1));
		}

		


	}
}
