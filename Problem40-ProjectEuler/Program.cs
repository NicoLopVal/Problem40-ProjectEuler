
int digitCount = 0;
int counter = 0;
int value = 1;
int result = 1;

while (true)
{
    counter++;
    digitCount = digitCount + counter.ToString().Length;
    string strCounter = counter.ToString();
    if (digitCount == value)
    {
        result = result * Int32.Parse(strCounter[0].ToString());
        value *= 10;
    }
    else if(digitCount < value && digitCount + (counter + 1).ToString().Length > value)
    {
        int smallCounter = value - digitCount - 1;
        result = result * Convert.ToInt32((counter + 1).ToString()[smallCounter].ToString());
        value *= 10;
    }
    if (value > 1000000)
        break;
}

Console.WriteLine("The resulting product would be: " + result);
