using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class ULongConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = ulong.MaxValue;
            var converter = new ULongConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}