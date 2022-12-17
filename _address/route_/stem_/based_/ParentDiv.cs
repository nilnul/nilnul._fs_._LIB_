namespace nilnul.fs._address.route_.stem_.based_
{
	public class BasedDiv :
		StemA1
	//,
	//StemI1
	{

		private StemI1 _stem;

		public StemI1 stem
		{
			get { return _stem; }
			set { _stem = value; }
		}
		private _address._route.division_.DivI _descendent;



		public override _address._route.division_.DivI div => _address._route.division_.div.op_.binary_.Concat.Singleton.op(_stem.div, _descendent);


		public BasedDiv(StemI1 stem, _address._route.division_.DivI div)
		{
			_stem = stem
				;
			_descendent = div;
		}

		public BasedDiv(nilnul.fs._address._route.division_.DivI div, _address._route.division_.DivI dir)
		   : this(
				new Stem1(
				   div
			   )
			   ,
			   (dir)
				)
		{

		}















		public override string ToString()
		{
			return $"{_stem}{_descendent}";
		}



	}
}
