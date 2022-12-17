namespace nilnul.fs._address.dir.cast_
{
#pragma warning disable CS0618 // 'ParRet<DirI, DocI>' is obsolete: 'RetI'
	public class Doc : nilnul.obj._cast_.ParRet<DirI, DocI>
#pragma warning restore CS0618 // 'ParRet<DirI, DocI>' is obsolete: 'RetI'
	{
		public DocI op(DirI par)
		{
			return new _address.Doc(par.denote);
			//throw new NotImplementedException();
		}


		static public Doc Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Doc>' is obsolete
				return nilnul._obj.Singleton<Doc>.Instance;
#pragma warning restore CS0612 // 'Singleton<Doc>' is obsolete
			}
		}

	}

}
