// Generated by sprotodump. DO NOT EDIT!
// source: sproto/map.sproto

using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType { 
	public class cs_map_choose {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 3;
			
			
			private Int64 _flag; // tag 0
			public Int64 flag {
				get { return _flag; }
				set { base.has_field.set_field (0, true); _flag = value; }
			}
			public bool HasFlag {
				get { return base.has_field.has_field (0); }
			}

			private string _info; // tag 2
			public string info {
				get { return _info; }
				set { base.has_field.set_field (1, true); _info = value; }
			}
			public bool HasInfo {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.flag = base.deserialize.read_integer ();
						break;
					case 2:
						this.info = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.flag, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.info, 2);
				}

				return base.serialize.close ();
			}
		}


	}


	public class sc_map_enter {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private Int64 _map_id; // tag 0
			public Int64 map_id {
				get { return _map_id; }
				set { base.has_field.set_field (0, true); _map_id = value; }
			}
			public bool HasMap_id {
				get { return base.has_field.has_field (0); }
			}

			private string _point; // tag 1
			public string point {
				get { return _point; }
				set { base.has_field.set_field (1, true); _point = value; }
			}
			public bool HasPoint {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.map_id = base.deserialize.read_integer ();
						break;
					case 1:
						this.point = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.map_id, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.point, 1);
				}

				return base.serialize.close ();
			}
		}


	}


}

