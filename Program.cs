double userInput;

// Step 7 | Start with Celsius
(double, temperature) CelsiusToFahrenheit(double tempInCelsius) // Celsius to Fahrenheit
{
    double tempInFahrenheit;
    tempInFahrenheit = ((tempInCelsius * (9)) / 5) + 32;
    Console.WriteLine($"{userInput} {temperature.Celsius} is {tempInFahrenheit} {temperature.Fahrenheit}");
    return (tempInFahrenheit, temperature.Fahrenheit);
}

(double, temperature) CelsiusToKelvin(double tempInCelsius) // Celsius to Kelvin
{
    double tempInKelvin;
    tempInKelvin = tempInCelsius + 273.15;
    Console.WriteLine($"{userInput} {temperature.Celsius} is {tempInKelvin} {temperature.Kelvin}");
    return (tempInKelvin, temperature.Kelvin);
}

// Step 8 | Start with Fahrenheit
(double, temperature) FahrenheitToCelsius(double tempInFahrenheit) // Farhenheit to Celsius
{
    double tempInCelsius;
    tempInCelsius = ((tempInFahrenheit - 32) * 5) / 9;
    Console.WriteLine($"{userInput} {temperature.Fahrenheit} is {tempInCelsius} {temperature.Celsius}");
    return (tempInCelsius, temperature.Celsius);
}

(double, temperature) FahrenheitToKelvin(double tempInFahrenheit) // Fahrenheit to Kelvin
{
    double tempInKelvin;
    tempInKelvin = ((tempInFahrenheit + 459.67) * 5) / 9;
    Console.WriteLine($"{userInput} {temperature.Fahrenheit} is {tempInKelvin} {temperature.Kelvin}");
    return (tempInKelvin, temperature.Kelvin);
}

// Step 9 | Start with Kelvin
(double, temperature) KelvinToFahrenheit(double tempInKelvin) // Kelvin to Fahrenheit
{
    double tempInFahrenheit;
    tempInFahrenheit = ((tempInKelvin * (9)) / 5) - 459.67;
    Console.WriteLine($"{userInput} {temperature.Kelvin} is {tempInFahrenheit} {temperature.Fahrenheit}");
    return (tempInFahrenheit, temperature.Fahrenheit);
}

(double, temperature) KelvinToCelsius(double tempInKelvin) // Kelvin to Celsius
{
    double tempInCelsius;
    tempInCelsius = tempInKelvin - 273.15;
    Console.WriteLine($"{userInput} {temperature.Kelvin} is {tempInCelsius} {temperature.Celsius}");
    return (tempInCelsius, temperature.Celsius);
}

// Step 10 | Start with Inch
(double, length) InchesToFeet(double lengthInInches) // Inches to Feet
{
    double lengthInFeet;
    lengthInFeet = lengthInInches / 12;
    Console.WriteLine($"{userInput} {length.Inch} is {lengthInFeet} {length.Feet}");
    return (lengthInFeet, length.Feet);
}

(double, length) InchesToYards(double lengthInInches) // Inches to Yards
{
    double lengthInYards;
    lengthInYards = lengthInInches / 36;
    Console.WriteLine($"{userInput} {length.Inch} is {lengthInYards} {length.Yard}");
    return (lengthInYards, length.Yard);
}

// Step 11 | Start with Feet
(double, length) FeetToInches(double lengthInFeet) // Feet to Inches
{
    double lengthInInches;
    lengthInInches = lengthInFeet * 12;
    Console.WriteLine($"{userInput} {length.Feet} is {lengthInInches} {length.Inch}");
    return (lengthInInches, length.Inch);
}

(double, length) FeetToYards(double lengthInFeet) // Feet to Yards
{
    double lengthInYards;
    lengthInYards = lengthInFeet / 3;
    Console.WriteLine($"{userInput} {length.Feet} is {lengthInYards} {length.Yard}");
    return (lengthInYards, length.Yard);
}

// Step 12 | Start with Yards
(double, length) YardsToInches(double lengthInYards) // Yards to Inches
{
    double lengthInInches;
    lengthInInches = lengthInYards * 36;
    Console.WriteLine($"{userInput} {length.Yard} is {lengthInInches} {length.Inch}");
    return (lengthInInches, length.Inch);
}

