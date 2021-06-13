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
		internal static ushort ReadAsU16(BytePointer p, long pos) {
			return lz4.LZ4_read16(CopyPtr(p, pos * 2));
		}
		internal static uint ReadAsU32(BytePointer p, long pos) {
			return lz4.LZ4_read32(CopyPtr(p, pos * 4));
		}
		internal static ulong ReadAsU64(BytePointer p, long pos) {
			return lz4.LZ4_read64(CopyPtr(p, pos * 8));
		}
		internal static void WriteAsU16(BytePointer p, long pos, ushort value) {
			lz4.LZ4_write16(CopyPtr(p, pos * 2), value);
		}
		internal static void WriteAsU32(BytePointer p, long pos, uint value) {
			lz4.LZ4_write32(CopyPtr(p, pos * 4), value);
		}
		internal static void WriteAsU64(BytePointer p, long pos, ulong value) {
			lz4.LZ4_write64(CopyPtr(p, pos * 8), value);
		}
	}

	internal class BytePointer {
		public byte[] Data;
		public long Offset;
		public byte Deref { get { return Data[Offset]; } }
	}
}
