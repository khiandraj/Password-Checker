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
                Assert.Equal("WEAK", PasswordChecker.CheckStrength("abcdefgh"));
            }

            [Fact]
                public void TwoCriteriaMet()
            {
                Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("aAbcdefg")); 
            }

            [Fact]
                public void ThreeCriteriaMet()
            {
                Assert.Equal("MEDIUM", PasswordChecker.CheckStrength("aA1cdefg"));
            }

            [Fact]
                public void AllCriteriaMet()
            {
                Assert.Equal("STRONG", PasswordChecker.CheckStrength("@aA1cdef"));
            }

            [Fact]
                public void PasswordShorterThanEightFails()
            {
                Assert.Equal("INELIGABLE", PasswordChecker.CheckStrength("aAb!23"));
            }


    }
    
    


    

