//string interpolation
Console.WriteLine("Type in your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Type in your age: ");
string age = Console.ReadLine();
Console.WriteLine("Type in your personality type: ");
string personality = Console.ReadLine();
Console.WriteLine("Type in your job title: ");
string job = Console.ReadLine();
Console.WriteLine("Type in your relationship ststus: ");
string rel = Console.ReadLine();

string person = $"Your name is {firstName}, you are {age} years old, you're of {personality} personality type, you work as a {job} and you are {rel}";
Console.WriteLine(person);

//access strings
Console.WriteLine("Input a word(of min 6 char lenght): ");
string word = Console.ReadLine();
Console.WriteLine("First six letters of your word: ");
Console.WriteLine(word[0]);
Console.WriteLine(word[1]);
Console.WriteLine(word[2]);
Console.WriteLine(word[3]);
Console.WriteLine(word[4]);
Console.WriteLine(word[5]);

string piggyBank = "PIGGYBANK";
Console.WriteLine("Your word is PIGGYBANK, enter either of the letters in this word in order to find out its index number, the letter must be entered capitalized");
string letter = Console.ReadLine();
Console.WriteLine("The index of the given letter: "+piggyBank.IndexOf(letter));
Console.WriteLine("Here is a substring created from the letter you've picked: ");
Console.WriteLine(piggyBank.Substring(piggyBank.IndexOf(letter)));

//escape characters

Console.WriteLine("What's the title of your favourite movie? ");
string title= Console.ReadLine();
Console.WriteLine($"Your favourite movie is \n \t \"{title}\"");

//if..else statements

Console.WriteLine("How many animals do you own? ");
int aniNumb = Convert.ToInt32(Console.ReadLine());
if (aniNumb == 0)
{
    Console.WriteLine("You've got no animals. How sad!");
}
else if (aniNumb ==1)
{
    Console.WriteLine("You've only got one animal. What sort of animal is it? ");
    string animal = Console.ReadLine();
    Console.WriteLine($"What's the name of your {animal}? ");
    string animalName = Console.ReadLine();
    Console.WriteLine($"You've got one {animal}, its name is {animalName}");
}
else
{
    Console.WriteLine("You've got more than one animal. You must be an animal lover!"); 
}

//ternary operator

Console.WriteLine("What's your favourite number? ");
int favNumb = Convert.ToInt32(Console.ReadLine());
string result = (favNumb >= 50) ? "larger or equal to 50" : "smaller than 50";
Console.WriteLine($"Your favourite number is {favNumb} which is {result} ");


