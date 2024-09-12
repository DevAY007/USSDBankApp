using System;
using System.IO;
string USSD = "*999#";
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string ussdInput = Console.ReadLine();

if(ussdInput == USSD)
    {
        Console.WriteLine("Welcome To Habibi Bank \n Choose one of the following option to continue.");
        Console.WriteLine("1. Create An Account \n 2. Customer Service \n 3. Back");
    }
else {Console.Write("Invalid Input");}
int input = Convert.ToInt32(Console.ReadLine());
if (input  == 1)
   {
        Console.WriteLine("Please Input your FullName");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string fullName = Console.ReadLine();
        Console.WriteLine("Enter Your Date of Birth");
        string DOB = Console.ReadLine();
        Console.WriteLine("Choose Account Type \n 1. Saving \n 2. Current");
        int accountType = Convert.ToInt32(Console.ReadLine());

       StreamWriter writer = new StreamWriter("UserInfo\\Personalinfo.txt");
#pragma warning disable CS8601 // Possible null reference assignment.
    string[] path =[fullName, DOB];
#pragma warning restore CS8601 // Possible null reference assignment.
    foreach (string paths in path)
        {
            writer.WriteLine(paths);
        }
        writer.Close();

    if (accountType == 1)
    {
        Console.WriteLine("Set A 4-Digit Pin");
        int pin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Verify your Pin");
        int verifyPin = Convert.ToInt32(Console.ReadLine());
        if (verifyPin == pin)
        { if (pin > 9999)
        {Console.WriteLine("Please Input a valid 4-Digit Pin");}
        else{Console.WriteLine("Account Created Successfully \nYou have Successfully Created an account with us \n Thanks for choosing Habibi Bank");}}
        else{Console.WriteLine("Invalid Input");}

        StreamWriter write = new StreamWriter("Info.txt");
        int[] part = [accountType, pin,];
        foreach (int parts in part)
        {
            write.WriteLine(parts);
        }
        write.Close();

    }

    else {Console.Write("Please visit our Bank to create such account");}
   }
    else if (input == 2)
    {
        Console.WriteLine("Dail 419 to call our Customer Service");
    }
    else if (input == 3)
    {
        Console.WriteLine("Come back Another Time");
    }


    string userInput = Console.ReadLine();
    if (userInput == USSD)
    {
        Console.WriteLine("1. Check Balance \n2. Transfer \n3. Withdraw \n4. Buy Airtime \n5. Buy Data Bundle \n6. Borrow Money \n7. Account Status");
        int input1 = Convert.ToInt32(Console.ReadLine());
        if (input1 == 1)
        {
            Console.WriteLine("Enter Your Pin To Show Balance");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Balance is #-100 \n You are a broke nigga");
        }
        if (input1 == 2)
        {
            Console.WriteLine("Input Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input Account Number");
            UInt32 accNumber = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Input Bank");
            string Bank = Console.ReadLine();
            Console.WriteLine("Transfer Successful \n Thanks for choosing Habibi Bank");
        }
        if (input1 == 3)
        {
            Console.WriteLine("Go to a nearby POS Agent or Bank to complete your request \n Thanks for choosing Habibi Bank");
        }
        if (input1 == 4)
        {
            Console.WriteLine("Select Network \n 1. MTN \n 2. GLO \n 3. AIRTEL \n 4. 9MOBILE");
            int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Amount");
                int Amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Number");
                uint number = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter Pin");
                int pin =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your request is being processed \n You will receive a confirmation message shortly");
        }
        if (input1 == 5)
        {
            Console.WriteLine("Select Network \n 1. MTN \n 2. GLO \n 3. AIRTEL \n 4. 9MOBILE");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount");
            int Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Number");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Enter Pin");
            int pin =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your request is being processed \n You will receive a confirmation message shortly");
        }
        if (input1 == 6)
        {Console.WriteLine("You are not eligible to borrow money now");}
        if (input1 == 7)
        {Console.WriteLine("Download our app to check status");}
    }
    else
    {
        Console.WriteLine("Invalid Input");
    } 