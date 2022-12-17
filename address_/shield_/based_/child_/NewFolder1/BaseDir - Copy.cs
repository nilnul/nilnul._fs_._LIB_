using nilnul.fs._address;
using nilnul.fs._address._dst;
using nilnul.fs._address.route_;
using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	public class BaseDir : ShieldI
	{
		private ShieldI _parent;

		public ShieldI parent
		{
			get { return _parent; }
			set { _parent = value; }
		}

		private nilnul.fs._address.DirI _child;

		public nilnul.fs._address.DirI child
		{
			get { return _child; }
			set { _child = value; }
		}


		public VolI vol => _parent.vol;

		public RouteI route => stem;
		public StemI stem => new nilnul.fs._address.route_.stem_.ParentDir(

				_parent.stem
				,
				_child

		);
		public static BaseDir Create_dirDenote(DirectoryInfo tmpSub, string v)
		{
			return new BaseDir(tmpSub, nilnul.fs._address.Dir.OvDenote(v));
			//throw new NotImplementedException();
		}

		public BaseDir(ShieldI container, nilnul.fs._address.DirI div)
		{
			_parent = container;
			_child = div;
		}
		public BaseDir(ShieldI parent, Denote newName) : this(parent, new nilnul.fs._address.Dir(newName))
		{

		}
		public BaseDir(ShieldI shield, nilnul.fs._address.Dir name) : this(shield, (nilnul.fs._address.DirI)name)
		{

		}


		public BaseDir(ShieldI shield, DocI doc) : this(
			shield, new nilnul.fs._address.Dir(doc)
		)
		{

		}

		public BaseDir(DirectoryInfo tmpSub, Dir dir2) : this((nilnul.fs.address_.Shield)tmpSub, dir2)
		{

		}
		public BaseDir(DirectoryInfo basis, DirI dir):this( (nilnul.fs.address_.Shield)basis, dir  )
		{
		}

		public BaseDir(AddressI shield, Denote name):this(nilnul.fs.address_.shield_._AddressX1.Create(shield),name)
		{
		}

		public BaseDir(AddressI shield, DirI name):this( nilnul.fs.address_.shield_._AddressX1.Create(shield),name)
		{
		}


		public static BaseDir Create_dirDenote(ShieldI shield, string name)
		{
			return new BaseDir(shield, nilnul.fs._address.Dir.OvDenote(name));
			//throw new NotImplementedException();
		}

		public static BaseDir Create_dirOfDenote(AddressI shield, string name)
		{
			return new BaseDir(shield,(DirI) nilnul.fs._address.Dir.OvDenote(name));
			//throw new NotImplementedException();
		}


		public static BaseDir Create_ofDirInDst(ShieldI sourceParent, string sourceDir)
		{
			return new BaseDir( sourceParent,  nilnul.fs._address.Dir.OvDst(sourceDir));
		}


		public static BaseDir Create__parentAddress_dirName(string tmpSub, string v)
		{
			return new BaseDir(nilnul.fs.address_.shield_._AddressX1.Create(tmpSub), nilnul.fs._address.Dir.OvDenote(v));
			//throw new NotImplementedException();
		}



		public override string ToString()
		{
			return $"{_parent}{_child}";
		}

		static public BaseDir OfContainerAddress_DirDst(string containerAddress, string dst)
		{
			return new BaseDir(
				 nilnul.fs.address_.Shield.FroAddress(containerAddress)
				 ,
				 nilnul.fs._address.Dir.OvDst(dst)
			);
		}


		static public BaseDir _Ov(ShieldI shield)
		{
			var stem = shield.stem;

			return new BaseDir(
				 new Shield(shield.vol, stem.div.dirs.Take(stem.div.dirs.Count() - 1))
				 ,
				 stem.div.dirs.Last()
			);
		}
		[Obsolete(nameof(_Ov))]
		static public BaseDir _Fro(ShieldI shield)
		{
			return _Ov(shield);
		}



		static public BaseDir FroAddress(string shield)
		{

#pragma warning disable CS0618 // 'BaseDir._Fro(ShieldI)' is obsolete: '_Ov'
			return _Fro(nilnul.fs.address_.shield_._AddressX1.Create(shield));
#pragma warning restore CS0618 // 'BaseDir._Fro(ShieldI)' is obsolete: '_Ov'
		}



	}
}
