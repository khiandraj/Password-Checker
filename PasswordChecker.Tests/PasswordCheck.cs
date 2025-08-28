namespace PasswordCheckerTests;

    public class PasswordCheckTests
        {
            [Fact]
                public void NoCriteriaMet()
            {
                Assert.Equal("INELIGABLE", PasswordChecker.CheckStrength(""));
            }

            [Fact]
                public void OneCriteriaMet()
            {
                Assert.Equal("WEAK", PasswordChecker.CheckStrength("a"));
            }

            [Fact]
                public void TwoCriteriaMet()
            {
                Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("aA")); 
            }

            [Fact]
                public void ThreeCriteriaMet()
            {
                Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("aA1"));
            }

            [Fact]
                public void AllCriteriaMet()
            {
                Assert.Equal("STRONG", PasswordChecker.CheckStrength("@aA1"));
            }

    }
    
    


    

