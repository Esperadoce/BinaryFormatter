using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class CharConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = char.MaxValue;
            var converter = new CharConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}