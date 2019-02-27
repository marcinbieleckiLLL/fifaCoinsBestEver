using System;
using System.Linq;
using System.Reflection;
using fifaCoinsBestEver.dte;
using fifaCoinsBestEver.tests;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace fifaCoinsBestEver
{
    public class UserRoleTypeTest : ATest
    {
        public UserRoleTypeTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
        
        [Fact]
        public void Test1()
        {
            UserRoleType.findAll(typeof(UserRoleType)).ForEach(userRole =>
            {
                Assert.True(userRole.name.Equals(dbContext.userRoleTypes.Single(u => u.value == userRole.value).name));
                _testOutputHelper.WriteLine(userRole.name + " : " + userRole.value);
            });
        }
    }
}
