using System;
using System.Threading.Tasks;
using Xunit;

namespace Wasapi.Tests
{
    public class AssociationsTests
    {
        private readonly Api _api;

        public AssociationsTests()
        {
            _api = new Api("insert your key for test");
        }
        
        [Fact]
        public async Task WhenRequest_IsValid_ShouldReturnAssociations()
        {
            var result = await _api.Associations().GetAssociationsAsync(new[] {"hello"}, new RequestSettings {Language = Language.En});
            
            Assert.Equal((int)ResponseCode.Ok, result.Code);
        }
        
        [Fact]
        public async Task WhenRequest_HasInvalidKey_ShouldReturnError()
        {
            var result = await new Api("test").Associations().GetAssociationsAsync(new[] {"hello"}, new RequestSettings {Language = Language.En});
            
            Assert.Equal((int)ResponseCode.InvalidKey, result.Code);
        }
    }
}