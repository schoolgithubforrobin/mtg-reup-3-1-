using System;

class Program
{
    public static void Main(string[] args)
    {
        int computerwins = 0;
        int playerwins = 0;
        int draws = 0;
        int playerHP = 20;
        int comHP = 20;
        int outgoinghurt = 0;
        int incominghurt = 0;
        int healing=0;
        int comhealing=0;
        Console.WriteLine("please enter login details");
        string Login = Console.ReadLine();
        if (Login != null)
        {
            bool running = true;
            Console.WriteLine("placeholder \n1.play mtg\n2.show rules\n3.win;loss");
            string Menupick = Console.ReadLine();
            if (Menupick == "1")
            {  
              string[]cardlisttemp= new string[]{"placeholder card 1","placeholder card 2","placeholder card 3"};
              Random rann = new Random();
              int listlength =cardlisttemp.Length;
              int randompick = rann.Next(1,listlength);
              Console.WriteLine(cardlisttemp[randompick]);
                while (running)
                {
                    if ((playerHP < 1) && (comHP < 1))
                    {
                        Console.WriteLine("you draw with the computer");
                        draws = draws + 1;
                    }
                    else if (comHP < 1)
                    {
                        Console.WriteLine("computer has died! you win");
                        playerwins = playerwins + 1;
                    }
                    else if (playerHP < 1)
                    {
                        Console.WriteLine("you died, computer wins");
                        computerwins = computerwins + 1;
                    }
                    
                    playerHP = (playerHP + healing - incominghurt);
                    comHP = (comHP + healing - outgoinghurt);
                }
                
            }
            else if (Menupick == "2")
            {
                Console.WriteLine("which version do you want to learn about\n1. standard\n2.modern\n3.legacy\n4.vinatge\n5.brawl\n6.Team unified constructed\n7.Commander\n8.block\n9.two headed giant\n10.homebrew\n11.unglued\n12.planechase\n13.vanguard\n14.archenemy\n15.conspiricy draft");
                string submenuon2 = Console.ReadLine();
                switch (submenuon2)
                {
                    case "1":
                        Console.WriteLine("Uses the latest edition of magic cards/packs");
                        break;
                    case "2":
                        Console.WriteLine("A big difference between Standard and Modern MTG is the lack of card/deck change in Modern. While many modern decks can be pretty pricey, the lack of rotation means decks are playable for multiple years. The exception being when an important card is banned—or the meta changes too significantly.");
                        break;
                    case "3":
                        Console.WriteLine("Legacy decks may consist of cards from all Magic card sets as well as some extras, most common to play at home");
                        break;
                    case "4":
                        Console.WriteLine("Vintage, originally Type 1, is a format that allows for the use of almost all printed cards. This excludes acorn cards and having a non-Standard Magic back (other than Double-faced card or a meld card), as well as cards banned for causing issues in official tournaments.");
                        break;
                    case "5":
                        Console.WriteLine("Brawl is a Commander variant that uses only Standard-legal cards.");
                        break;
                    case "6":
                        Console.WriteLine("players play decks from three different formats, and face players from other teams playing the same format. In present-day tournaments, a common format combo is Standard, Modern, and Legacy.");
                        break;
                    case "7":
                        Console.WriteLine("The Commander format is all about picking your ‘legendary creatures’ and building a deck around the idea that they can be put into the game at a small extra cost at any time. ");
                        break;
                    case "8":
                        Console.WriteLine("Block Constructed (also known as Block) was a format that allows for cards of a chosen block to be played, save any banned cards. It is no longer a valid style in competitive play");
                        break;
                    case "9":
                        Console.WriteLine("Two-Headed Giant is a format in which two teams of two players each all play together in a single game");
                        break;
                    case "10":
                        Console.WriteLine(" Homebrew is fan terminology for game material made by players of a game, rather than by an official or third-party publisher");
                        break;
                    case "11":
                        Console.WriteLine("Unglued is a mtg expansion set, the first satirical, non-tournament-legal expansion set released.Among the themes of the set were chicken, dice rolling and multiplayer Magic games.while a joke format with some notoriously broken cards it is a fun version to play outside professional games");
                        break;
                    case "12":
                        Console.WriteLine("Planechase is a card game and a variant of mtg with an emphasis on multiplayer games. The set utilises new ‘oversized’ Plane cards, that are based on various locations within the Mtg multiverse, to modify the rules of gameplay.");
                        break;
                    case "13":
                        Console.WriteLine("The Vanguard format allows players to play with a special extra *card* called a vanguard that modifies the rules of the game just for them. You enter a Vanguard game with a normal constructed deck in the format of your choice, plus a pre-selected vanguard card.");
                        break;
                    case "14":
                        Console.WriteLine("A more relaxed variant in which a team of players faces off against a single opponent strengthened with specific scheme cards");
                        break;
                    case "15":
                        Console.WriteLine("Starts with a ‘booster draft’. Each player sits around the table in a random order with three booster packs. Packs are opened and cards are drafted into your card pool one at a time. Then, players break off into free-for-all multiplayer games.");
                        break;
                }

            }
            else if (Menupick == "3")
            {
                string submenuon3 = Console.ReadLine();
                Console.WriteLine("the player wins to computer wins ratio is " + playerwins + ";" + computerwins + "\nwith " + draws + " amount of draws");
            }
        }
    }
}