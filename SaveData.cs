using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SFSE
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Ability
    {
        public Byte Type;
        public Byte SubType;
        public Byte Level;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FileData
    {
        public Int32 NameLength;
        public Char[] Name;
        public Int32 PathLength;
        public Char[] Path;
        public Int32 Timestamp;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public unsafe struct AvatarData
    {
        public Int16 Unknown1;
        public Int32 IsValidatedFlag;
        public Int32 IsPredefinedFlag;
        public Byte PredefinedTemplateId;
        public Int32 Unknown3; // most commonly =100, but sometimes =201, =202
        public Byte Level;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        public Char[] NamePaddingUnknown = new Char[25];
        public Int32 ScriptId1;
        public Int32 ScriptUnknown1;
        public Int32 ScriptId2;
        public Int32 ScriptUnknown2;
        public Int16 Agility;
        public Int16 Charisma;
        public Int16 Dexterity;
        public Int16 Intelligence;
        public Int16 Stamina;
        public Int16 Strength;
        public Int16 Wisdom;
        public Int16 FireResistance;
        public Int16 IceResistance;
        public Int16 BlackMagicResistance;
        public Int16 MindMagicResistance;
        public Int16 RunSpeed;
        public Int16 FightSpeed;
        public Int16 CastSpeed;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public Ability[] AbilityData = new Ability[10];
        public Int16 Model;
        public Int32 Copper;
        public Int32 Silver;
        public Int32 Gold;
        public Int32 Unknown4;
        public Int32 Unknown5;
        public Int32 Unknown6;
        public Int32 Experience;
        public Int16 FreeAbilityPoints;
        public Int16 FreeStatPoints;
        public Int32 Unknown7;
        public Int32 Sex;
        public Int32 Unknown8;
        public Int32 Unknown9;
        public Int16 Unknown10;
        public Byte Unknown11;
        public Int32 ItemCount;

        public AvatarData()
        {
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ItemData
    {
        public Byte InventoryType; // TODO: Create an Enum.
        public Byte SlotMaxUsed;
        public Int16 PositionWithinType;
        public Int16 Id;
        public Int32 Unknown;
    }

    internal class SaveData
    {
        public FileData FileData;
        public AvatarData AvatarData = new AvatarData();
        public ItemData[] ItemData;

        public unsafe SaveData(Byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            Byte[] buffer4 = new Byte[4], buffer2 = new Byte[2];

            stream.ReadExactly(buffer4);
            FileData.NameLength = BitConverter.ToInt32(buffer4);

            FileData.Name = new Char[FileData.NameLength];
            for (int i = 0; i < FileData.NameLength; i++)
            {
                stream.ReadExactly(buffer2);
                FileData.Name[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            FileData.PathLength = BitConverter.ToInt32(buffer4);

            FileData.Path = new Char[FileData.PathLength];
            for (int i = 0; i < FileData.PathLength; i++)
            {
                stream.ReadExactly(buffer2);
                FileData.Path[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            FileData.Timestamp = BitConverter.ToInt32(buffer4);

            Byte[] avatarData = new Byte[227];
            stream.ReadExactly(avatarData);
            AvatarData = Program.Deserialize<AvatarData>(avatarData);

            ItemData = new ItemData[AvatarData.ItemCount];
            for (int i = 0; i < AvatarData.ItemCount; i++)
            {
                Byte[] buffer = new Byte[10];
                stream.ReadAtLeast(buffer, 10, false);
                ItemData[i] = Program.Deserialize<ItemData>(buffer);
            }
        }
    }
}
