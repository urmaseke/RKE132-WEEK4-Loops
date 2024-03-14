Random rnd = new Random();
int myRandomnum;
int Randomsum = 0;
for (int i = 0; i < 3; i++)
{
   
    myRandomnum = rnd.Next(0, 11);
    Randomsum = Randomsum + myRandomnum;
    Console.WriteLine($"My random number is: {myRandomnum}");
}
    
Console.WriteLine($"Random sum total: {Randomsum}");