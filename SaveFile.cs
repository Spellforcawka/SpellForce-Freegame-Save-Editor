using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SFSE
{
    public struct SaveFileHeader
    {
        public UInt32 Magic;
        public UInt32 Version;
        public UInt32 Padding1;
        public UInt32 Padding2;
        public UInt32 Padding3;
    }
    internal class SaveFile
    {
        public SaveFileHeader Header;
        public List<DecompressedSaveChunk> DecompressedChunks;

        static UInt16 HeaderSize = 20;

        public SaveFile(FileStream fileStream)
        {
            byte[] rawHeader = new byte[HeaderSize];
            fileStream.ReadExactly(rawHeader);
            Header = Program.Deserialize<SaveFileHeader>(rawHeader);
            DecompressedChunks = new List<DecompressedSaveChunk>();
            while (fileStream.Position < fileStream.Length)
            {
                DecompressedChunks.Add(new DecompressedSaveChunk(new CompressedSaveChunk(fileStream)));
            }
        }
    }
}
