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
            Data = new Byte[compressedSaveChunk.Header.DecompressedSize];
            stream.ReadAtLeast(Data, Data.Length, false);
        }

        public DecompressedSaveChunk(SaveData saveData)
        {
            Int32 fileDataSize = (saveData.FileData.NameLength + saveData.FileData.PathLength) * sizeof(Char) + 3 * sizeof(Int32);
            Int32 avatarDataSize = 227; // Constant size
            Int32 itemDataSize = saveData.AvatarData.ItemCount * 10;
            Int32 dataSize = fileDataSize + avatarDataSize + itemDataSize;

            Data = new Byte[dataSize];
            MemoryStream stream = new MemoryStream(Data);

            // FileData serialization
            stream.Write(BitConverter.GetBytes(saveData.FileData.NameLength));
            stream.Write(Encoding.Unicode.GetBytes(saveData.FileData.Name));
            stream.Write(BitConverter.GetBytes(saveData.FileData.PathLength));
            stream.Write(Encoding.Unicode.GetBytes(saveData.FileData.Path));
            stream.Write(BitConverter.GetBytes(saveData.FileData.Timestamp));

            // AvatarData serialization
            stream.Write(Program.Serialize<AvatarData>(saveData.AvatarData));

            // ItemData serialization
            for (int i = 0; i < saveData.AvatarData.ItemCount; i++)
            {
                stream.Write(Program.Serialize<ItemData>(saveData.ItemData[i]));
            }
        }
    }
}
