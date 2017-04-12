using System;
using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class DatetimeConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = DateTime.MaxValue;
            var converter = new DatetimeConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}