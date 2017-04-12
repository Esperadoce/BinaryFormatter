using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class UIntConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = uint.MaxValue;
            var converter = new UIntConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}