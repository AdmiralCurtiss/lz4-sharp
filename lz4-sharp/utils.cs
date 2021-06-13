using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lz4_sharp {
	internal static class utils {
		internal static BytePointer CopyPtr(BytePointer ptr) {
			if (ptr == null) return null;
			return new BytePointer() { Data = ptr.Data, Offset = ptr.Offset };
		}
		internal static BytePointer CopyPtr(BytePointer ptr, long offset) {
			if (ptr == null) return null;
			return new BytePointer() { Data = ptr.Data, Offset = ptr.Offset + offset };
		}
		internal static BytePointer CopyPtr(BytePointer ptr, ulong offset) {
			if (ptr == null) return null;
			return new BytePointer() { Data = ptr.Data, Offset = ptr.Offset + (long)offset };
		}
	}

	internal class BytePointer {
		public byte[] Data;
		public long Offset;
		public byte Deref { get { return Data[Offset]; } }
		public byte DerefPostIncrement { get { return Data[Offset++]; } }
	}
}
