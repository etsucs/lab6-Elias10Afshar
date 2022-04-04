
    showCharacter();

    calculateRetail();   

    Celsius();

    isPrime();


// Method1 (Show Character)

    void showCharacter()
        {
            string charPosition = "New York";
            int startIndex = 4;
            int length = 1; 
             
            String substring = charPosition.Substring(startIndex, length);

            System.Console.WriteLine($"The fourth letter of New York is {substring} \n");

        }
    

// Method 2 (Retail Price)

    static void calculateRetail()

{
        {
            double wholeSale; 
            double markupPercent;
            double retailPrice;

            System.Console.WriteLine("Enter your item's wholesale cost in numbers! ");
            wholeSale = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your item's markup percentage in numbers! ");
            retailPrice = double.Parse(Console.ReadLine());  

            double reatailPrice = calculateRetail(wholeSale, retailPrice);

            static double calculateRetail(double wholeSaleRetail, double markupPercentRetail)
    {

        double retailPercent = wholeSaleRetail + wholeSaleRetail * markupPercentRetail / 100;

      

        
            System.Console.WriteLine($"Your item's retail price is: {retailPercent.ToString("0.00")} \n");

              return retailPercent;

    }
        }
        }
    

// Method 3 (Temperature Table)

    static void Celsius()

    {

            double f; 
            double c;

            System.Console.WriteLine("Fahrenheit                      Celsius");
            System.Console.WriteLine("----------                      -------");

            for (double i = 80; i <= 100; i++)
            {

                System.Console.WriteLine($"{(i)}                               {(Celsius((i)))} \n");

            }

        double Celsius(double f)
        {
            double c = 5.0 / 9.0 * (f - 32);
            return c;

        }           

    }


// Method 4 (Prime Numbers)

    static void isPrime()

    {

        System.Console.WriteLine("Insert a number to check if it is a prime number");
        int number = int.Parse(Console.ReadLine());
  
    if (isPrime(number))
            System.Console.WriteLine(number + " is a prime number");

        else
            System.Console.WriteLine(number + " is not a prime number");


    static bool isPrime(int number)
        {
            
            for (int i = 2; i < number; i++)
          if (number % i == 0) 
            return false;

        return true;

        }
    }
    

