//Project-1
/* int numericValue = 0;
string? readValue;
bool inValidValue = false;
Console.WriteLine("Enter any integer value between 5 and 10 ");
do
{
    readValue = Console.ReadLine();
    inValidValue = int.TryParse(readValue, out numericValue);
    //invalid value
    if (!inValidValue)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        inValidValue = true;
    }
    //value <5 or >10
    else if (numericValue < 5 || numericValue > 10)
    {
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    }
    //value btwn 5 and 10
    else
    {
        Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
        inValidValue = false;
    }


} while (inValidValue); */


//Project-2
/* string? roleValue;
bool roleValueInValid = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    roleValue = Console.ReadLine();
    if (roleValue != null)
    {
        string role = roleValue.Trim().ToLower();
        if (role == "administrator" || role == "manager" || role == "user")
        {
            roleValueInValid = false;
            Console.WriteLine($"Your input value ({roleValue.Trim()}) has been accepted.");
        }
        else
        {
            roleValueInValid = true;
            Console.WriteLine($"The role name that you entered, \"{roleValue}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }

} while (roleValueInValid); */

//Project-3
string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation = 0;
string finalString = "";
foreach (string myString in myStrings)
{
    string mySentence = myString;
    periodLocation = myString.IndexOf(".");
    while (periodLocation != -1)
    {
        finalString = mySentence.Remove(periodLocation);
        mySentence = mySentence.Substring(periodLocation + 1).TrimStart();
        periodLocation = mySentence.IndexOf(".");
        Console.WriteLine(finalString);
    }

    Console.WriteLine(mySentence);
}