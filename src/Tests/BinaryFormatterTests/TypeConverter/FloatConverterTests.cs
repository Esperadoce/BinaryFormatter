using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class FloatConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = float.MaxValue;
            var converter = new FloatConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}