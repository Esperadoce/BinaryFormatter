using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class StringConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = "Lorem ipsum";
            var converter = new StringConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}