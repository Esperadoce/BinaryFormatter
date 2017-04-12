using System.Linq;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class DecimalConverter : BaseTypeConverter<decimal>
    {
        private int Size { get; set; }

        public override SerializedType Type => SerializedType.Decimal;

        protected override byte[] ProcessSerialize(decimal obj)
        {
            var sdecimal = obj.ToString("F");
            Size = sdecimal.Length;
            return new StringConverter().Serialize(sdecimal);
        }

        protected override decimal ProcessDeserialize(byte[] stream, ref int offset)
        {
            var sdecimal = new StringConverter().Deserialize(stream.Skip(offset).ToArray());
            return decimal.Parse(sdecimal);
        }

        protected override int GetTypeSize()
        {
            return Size;
        }
    }
}