using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class ShortConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = short.MaxValue;
            var converter = new ShortConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}