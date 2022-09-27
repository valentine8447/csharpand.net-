using static System.Console;

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table");

    for (int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}"); 
    }
}

//TimesTable(number: 7);


static decimal CalculateTax(
    decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;


switch (twoLetterRegionCode)
{
    case "CH": //Switzerland
        rate = 0.08M;
        break;
    case "DK": //Denmark
    case "NO": //Norway
        rate = 0.25M;
        break;
    case "GB": //United Kingdom
    case "FR": //France
        rate = 0.2M;
        break;
    case "HU": //Hungary
        rate = 0.27M;
        break;
    case "OR": //Oregon
    case "AK": //Alaska
    case "MT": //Montana
        rate = 0.0M;
        break;
    case "ND": //North Dakota
    case "WI": //Wisconsin
    case "ME": //Malme
    case "VA": //Virginia
        rate = 0.05M;
        break;
    case "CA": //California
        rate = 0.0825M;
        break;
    default: //most US states
            rate = 0.06M;
        break; 
}


return amount * rate;
}

//int productValue1 = 50;
//WriteLine($"The value plus tax for the product in Hungary is : {productValue1 + tax1}");

//decimal tax2 = CalculateTax(productValue1, "or");
//WriteLine($"The value plus tax for the product in Oregon is: {productValue1 + tax2}");



///<summary>
/// Pass a 32-bit and it will be converted into its original equivalent.
/// </summary>


static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lasDigit = number % 10;
            string sufix = lasDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{sufix}";
    }
}


static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }

    RunCardinalToOrdinal();
}


    
