namespace PasswordCheckerTests
{

    public class PasswordChecker
    {

        static char [] symbols = {'!', '@', '#', '$', '%', '&', '*'};

        ///<summary>
        ///This checks the strength of the password by making sure it meets the 5 criteria. 
        ///<summary>
        ///<param name= "password">This is password parameter</param>
        ///<returns>This returns "INELIGIBLE if no criteria are met, "WEAK" if one criteria is met, 
        /// "MEDIUM" if two or three criteria are met and "STRONG if all criteria are met </returns>
        public static string CheckStrength(string password)
        {
            int count = 0;

            if (password.Length < 8)
            {
                return "INELIGABLE";
            }
            
            if (password.Any(char.IsLower))
            {
                count++;
            }

            
            if (password.Any(char.IsUpper))
            {
                count++;
            }

            
            if (password.Any(char.IsDigit))
            {
                count++;
            }

            Console.Write("Checking symbol");
            if (password.Any(c=> symbols.Contains(c)))
            {
                Console.Write("Found symbol");
                count++;
            }
            

            switch (count)
            {
                case 0:
                    return "INELIGABLE"; 
                case 1:
                    return "WEAK";
                case 2 or 3:
                    return "MEDIUM";
                case 4:
                    return "STRONG";
                default:
                    return "INELIGABLE"; 
            }
       
    }
}
public class UuidGenerator
        {

            /// <summary>
            /// Generates Version 4 UUID
            /// </summary>
            /// <returns> Returns a valid Version 4 UUID </returns>

            public static string GenerateV4Uuid ()
            {
                return Guid.NewGuid().ToString();
            }
        }
}

