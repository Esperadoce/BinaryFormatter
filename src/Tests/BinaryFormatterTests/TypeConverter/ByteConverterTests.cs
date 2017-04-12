using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class ByteConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = byte.MaxValue;
            var converter = new ByteConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}