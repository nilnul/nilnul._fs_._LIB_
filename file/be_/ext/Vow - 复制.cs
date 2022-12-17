namespace nilnul.fs.file.be_.ext
{
	public class Vow :
		be.Vow<Vow>
		
	//nilnul.fs.file.VowI
	{
		//private nilnul.obj.vow_.true_.xpn_.Unacceptable _unacceptable;

		//public nilnul.obj.vow_.true_.xpn_.Unacceptable unacceptable
		//{
		//	get { return _unacceptable; }
		//	set { _unacceptable = value; }
		//}

		public Vow(string ext) : base(new Ext(ext))
		{

		}


		//private nilnul.fs.file.be_.Ext _be;

		//public nilnul.fs.file.be_.Ext be
		//{
		//	get { return _be; }
		//	set { _be = value; }
		//}


		public Vow(nilnul.fs._address.doc_._exted.ExtI ext) : base(new Ext(ext))
		{
			//_be = new Ext(ext);
			//_ext = ext;
		}
		//public void vow(FileI obj)
		//{
		//	_unacceptable.vow(
		//		_be.be(
		//			obj
		//		)
		//	);
		//}
	}
}
