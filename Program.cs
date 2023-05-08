Random random = new Random();
int daysUntilExpiration = random.Next(12);

int discountPercentage = 0;

if (daysUntilExpiration > 0)
{ 	// if the number is greater than zero then...
    if ((daysUntilExpiration >= 5) && (daysUntilExpiration <= 10))
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

    if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
    }

    if (daysUntilExpiration < 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
    }
}
else 	// if the number is less than zero then...
{
    Console.WriteLine("Your subscription has expired");
}

// daysUntilExpiration >5 && >=10 -> Your subscription will expire soon. Renew now!

// daysUntilExpiration <=5 -> Your subscription expires in _ days. Renew now and save 10%!

// daysUntilExpiration <1 -> Your subscription expires within a day! Renew now and save 20%!

// daysUntilExpiration =0 -> Your subscription has expired.
