using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class DatetimeConverter : BaseTypeConverter<DateTime>
    {
        public override SerializedType Type => SerializedType.Datetime;

        protected override byte[] ProcessSerialize(DateTime obj)
        {
            return BitConverter.GetBytes(obj.Ticks);
        }

        protected override DateTime ProcessDeserialize(byte[] stream, ref int offset)
        {
            var ticks = BitConverter.ToInt64(stream, offset);
            return DateTime.FromBinary(ticks);
        }

        protected override int GetTypeSize()
        {
            return sizeof(long);
        }
    }
}