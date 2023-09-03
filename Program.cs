using System.Runtime.InteropServices;

namespace SFSE
{
    internal static class Program
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

        public enum EmptySubtype : Byte
        {
            Empty = 255,
        }

        public enum AbilityLevel : Byte
        {
            _1 = 1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            _10,
            _11,
            _12,
            Empty = 255
        }

        public static SaveData LoadedData;

        public static unsafe byte[] Serialize<T>(T value) where T : struct
        {
            byte[] buffer = new byte[Marshal.SizeOf(value)];
            fixed (byte* bufferPtr = buffer)
            {
                Marshal.StructureToPtr(value, (IntPtr)bufferPtr, true);
            }
            return buffer;
        }

        public static unsafe T Deserialize<T>(byte[] buffer) where T : struct
        {
            fixed (byte* bufferPtr = buffer)
            {
                return (T)Marshal.PtrToStructure((IntPtr)bufferPtr, typeof(T));
            }
        }

        public static void UpdateSubtypeChoices(ListBox typeListBox, ListBox subtypeListBox)
        {
            switch (typeListBox.SelectedValue)
            {
                case Program.AbilityType.LightCombatArts:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.LightCombatArtsSubtype));
                    break;
                case Program.AbilityType.HeavyCombatArts:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.HeavyCombatArtsSubtype));
                    break;
                case Program.AbilityType.RangedCombatArts:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.RangedCombatArtsSubtype));
                    break;
                case Program.AbilityType.WhiteMagic:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.WhiteMagicSubtype));
                    break;
                case Program.AbilityType.ElementalMagic:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.ElementalMagicSubtype));
                    break;
                case Program.AbilityType.MindMagic:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.MindMagicSubtype));
                    break;
                case Program.AbilityType.BlackMagic:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.BlackMagicSubtype));
                    break;
                case Program.AbilityType.Empty:
                    subtypeListBox.DataSource = Enum.GetValues(typeof(Program.EmptySubtype));
                    break;
            }
        }

        public static void UpdateSubtypeValue(ListBox typeListBox, ListBox subtypeListBox, Byte value)
        {
            switch (typeListBox.SelectedValue)
            {
                case Program.AbilityType.LightCombatArts:
                    subtypeListBox.SelectedItem = (Program.LightCombatArtsSubtype)value;
                    break;
                case Program.AbilityType.HeavyCombatArts:
                    subtypeListBox.SelectedItem = (Program.HeavyCombatArtsSubtype)value;
                    break;
                case Program.AbilityType.RangedCombatArts:
                    subtypeListBox.SelectedItem = (Program.RangedCombatArtsSubtype)value;
                    break;
                case Program.AbilityType.WhiteMagic:
                    subtypeListBox.SelectedItem = (Program.WhiteMagicSubtype)value;
                    break;
                case Program.AbilityType.ElementalMagic:
                    subtypeListBox.SelectedItem = (Program.ElementalMagicSubtype)value;
                    break;
                case Program.AbilityType.MindMagic:
                    subtypeListBox.SelectedItem = (Program.MindMagicSubtype)value;
                    break;
                case Program.AbilityType.BlackMagic:
                    subtypeListBox.SelectedItem = (Program.BlackMagicSubtype)value;
                    break;
                case Program.AbilityType.Empty:
                    subtypeListBox.SelectedItem = (Program.EmptySubtype)value;
                    break;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}