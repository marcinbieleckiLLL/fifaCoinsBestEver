using System;
using System.Linq;
using System.Reflection;
using fifaCoinsBestEver.dte;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace fifaCoinsBestEver
{
    public class UserRoleTypeTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UserRoleTypeTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseMySql("server=localhost;port=3306;database=fifaCoins;user=root;password=root")
                .Options;
            var dbContext = new Context(options);

            UserRoleType.findAll(typeof(UserRoleType)).ForEach(userRole =>
            {
                Assert.True(userRole.Name.Equals(dbContext.UserRoleType.Single(u => u.Value == userRole.Value).Name));
                _testOutputHelper.WriteLine(userRole.Name + " : " + userRole.Value);
            });
        }
    }
}
