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

        public static unsafe byte[] SerializeValueType<T>(in T value) where T : unmanaged
        {
            byte[] result = new byte[sizeof(T)];
            fixed (byte* dst = result)
                *(T*)dst = value;
            return result;
        }

        public static unsafe T DeserializeValueType<T>(byte[] data) where T : unmanaged
        {
            fixed (byte* src = data)
                return *(T*)src;
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