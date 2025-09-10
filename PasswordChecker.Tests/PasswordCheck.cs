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

    public class UuidGeneratorTests {
        [Fact]
        public void UuidIsNotNullOrEmpty()
        {
            string uuid = UuidGenerator.GenerateV4Uuid(); 
            Assert.False(string.IsNullOrEmpty(uuid)); 
        }

        [Fact]
        public void UuidIsCorrect()
        {
            string uuid = UuidGenerator.GenerateV4Uuid();  
            Assert.Equal(36, uuid.Length);
            Assert.Matches(@"^[0-9a-f]{8}-[0-9a-f]{4}-4[0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$", uuid);
        }

        [Fact]
        public void UuidIsUnique()
        {
            string uuid1 = UuidGenerator.GenerateV4Uuid(); 
            string uuid2 = UuidGenerator.GenerateV4Uuid(); 
            Assert.NotEqual(uuid1, uuid2);

        }
       


    }

    
    


    