(double, length) YardsToFeet(double lengthInYards) // Yards to Feet
{
    double lengthInFeet;
    lengthInFeet = lengthInYards * 3;
    Console.WriteLine($"{userInput} {length.Yard} is {lengthInFeet} {length.Feet}");
    return (lengthInFeet, length.Feet);
}

// Step 13 | Start with Seconds
(double, time) SecondsToMinutes(double timeInSeconds) // Seconds to Minutes
{
    double timeInMinutes;
    timeInMinutes = timeInSeconds / 60;
    Console.WriteLine($"{userInput} {time.Seconds} is {timeInMinutes} {time.Minutes}");
    return (timeInMinutes, time.Seconds);
}

// Step 13 | Start with Seconds
(double, time) SecondsToHours(double timeInSeconds) // Seconds to Hours
{
    double timeInHours;
    timeInHours = timeInSeconds / 3600;
    Console.WriteLine($"{userInput} {time.Seconds} is {timeInHours} {time.Hours}");
    return (timeInHours, time.Hours);
}

// Step 14 | Start with Hours
(double, time) HoursToSeconds(double timeInHours) // Hours to Seconds
{
    double timeInSeconds;
    timeInSeconds = timeInHours * 3600;
    Console.WriteLine($"{userInput} {time.Hours} is {timeInSeconds} {time.Seconds}");
    return (timeInSeconds, time.Seconds);
}

// Step 14 | Start with Hours
(double, time) HoursToMinutes(double timeInHours) // Hours to Minutes
{
    double timeInMinutes;
    timeInMinutes = timeInHours * 60;
    Console.WriteLine($"{userInput} {time.Hours} is {timeInMinutes} {time.Minutes}");
    return (timeInMinutes, time.Minutes);
}

// Step 15 | Start with Minutes
(double, time) MinutesToHours(double timeInMinutes) // Minutes to Hours
{
    double timeInHours;
    timeInHours = timeInMinutes / 60;
    Console.WriteLine($"{userInput} {time.Minutes} is {timeInHours} {time.Hours}");
    return (timeInHours, time.Hours);
}

// Step 15 | Start with Minutes
(double, time) MinutesToSeconds(double timeInMinutes) // Minutes to Seconds
{
    double timeInSeconds;
    timeInSeconds = timeInMinutes * 60;
    Console.WriteLine($"{userInput} {time.Minutes} is {timeInSeconds} {time.Seconds}");
    return (timeInSeconds, time.Seconds);
}

