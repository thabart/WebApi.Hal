//using Microsoft.AspNet.Mvc.Formatters;
using System.IO;
using WebApi.Hal.Tests.Representations;
using Xunit;

namespace WebApi.Hal.Tests
{
    public class JsonHalMediaTypeInputFormatterFixture
    {
        [Fact]
        public void peopledetail_post_json_props_test()
        {
            /*
            // ARRANGE
            var mediaFormatter = new JsonHalMediaTypeInputFormatter();
            const string json = @"
{
""Id"":""5"",
""Name"": ""Waterproof Fire Department""
}
";
            using (var stream = new MemoryStream())
            {
                using (var textWritter = new StreamWriter(stream))
                {
                    // ACT
                    mediaFormatter.WriteObject(textWritter, resource);
                    textWritter.Flush();

                    // ASSERT
                    stream.Seek(0, SeekOrigin.Begin);
                    var result = new StreamReader(stream).ReadToEnd();
                    Assert.NotEmpty(result);
                    var peopleDetailRepresentation = result as OrganisationWithPeopleDetailRepresentation;
                    Assert.NotNull(peopleDetailRepresentation);
                    Assert.Equal(5, peopleDetailRepresentation.Id);
                    Assert.Equal("Waterproof Fire Department", peopleDetailRepresentation.Name);
                }
            }
            */
        }
    }
}
