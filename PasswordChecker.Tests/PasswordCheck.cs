using Xunit;
using PasswordCheck;


namespace PasswordCheckerTests;


public class PasswordCheckTests
{
        [Fact]
        public void NoCriteriaMet()
        {
            Assert.True("INELLIGIBLE", Strength.PasswordCheck(""));
            Assert.True("INELLIGIBLE", Strength.PasswordCheck("  "));

        }
        [Fact]
        public void OneCriteriaMet()
        {
            Assert.True("WEAK", Strength.PasswordCheck("abcdef"));
            Assert.True("WEAK", Strength.PasswordCheck("ABCDF"));
            Assert.True("WEAK", Strength.PasswordCheck("123456"));
            Assert.True("WEAK", Strength.PasswordCheck("!!!!!"));
        }
        [Fact]
        public void TwoOrThreeCriteriaMet()
        {
            Assert.True("MEDIUM", Strength.PasswordCheck("abc123"));
            Assert.True("MEDIUM", Strength.PasswordCheck("Abc123"));
            Assert.True("MEDIUM", Strength.PasswordCheck("ABCabc"));

        }
        [Fact]
        public void AllCriteriaMet()
        {
            Assert.True("STRONG", Strength.PasswordCheck("Abc123!"));
            Assert.True("STRONG", Strength.PasswordCheck("VsU2027$!"));
        }

    }
    


    

