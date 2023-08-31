using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SFSE
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CompressedChunkHeader
    {
        public Int32 Id;
        public Int16 Unk1;
        public Int32 CompressedSize;
        public Int16 Unk2;
        public Int32 UncompressedSize;
    }

    internal class CompressedSaveChunk
    {
        public CompressedChunkHeader Header;
        public Byte[] Data;

        static UInt16 HeaderSize = 16;

        public CompressedSaveChunk(FileStream fileStream)
        {
            byte[] rawHeader = new byte[HeaderSize];
            fileStream.ReadExactly(rawHeader);
            Header = Program.DeserializeValueType<CompressedChunkHeader>(rawHeader);
            Data = new Byte[Header.CompressedSize];
            fileStream.ReadExactly(Data);
        }

        public CompressedSaveChunk(DecompressedSaveChunk decompressedSaveChunk)
        {
            ZLibStream stream = new ZLibStream(new MemoryStream(decompressedSaveChunk.Data), CompressionMode.Compress, false);
            Data = new Byte[Header.CompressedSize];
            stream.Write(Data, 0, Header.CompressedSize);
        }
    }
}
