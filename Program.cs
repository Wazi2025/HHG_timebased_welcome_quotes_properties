namespace HHG_timebased_welcome_quotes_properties;

class Program
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }//end of class Player

    //instantiate player object at Program class level
    //so it's accessible from any method within Program class as long as the methods are static
    public static Player player = new Player();

    //create a new string list which also needs to be static since we are populating it inside the InitializeList method
    static List<string> greetingList = new List<string>();

    static void Main(string[] args)
    {
        //call methods
        InitializeList();
        ReadInput();

        DateTime date = DateTime.Now;
        const string dateFormat = "dd MMMM, yyyy";
        const string timeFormat = "HH:mm:ss";
        const string dateMessage = "The date is:";
        const string timeMessage = "The time is:";
        const int dontPanic = 42;
        const string dontPanicText = @"
 _____            _ _     _____           _
|  _  \          ( ) |   | ___ \         (_)     
| | | |___  _ __ |/| |_  | |_/ /_ _ _ __  _  ___ 
| | | / _ \| '_ \  | __| |  __/ _` | '_ \| |/ __|
| |/ / (_) | | | | | |_  | | | (_| | | | | | (__ 
|___/ \___/|_| |_|  \__| \_|  \__,_|_| |_|_|\___|
                                                 
";

        if (player.Age == dontPanic)
            Console.WriteLine(dontPanicText);
        else
        {
            Console.WriteLine($"Hello, {player.FirstName} {player.LastName} ({player.Age} years). Your quote is:\n\"{greetingList[date.Second]}\"\n\n{dateMessage} {date.DayOfWeek} {date.ToString(dateFormat)}\n{timeMessage} {date.ToString(timeFormat)}");
            Console.WriteLine($"Quote used is located at position {greetingList.IndexOf(greetingList[date.Second])} in a list of {greetingList.Count} items.");
        }
    } //end of Main

    public static bool IsNull(string? input)
    {
        //not really necessary to create a method just for IsNullOrEmpty but I wanted to test my own understanding
        //of using methods/functions with a return value (and parameter)
        if (string.IsNullOrEmpty(input))
            return true;
        else
            return false;
    }

    public static void InitializeList()
    {
        //populate list
        //no need to check for indexOutOfBoundsException since list is exactly 60 items (date.Second)
        greetingList.Add("The Restaurant at the End of the Universe.");
        greetingList.Add("'I never could get the hang of Thursdays.'");
        greetingList.Add("It's nothing but a gnab gib.");
        greetingList.Add("42.");
        greetingList.Add("Eddies in the space time continuum.");
        greetingList.Add("Pan Galactic Gargle Blaster!");
        greetingList.Add("The Big Bang burger bar.");
        greetingList.Add("Don't Panic.");
        greetingList.Add("Time is an illusion. Lunchtime doubly so.");
        greetingList.Add("Would it save you a lot of time if I just gave up and went mad now?");
        greetingList.Add("Isn't it enough to see that a garden is beautiful without having to believe that there are fairies at the bottom of it too?");
        greetingList.Add("The ships hung in the sky in much the same way that bricks don't.");
        greetingList.Add("I'd far rather be happy than right any day.");
        greetingList.Add("Space is big. You just won't believe how vastly, hugely, mind-bogglingly big it is. I mean, you may think it's a long way down the road to the chemist's, but that's just peanuts to space.");
        greetingList.Add("For a moment, nothing happened. Then, after a second or so, nothing continued to happen.");
        greetingList.Add("A towel is about the most massively useful thing an interstellar hitchhiker can have.");
        greetingList.Add("Ford... you're turning into a penguin. Stop it.");
        greetingList.Add("This planet has - or rather had - a problem, which was this: most of the people living on it were unhappy for pretty much of the time. Many solutions were suggested for this problem, but most of these were largely concerned with the movement of small green pieces of paper, which was odd because on the whole it wasn't the small green pieces of paper that were unhappy.");
        greetingList.Add("So this it, we are going to die");
        greetingList.Add("The Answer? The Answer to what?");
        greetingList.Add("So long, and thanks for all the fish.");
        greetingList.Add("We demand rigidly defined areas of doubt and uncertainty!");
        greetingList.Add("On display? I eventually had to go down to the cellar to find them.");
        greetingList.Add("That’s the display department.");
        greetingList.Add("Ford! There's an infinite number of monkeys outside who want to talk to us about this script for Hamlet they've worked out.");
        greetingList.Add("We're safe.");
        greetingList.Add("We're in a small galley cabin in one of the spaceships of the Vogon Constructor Fleet.");
        greetingList.Add("Ah, this is obviously some strange use of the word safe that I wasn't previously aware of.");
        greetingList.Add("Another thing that got forgotten was the fact that against all probability a sperm whale had suddenly been called into existence several miles above the surface of an alien planet.");
        greetingList.Add("Hello?");
        greetingList.Add("Why am I here? What’s my purpose in life?");
        greetingList.Add("What do I mean by who am I?");
        greetingList.Add("Well I suppose I’d better start finding names for things if I want to make any headway in what for the sake of what I shall call an argument I shall call the world, so let’s call it my stomach.");
        greetingList.Add("Doesn’t seem to achieve very much but I’ll probably find out what it’s for later on.");
        greetingList.Add("Now – have I built up any coherent picture of things yet?");
        greetingList.Add("Or is it the wind?");
        greetingList.Add("There really is a lot of that now isn’t it?");
        greetingList.Add("Hey! What’s this thing suddenly coming towards me very fast?");
        greetingList.Add("I wonder if it will be friends with me?");
        greetingList.Add("And the rest, after a sudden wet thud, was silence.");
        greetingList.Add("Curiously enough, the only thing that went through the mind of the bowl of petunias as it fell was 'Oh no, not again.'");
        greetingList.Add("Many people have speculated that if we knew exactly why the bowl of petunias had thought that we would know a lot more about the nature of the universe than we do now.");
        greetingList.Add("What's so unpleasant about being drunk?");
        greetingList.Add("You ask a glass of water!");
        greetingList.Add("Is there any tea on this spaceship?");
        greetingList.Add("In those days spirits were brave, the stakes were high, men were real men, women were real women and small furry creatures from Alpha Centauri were real small furry creatures from Alpha Centauri.");
        greetingList.Add("I think you ought to know I'm feeling very depressed.");
        greetingList.Add("This time it was right, it would work, and no one would have to get nailed to anything.");
        greetingList.Add("Perhaps I'm old and tired, but I always think that the chances of finding out what really is going on are so absurdly remote that the only thing to do is to say hang the sense of it and just keep yourself occupied.");
        greetingList.Add("Meanwhile, the poor Babel fish, by effectively removing all barriers to communication between different races and cultures, has caused more and bloodier wars than anything else in the history of creation.");
        greetingList.Add("Exactly! So once you do know what the question actually is, you'll know what the answer means.");
        greetingList.Add("The secret is to bang the rocks together, guys.");
        greetingList.Add("I don't want to go to heaven with a headache, I'd be all cross and wouldn't enjoy it!");
        greetingList.Add("Vogon poetry is of course, the third worst in the universe.");
        greetingList.Add("I like the cover.");
        greetingList.Add("There's a frood who really knows where his towel is.");
        greetingList.Add("And all dared to brave unknown terrors, to do mighty deeds, to boldly split infinitives that no man had split before--and thus was the Empire forged.");
        greetingList.Add("Life! Don't talk to me about life.");
        greetingList.Add("What's a whelk got to do with a supernova?");
        greetingList.Add("Energize the demolition beams.");
    }

    public static void ReadInput()
    {
        //ask the user for their firstname, lastname and age and add these values to their respective player fields
        string? result = null;
        bool ageIsANumber = false;

        while (IsNull(result))
        {
            Console.WriteLine("What is your first name?");
            result = Console.ReadLine();
        }
        player.FirstName = result;
        result = null;

        while (IsNull(result))
        {
            Console.WriteLine("What is your last name?");
            result = Console.ReadLine();
        }
        player.LastName = result;
        result = null;

        while (!ageIsANumber)
        {
            Console.WriteLine("What is your age?");
            result = Console.ReadLine();

            //check if string can be converted to number                
            if (int.TryParse(result, out int number))
            {
                player.Age = number;
                ageIsANumber = true;
            }
            else
                Console.WriteLine($"{result} is not a number.");
        }
    }
} //end of class Program