// Step 16 | Driver Program
void DriverProgram()
{
    string conversionToBeDone = Console.ReadLine();

    if (conversionToBeDone == "1") // Celsius to Fahrenheit
    {
        Console.WriteLine("Please enter temperature in Celsius");
        userInput = double.Parse(Console.ReadLine());
        CelsiusToFahrenheit(userInput);
    }

    else if (conversionToBeDone == "2") // Farhenheit to Celsius
    {
        Console.WriteLine("Please enter temperature in Fahrenheit");
        userInput = double.Parse(Console.ReadLine());
        FahrenheitToCelsius(userInput);
    }

    else if (conversionToBeDone == "3") // Celsius to Kelvin
    {
        Console.WriteLine("Please enter temperature in Celsius");
        userInput = double.Parse(Console.ReadLine());
        CelsiusToKelvin(userInput);
    }

    else if (conversionToBeDone == "4") // Kelvin to Celsius
    {
        Console.WriteLine("Please enter temperature in Kelvin");
        userInput = double.Parse(Console.ReadLine());
        KelvinToCelsius(userInput);
    }

    else if (conversionToBeDone == "5") // Fahrenheit to Kelvin
    {
        Console.WriteLine("Please enter temperature in Fahrenheit");
        userInput = double.Parse(Console.ReadLine());
        FahrenheitToKelvin(userInput);
    }

    else if (conversionToBeDone == "6") // Kelvin to Fahrenheit
    {
        Console.WriteLine("Please enter temperature in Kelvin");
        userInput = double.Parse(Console.ReadLine());
        KelvinToFahrenheit(userInput);
    }

    else if (conversionToBeDone == "7") // Inches to Feet
    {
        Console.WriteLine("Please enter length in inches");
        userInput = double.Parse(Console.ReadLine());
        InchesToFeet(userInput);
    }

    else if (conversionToBeDone == "8") // Feet to Inches
    {
        Console.WriteLine("Please enter length in feet");
        userInput = double.Parse(Console.ReadLine());
        FeetToInches(userInput);
    }

    else if (conversionToBeDone == "9") // Inches to Yards
    {
        Console.WriteLine("Please enter length in inches");
        userInput = double.Parse(Console.ReadLine());
        InchesToYards(userInput);
    }

    else if (conversionToBeDone == "10") // Yards to Inches
    {
        Console.WriteLine("Please enter length in yards");
        userInput = double.Parse(Console.ReadLine());
        YardsToInches(userInput);
    }

    else if (conversionToBeDone == "11") // Feet to Yards
    {
        Console.WriteLine("Please enter length in feet");
        userInput = double.Parse(Console.ReadLine());
        FeetToYards(userInput);
    }

    else if (conversionToBeDone == "12") // Yards to Feet
    {
        Console.WriteLine("Please enter length in yards");
        userInput = double.Parse(Console.ReadLine());
        YardsToFeet(userInput);
    }

    else if (conversionToBeDone == "13") // Seconds to Minutes
    {
        Console.WriteLine("Please enter time in seconds");
        userInput = double.Parse(Console.ReadLine());
        SecondsToMinutes(userInput);
    }

    else if (conversionToBeDone == "14") // Minutes to Seconds
    {
        Console.WriteLine("Please enter time in minutes");
        userInput = double.Parse(Console.ReadLine());
        MinutesToSeconds(userInput);
    }

    else if (conversionToBeDone == "15") // Seconds to Hours
    {
        Console.WriteLine("Please enter time in seconds");
        userInput = double.Parse(Console.ReadLine());
        SecondsToHours(userInput);
    }

    else if (conversionToBeDone == "16") // Hours to Seconds
    {
        Console.WriteLine("Please enter time in hours");
        userInput = double.Parse(Console.ReadLine());
        HoursToSeconds(userInput);
    }

    else if (conversionToBeDone == "17") // Hours to Minutes
    {
        Console.WriteLine("Please enter time in hours");
        userInput = double.Parse(Console.ReadLine());
        HoursToMinutes(userInput);
    }

    else if (conversionToBeDone == "18") // Minutes to Hours
    {
        Console.WriteLine("Please enter time in minutes");
        userInput = double.Parse(Console.ReadLine());
        MinutesToHours(userInput);
    }

    else
    {
        Console.WriteLine("Invalid response. Please choose an integer from 1 to 18.");
        DriverProgram();
    }

    Console.WriteLine("Would you like to do another conversion? 'Y' or 'N'");
    string anotherConversion = Console.ReadLine();

    if (anotherConversion == "Y" || anotherConversion == "y")
    {
        ConversionOptions();
        DriverProgram();
    }
}

void ConversionOptions()
{
    Console.WriteLine("Which conversion would you like to do?");
    Console.WriteLine("1. Celsius to Fahrenheit");
    Console.WriteLine("2. Farhenheit to Celsius");
    Console.WriteLine("3. Celsius to Kelvin");
    Console.WriteLine("4. Kelvin to Celsius");
    Console.WriteLine("5. Fahrenheit to Kelvin");
    Console.WriteLine("6. Kelvin to Fahrenheit");
    Console.WriteLine("7. Inches to Feet");
    Console.WriteLine("8. Feet to Inches");
    Console.WriteLine("9. Inches to Yards");
    Console.WriteLine("10. Yards to Inches");
    Console.WriteLine("11. Feet to Yards");
    Console.WriteLine("12. Yards to Feet");
    Console.WriteLine("13. Seconds to Minutes");
    Console.WriteLine("14. Minutes to Seconds");
    Console.WriteLine("15. Seconds to Hours");
    Console.WriteLine("16. Hours to Seconds");
    Console.WriteLine("17. Hours to Minutes");
    Console.WriteLine("18. Minutes to Hours");
    Console.Write("Please answer using a number: ");
}

ConversionOptions();
DriverProgram();



enum temperature { Celsius, Fahrenheit, Kelvin }
enum length { Inch, Feet, Yard }
enum time { Seconds, Minutes, Hours }