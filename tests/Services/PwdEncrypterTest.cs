using System;
using fifaCoinsBestEver.Services;
using Xunit;
using Xunit.Abstractions;

namespace fifaCoinsBestEver.tests.Services
{
    public class PwdEncrypterTest: ATest
    {
        private static String PWD_TO_ENCRYPT = "Kuba987!@#";
        private static String ENCRYPED_PWD = "r1bdp8Xh7wMm8Txmjvde/Tw1f3l/ThciQw29ewzSL9WEP62H3jgAexY2uI7t9E5G8oRV8MWxSQ4yIfRtHJMRSA==";
        
        public PwdEncrypterTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public void Test1()
        {
             string encryptedPwd = new PwdEncrypter().encrypt(PWD_TO_ENCRYPT);
             Assert.True(ENCRYPED_PWD.Equals(encryptedPwd));
            _testOutputHelper.WriteLine(encryptedPwd);
        }
        
    }
}