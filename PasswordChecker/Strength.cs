

namespace PasswordChecker;


public class Class1
{
    public static string CheckStrength(string password)
    {


    bool hasUpper = false;
    bool hasLower = false; 
    bool hasDigit = false; 
    bool hasSymbol = false; 

    foreach (char ch in password)
    {
        if (char.IsUpper(ch))
            hasUpper = true;
        else if (char.IsLower(ch))
            hasLower = true;
        else if (char.IsDigit(ch))
            hasDigit = true;
        else
            hasSymbol = true;
    }

    int metCriteria = 0;
    if (hasUpper) metCriteria++;
    if (hasLower) metCriteria++;
    if (hasDigit) metCriteria++;
    if (hasSymbol) metCriteria++;

    if (metCriteria == 0)
        return "INELIGIBLE";
    else if (metCriteria == 1)
        return "WEAK";
    else if (metCriteria == 2 || metCriteria == 3)
        return "MEDIUM";
    else if (metCriteria == 4)
        return "STRONG"; 
    else
        return "INELIGIBLE"; 




    
        

        


        

}
}
