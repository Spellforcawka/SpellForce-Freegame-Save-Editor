using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace SFSE
{
    internal class DecompressedSaveChunk
    {
        public Byte[] Data;

        public DecompressedSaveChunk(CompressedSaveChunk compressedSaveChunk)
        {
            ZLibStream stream = new ZLibStream(new MemoryStream(compressedSaveChunk.Data), CompressionMode.Decompress, false);
            Data = new Byte[compressedSaveChunk.Header.CompressedSize];
            stream.ReadAtLeast(Data, Data.Length, false);
        }
    }
}
