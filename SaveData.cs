using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SFSE
{

    public enum AbilityType : Byte
    {
        LightCombatArts = 1,
        HeavyCombatArts,
        RangedCombatArts,
        WhiteMagic,
        ElementalMagic,
        MindMagic,
        BlackMagic,
        Empty = 255,
    }

    public enum LightCombatArtsSubtype : Byte
    {
        None,
        PiercingWeapons,
        LightBladeWeapons,
        LightBluntWeapons,
        LightArmor,
        Empty = 255,
    }

    public enum HeavyCombatArtsSubtype : Byte
    {
        None,
        HeavyBladeWeapons,
        HeavyBluntWeapons,
        HeavyArmor,
        Shields,
        Empty = 255,
    }

    public enum RangedCombatArtsSubtype : Byte
    {
        None = 0,
        Bows,
        Crossbows,
        Empty,
    }

    public enum WhiteMagicSubtype : Byte
    {
        None,
        Life,
        Nature,
        Boons,
        Empty,
    }

    public enum ElementalMagicSubtype : Byte
    {
        None,
        Fire,
        Ice,
        Earth,
        Empty = 255,
    }

    public enum MindMagicSubtype : Byte
    {
        None,
        Offensive,
        Defensive,
        Enchantment,
        Empty = 255,
    }

    public enum BlackMagicSubtype : Byte
    {
        None,
        Death,
        Necromancy,
        Curses,
        Empty = 255,
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Ability
    {
        public AbilityType Type;
        public Byte SubType;
        public Byte Level;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Item
    {
        public Byte InventoryType; // TODO: Create an Enum.
        public Byte SlotMaxUsed;
        public Int16 PositionWithinType;
        public Int16 Id;
        public Int32 Unknown;
    }

    internal class SaveData
    {
        public Int32 FileNameLength;
        public Char[] FileName; // #FileNameLength+1
        public Int32 FilePathLength;
        public Char[] FilePath; // #FilePathLength+1
        public Int32 Timestamp;
        public Int16 Unknown1;
        public Int32 Unknown2;
        public Int32 AvatarPredefinedFlag;
        public Byte AvatarPredefinedTemplateId;
        public Int32 Unknown3; // most commonly =100, but sometimes =201, =202
        public Byte AvatarLevel;
        public Char[] AvatarName; // #15
        public Char[] AvatarNamePaddingUnknown; // #25
        public Int32 AvatarScriptId1;
        public Int32 AvatarScriptUnknown1;
        public Int32 AvatarScriptId2;
        public Int32 AvatarScriptUnknown2;
        public Int32 AvatarAgility;
        public Int32 AvatarCharisma;
        public Int32 AvatarDexterity;
        public Int32 AvatarIntelligence;
        public Int32 AvatarStamina;
        public Int32 AvatarStrength;
        public Int32 AvatarWisdom;
        public Int32 AvatarFireResistance;
        public Int32 AvatarIceResistance;
        public Int32 AvatarBlackMagicResistance;
        public Int32 AvatarMindMagicResistance;
        public Int32 AvatarRunSpeed;
        public Int32 AvatarFightSpeed;
        public Int32 AvatarCastSpeed;
        public Ability[] AvatarAbilities; // #10
        public Int16 AvatarModel;
        public Int32 AvatarCopper;
        public Int32 AvatarSilver;
        public Int32 AvatarGold;
        public Int32 Unknown4;
        public Int32 Unknown5;
        public Int32 Unknown6;
        public Int32 AvatarExperience;
        public Int16 AvatarFreeAbilityPoints;
        public Int16 AvatarFreeStatPoints;
        public Int32 Unknown7;
        public Int32 AvatarSex;
        public Int32 Unknown8;
        public Int32 Unknown9;
        public Int16 Unknown10;
        public Byte Unknown11;
        public Int32 ItemCount;
        public Item[] Items; // ItemCount

        public SaveData(Byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            Byte[] buffer4 = new Byte[4], buffer2 = new Byte[2], buffer1 = new Byte[1];

            stream.ReadExactly(buffer4);
            FileNameLength = BitConverter.ToInt32(buffer4);

            FileName = new Char[FileNameLength];
            for (int i = 0; i < FileNameLength; i++)
            {
                stream.ReadExactly(buffer2);
                FileName[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            FilePathLength = BitConverter.ToInt32(buffer4);

            FilePath = new Char[FilePathLength];
            for (int i = 0; i < FilePathLength; i++)
            {
                stream.ReadExactly(buffer2);
                FilePath[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            Timestamp = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer2);
            Unknown1 = BitConverter.ToInt16(buffer2);

            stream.ReadExactly(buffer4);
            Unknown2 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarPredefinedFlag = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer1);
            AvatarPredefinedTemplateId = buffer1[0];

            stream.ReadExactly(buffer4);
            Unknown3 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer1);
            AvatarLevel = buffer1[0];

            AvatarName = new Char[15];
            for (int i = 0; i < 15; i++)
            {
                stream.ReadExactly(buffer2);
                AvatarName[i] = BitConverter.ToChar(buffer2);
            }

            AvatarNamePaddingUnknown = new Char[25];
            for (int i = 0; i < 25; i++)
            {
                stream.ReadExactly(buffer2);
                AvatarNamePaddingUnknown[i] = BitConverter.ToChar(buffer2);
            }

            stream.ReadExactly(buffer4);
            AvatarScriptId1 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarScriptUnknown1 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarScriptId2 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarScriptUnknown2 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer2);
            AvatarAgility = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarCharisma = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarDexterity = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarIntelligence = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarStamina = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarStrength = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarWisdom = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarFireResistance = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarIceResistance = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarBlackMagicResistance = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarMindMagicResistance = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarRunSpeed = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarFightSpeed = BitConverter.ToChar(buffer2);

            stream.ReadExactly(buffer2);
            AvatarCastSpeed = BitConverter.ToChar(buffer2);

            AvatarAbilities = new Ability[10];
            for (int i = 0; i < 10;  i++)
            {
                AvatarAbilities[i] = new Ability();
                stream.ReadExactly(buffer1);
                AvatarAbilities[i].Type = (AbilityType) buffer1[0];
                stream.ReadExactly(buffer1);
                AvatarAbilities[i].SubType = buffer1[0];
                stream.ReadExactly(buffer1);
                AvatarAbilities[i].Level = buffer1[0];
            }

            stream.ReadExactly(buffer2);
            AvatarModel = BitConverter.ToInt16(buffer2);

            stream.ReadExactly(buffer4);
            AvatarCopper = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarSilver = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarGold = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            Unknown4 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            Unknown5 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            Unknown6 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarExperience = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer2);
            AvatarFreeAbilityPoints = BitConverter.ToInt16(buffer2);

            stream.ReadExactly(buffer2);
            AvatarFreeStatPoints = BitConverter.ToInt16(buffer2);

            stream.ReadExactly(buffer4);
            Unknown7 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            AvatarSex = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            Unknown8 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer4);
            Unknown9 = BitConverter.ToInt32(buffer4);

            stream.ReadExactly(buffer2);
            Unknown10 = BitConverter.ToInt16(buffer2);

            stream.ReadExactly(buffer1);
            Unknown11 = buffer1[0];

            stream.ReadExactly(buffer4);
            ItemCount = BitConverter.ToInt32(buffer4);

            Items = new Item[ItemCount];
            for (int i = 0; i < ItemCount; i++)
            {
                Byte[] buffer = new Byte[10];
                stream.ReadAtLeast(buffer, 10, false);
                Items[i] = Helpers.DeserializeValueType<Item>(buffer);
            }
        }
    }
}
