using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Xunit.Abstractions;

namespace fifaCoinsBestEver.tests
{
    public abstract class ATest
    {
        private static String DB_LINK = "server=localhost;port=3306;database=fifaCoins;user=root;password=root";
            
        protected readonly ITestOutputHelper _testOutputHelper;
        protected readonly Context dbContext;
        
        public ATest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            dbContext = createContext();
        }

        private Context createContext()
        {
            return new Context(createDbOptions());
        }

        private DbContextOptions<Context> createDbOptions()
        {
            return new DbContextOptionsBuilder<Context>()
                .UseMySql(DB_LINK)
                .Options;   
        }
    }
}