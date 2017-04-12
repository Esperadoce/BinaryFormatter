using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class BoolConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = false;
            var converter = new BoolConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(value, valueFromBytes);
        }
    }
}