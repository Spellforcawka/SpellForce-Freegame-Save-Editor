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
        public Char[] Name; // #NameLength+1
        public Int32 PathLength;
        public Char[] Path; // #PathLength+1
        public Int32 Timestamp;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public unsafe struct AvatarData
    {
        public Int16 Unknown1;
        public Int32 Unknown2;
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
        public FileData File;
        public AvatarData Avatar = new AvatarData();
        public ItemData[] Items; // #ItemCount

        public unsafe SaveData(Byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            Byte[] buffer4 = new Byte[4], buffer2 = new Byte[2];

            stream.ReadExactly(buffer4);
            File.NameLength = BitConverter.ToInt32(buffer4);

            File.Name = new Char[File.NameLength];
            for (int i = 0; i < File.NameLength; i++)
            {
                stream.ReadExactly(buffer2);
                File.Name[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            File.PathLength = BitConverter.ToInt32(buffer4);

            File.Path = new Char[File.PathLength];
            for (int i = 0; i < File.PathLength; i++)
            {
                stream.ReadExactly(buffer2);
                File.Path[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            File.Timestamp = BitConverter.ToInt32(buffer4);

            Byte[] avatarData = new Byte[228];
            stream.ReadExactly(avatarData);
            Avatar = Program.Deserialize<AvatarData>(avatarData);

            Items = new ItemData[Avatar.ItemCount];
            for (int i = 0; i < Avatar.ItemCount; i++)
            {
                Byte[] buffer = new Byte[10];
                stream.ReadAtLeast(buffer, 10, false);
                Items[i] = Program.Deserialize<ItemData>(buffer);
            }
        }
    }
}
