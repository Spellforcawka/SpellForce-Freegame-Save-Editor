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
        public Int32 DecompressedSize;
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
            Header = Program.Deserialize<CompressedChunkHeader>(rawHeader);
            Data = new Byte[Header.CompressedSize];
            fileStream.ReadExactly(Data);
        }

        public CompressedSaveChunk(DecompressedSaveChunk decompressedSaveChunk, CompressedChunkHeader header)
        {
            // Copied from original SaveData chunk
            Header.Id = header.Id;
            Header.Unk1 = header.Unk1;
            Header.Unk2 = header.Unk2;
            Header.DecompressedSize = decompressedSaveChunk.Data.Length;

            MemoryStream inputStream = new MemoryStream(decompressedSaveChunk.Data);
            MemoryStream outputStream = new MemoryStream();
            ZLibStream zLibStream = new ZLibStream(outputStream, CompressionMode.Compress);

            int bytes = 0;
            byte[] buffer = new byte[256];
            while ((bytes = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                zLibStream.Write(buffer, 0, bytes);
            }
            zLibStream.Close();
            Data = outputStream.ToArray();
            Header.CompressedSize = Data.Length;
        }
    }
}
