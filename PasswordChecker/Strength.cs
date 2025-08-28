namespace PasswordCheckerTests
{
    public class PasswordChecker
    {

        static char [] symbols = {'!', '@', '#', '$', '%', '&', '*'};

        public static string CheckStrength(string password)
        {

            int count = 0;
            
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
}
