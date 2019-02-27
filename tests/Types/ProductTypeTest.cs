using System.Linq;
using fifaCoinsBestEver.dte;
using fifaCoinsBestEver.tests;
using Xunit;
using Xunit.Abstractions;

namespace fifaCoinsBestEver
{
    public class ProductTypeTest : ATest
    {
        public ProductTypeTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
        
        [Fact]
        public void Test1()
        {
            ProductType.findAll(typeof(ProductType)).ForEach(productType =>
            {
                Assert.True(productType.name.Equals(dbContext.productTypes.Single(u => u.value == productType.value).name));
                _testOutputHelper.WriteLine(productType.name + " : " + productType.value);
            });
        }
    }
}