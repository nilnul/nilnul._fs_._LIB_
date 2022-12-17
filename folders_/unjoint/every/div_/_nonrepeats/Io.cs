using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs.address_.shield;
using nilnul.fs.address_;
using nilnul.fs.folder.be;
using nilnul.obj.str;
using nilnul.fs;
using System.IO;


namespace nilnul.fs.folders_.unjoint.every.div_._nonrepeats
{


	/// <summary>
	/// </summary>
	public class Io
	{



		private CancellationToken _cancel;
		public CancellationToken cancel
		{
			get { return _cancel; }
			set { _cancel = value; }
		}

		

		private StreamWriter _log;

		public StreamWriter log
		{
			get { return _log; }
			set { _log = value; }
		}



		/// <summary>
		/// including the src top. as the computing of eventual target is time-consuming, and we better compute it in advance.
		/// the key is destiny; the val is the src.
		/// </summary>
		private ConcurrentDictionary<nilnul.fs.AddressI,
			//nilnul.fs.address_.shield_.BaseDiv
			nilnul.fs.address_.ShieldI
			> _destinySrc = new ConcurrentDictionary<AddressI, ShieldI>();

		public ConcurrentDictionary<
			nilnul.fs.AddressI
			,
			//nilnul.fs.address_.shield_.BaseDiv
			nilnul.fs.address_.ShieldI

			> destinySrc
		{
			get { return _destinySrc; }
			set { _destinySrc = value; }
		}

		object _destinyLock = new object();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="destiny"></param>
		/// <param name="link"></param>
		/// <returns>
		///		old entry with the given key. this old entry is null or valued.
		/// </returns>
		public KeyValuePair<AddressI, address_.ShieldI> addDestiny(
			nilnul.fs.AddressI destiny
			,
			nilnul.fs.address_.ShieldI link
		)
		{
			lock (_destinyLock)
			{
				var joint = _destinySrc.Where(
					k => nilnul.fs.address.re_.Joint.Singleton.re(destiny, k.Key)
				).FirstOrDefault();

				if (
					joint.Key is null  //it's a struct
				)
				{
					_destinySrc.TryAdd(destiny, link);
					return joint;
				}
				else
				{
					return joint;
				}
			}
		}

		internal KeyValuePair<AddressI, address_.ShieldI> _addDestiny_assumeLink(ShieldI en)
		{
			return addDestiny(
				nilnul.fs.folder_.link_.sym._DestinyX.Normal(en).en.address.en
				,

				en

			);
		}

		private KeyValuePair<AddressI, address_.ShieldI> _addDestiny_assumeLink(AddressI f1)
		{
			return _addDestiny_assumeLink(nilnul.fs.address_.shield_._AddressX1.Create(f1));
		}


		internal KeyValuePair<AddressI, address_.ShieldI> _addDestiny_addressAssumeLink(string en)
		{
			return _addDestiny_assumeLink(nilnul.fs.address_.Shield.FroAddress(en));
		}


		static public Io Of_removeNonfolder(
			IEnumerable<nilnul.fs.address_.ShieldI> addresses

		)
		{

			return new Io(
				 address_.shields_.Disjoint.FroUnsured(
					 addresses.Where(a => nilnul.fs.address_.shield.be_.Folder.Singleton.be(a))
				)
				,
				default



			);
		}
		static public Io Of_removeNonfolder(
			IEnumerable<nilnul.fs.address_.ShieldI> addresses
			,
			StreamWriter log

		)
		{

			return new Io(
				 address_.shields_.Disjoint.FroUnsured(
					 addresses.Where(a => nilnul.fs.address_.shield.be_.Folder.Singleton.be(a))
				)
				,
				default
				,
				log



			);
		}

		static public Io OfAddresses_removeNonfolder(
			IEnumerable<string> addresses

		)
		{

			return Of_removeNonfolder(

					 addresses.Select(a => nilnul.fs.address_.Shield.FroAddress(a))


			);
		}

		public static Io OfAddresses_removeNonfolder(IEnumerable<string> addresses, StreamWriter log)
		{
			return Of_removeNonfolder(

					 addresses.Select(a => nilnul.fs.address_.Shield.FroAddress(a))
				,
					 log

			);

			//throw new NotImplementedException();
		}


		public Io(

			nilnul.fs.address_.shields_.Disjoint shields2traverse

			,
			CancellationToken cancel
	
		)
		{


			/// we treat src_.folder_.nonlink specially due to that:
			///	 it's the topmost. each nontop dir can consider only itself as all the ancesters have been tackled. but for topmost src, it should self-complete its status as a tree.
			shields2traverse.ee.Each(
				f1 =>
				{
					if (nilnul.fs.address.be_.Folder.Singleton.be(f1))
					{
						if (
nilnul.fs.folder.BeIX.Be(nilnul.fs.folder.be_.link_.Sym.Singleton, f1)
						)
						{
							var old = this._addDestiny_assumeLink(
								f1
							);
							if (old.Key is null)
							{
							}
							else
							{
								throw new Exception($"{f1}'s target is joint with {old.Value}'s target {old.Key}");
							}
						}
						else
						{
							this.addDestiny(
								f1, nilnul.fs.address_.shield_._AddressX1.Create(f1)
							);
						}

					}
					else
					{
						throw new Exception();
						Trace.TraceError($"{f1} as a src is not a folder");
					}


				}
			);




			_cancel = cancel;

		}

		public Io(

			nilnul.fs.address_.shields_.Disjoint shields2traverse

			,
			CancellationToken cancel
			,
			StreamWriter log
	

		)
		{


			/// we treat src_.folder_.nonlink specially due to that:
			///	 it's the topmost. each nontop dir can consider only itself as all the ancesters have been tackled. but for topmost src, it should self-complete its status as a tree.
			shields2traverse.ee.Each(
				f1 =>
				{
					if (nilnul.fs.address.be_.Folder.Singleton.be(f1))
					{
						if (
nilnul.fs.folder.BeIX.Be(nilnul.fs.folder.be_.link_.Sym.Singleton, f1)
						)
						{
							var old = this._addDestiny_assumeLink(
								f1
							);
							if (old.Key is null)
							{
							}
							else
							{
								throw new Exception($"{f1}'s target is joint with {old.Value}'s target {old.Key}");
							}
						}
						else
						{
							this.addDestiny(
								f1, nilnul.fs.address_.shield_._AddressX1.Create(f1)
							);
						}

					}
					else
					{
						throw new Exception();
						Trace.TraceError($"{f1} as a src is not a folder");
					}


				}
			);




			_cancel = cancel;
			this._log = log;

		}





	}
}


