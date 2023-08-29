using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFSE
{
    internal class Helpers
    {
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
    }
}
