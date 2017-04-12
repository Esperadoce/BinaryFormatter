using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class UShortConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = ushort.MaxValue;
            var converter = new UShortConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}