
using System.Diagnostics.Contracts;
bool game = true;
bool rules = true;
bool graphics = true;
bool graphicsOn = false;
bool choosing = false;
bool betting = false;
bool spin = false;
bool shutDown = false;
string yesNo;
string color = "Not chosen";
int betColor = 0;
string evenOdd = "Not chosen";
int betEven = 0;
int bet = 0;
int chosenBet = -1;
int bet2 = 0;
int chosenBet2 = -1;
int bet3 = 0;
int chosenBet3 = -1;
int betRange = 0;
int chosenRange = -1;
int money = 10;
int bets = 0;
int choice = 0;
int luck = 10; //HAR INTE LAGT TILL ÄN;
int result = 0;
int resultRange = -1;
string readLine;
string resultEven ="Failed to check eveness";
int Randomada;
string resultCol = "Failed to generate color";



//TEXT I BÖRJAN


Console.WriteLine("                       888        888   888            ");
Console.WriteLine("                       888        888   888            ");
Console.WriteLine("                       888        888   888            ");
Console.WriteLine(" 888d888 .d88b. 888  888888 .d88b. 888888888888 .d88b.  ");
Console.WriteLine(" 888P   d88  88b888  888888d8P  Y8b888   888   d8P  Y8b ");
Console.WriteLine(" 888    888  888888  88888888888888888   888   88888888 ");
Console.WriteLine(" 888    Y88..88PY88b 888888Y8b.    Y88b. Y88b. Y8b.     ");
Console.WriteLine(" 888      Y88P    Y888Y 888  Y8888   Y888  Y888  Y8888  ");
Console.WriteLine("o88888888888888888888888888888888888888888888888888888888888888");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("     Welcome To My Gambling Dungeon. This Will Be Incredible.");

//FRÅGAR OM ANVÄNDAREN VILL VETA REGLERNA
while (rules == true)
{
    Console.WriteLine();
    Console.WriteLine("     Do you want to know how to play? Yes / No");
    Console.WriteLine();

    yesNo = Console.ReadLine();

    if (yesNo == "Yes" || yesNo == "yes")
    {
        Console.WriteLine();
        Console.WriteLine("HOW TO PLAY:");
        Console.WriteLine("     1. CHOOSE the NUMBER (0 - 36), RANGE of NUMBERS (1-12, 13 - 24, 25 - 36, 1- 18, 19 - 36), COLOR (Black / Red) or Even / Odd you think will win. ");
        Console.WriteLine("     2. CHOOSE HOW MUCH YOU WILL BET.");
        Console.WriteLine("     3. THE ROULETTE WHEEL DECIDES IF YOU WIN OR NOT.");
    }
    else if(yesNo == "No" || yesNo == "no")
    {
        Console.WriteLine();
        rules = false;

        graphicsOn = true;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Write Yes or No");
        Console.WriteLine();
    }
}

//FRÅGAR OM ANVÄNDAREN VILL STÄNGA AV ASCII BILDEN PÅ ETT ROULETTE HJUL SKA VARA PÅ
while (graphicsOn == true)
{
    Console.WriteLine("     Do you want to have graphics? Yes / No");
    Console.WriteLine();

    yesNo = Console.ReadLine();

    if (yesNo == "Yes" || yesNo == "yes")
    {
        Console.WriteLine();
        Console.WriteLine("     Graphics have been turned on.");
        choosing = true;
        graphicsOn = false;
        
    }
    else if (yesNo == "No" || yesNo == "no")
    {
        Console.WriteLine();
        Console.WriteLine("Graphics have been turned off");
        choosing = true;
        graphicsOn = false;
        graphics = false;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Write Yes or No");
        Console.WriteLine();
    }
}

while (game == true)
{

    Console.WriteLine("     Choose what to bet on. Type corresponding number");
    Console.WriteLine("            1: Number");
    Console.WriteLine("            2: Range");
    Console.WriteLine("            3: Color");
    Console.WriteLine("            4: Odd/Even");
    Console.WriteLine("            5: Info on Pay-Out Rates");
    Console.WriteLine();








    while (choosing == true)
    {
        Console.WriteLine("     Write your choice:");




        choice = Convert.ToInt32(Console.ReadLine());
        




        //NUMBER

  



        while (choice == 1 && chosenBet == -1)
        {
            Console.WriteLine();
            Console.WriteLine("     Choose number (0-36). If you type an invalid answer, you will exit this menu.");

            chosenBet = Convert.ToInt32(Console.ReadLine());

            if (chosenBet <= 36 && chosenBet >= 0)
            {
                choice = 0;
                betting = true;
                
            }
            else
            {
                choice = 0;
            }

        }






        //RANGE


        while (choice == 2 && chosenRange == -1)
        {
            Console.WriteLine();
            Console.WriteLine("     Choose a range (1: 1 - 12,  2: 13 - 24,  3: 25 - 36,  4: 1 - 18,  5: 19 - 36). If you type an invalid answer, you will exit this menu.");
            Console.WriteLine();
            chosenRange = Convert.ToInt32(Console.ReadLine());

            if (chosenRange <= 5 && chosenRange >= 1)
            {
                choice = 0;
                betting = true;
               
            }
            else
            {
                choice = 0;
            }
        }


        //COLOR






        while (choice == 3 && color == "Not chosen")
        {
            Console.WriteLine();
            Console.WriteLine("     Choose a color (Type Black / Red). If you type an invalid answer, you will exit this menu.");
            Console.WriteLine();
            color = Console.ReadLine();

            if (color == "Black" || color == "black")
            {
                color = "Black";
                choice = 0;
                betting = true;
               
            }
            else if (color == "Red" || color == "red")
            {
                color = "Red";
                choice = 0;
                betting = true;
                
            }
            else
            {
                choice = 0;
            }
        }

        //EVENESS




        while (choice == 4 && evenOdd == "Not chosen")
        {
            Console.WriteLine();
            Console.WriteLine("     Choose Odd / Even.  If you type an invalid answer, you will exit this menu.");
            Console.WriteLine();
            evenOdd = Console.ReadLine();
            if (evenOdd == "Odd" || evenOdd == "odd")
            {
                evenOdd = "Odd";
                choice = 0;
                betting = true;
              
            }
            else if (evenOdd == "Even" || evenOdd == "even")
            {
                evenOdd = "Even";
                choice = 0;
                betting = true;
                
            }
            else
            {
                choice = 0;
            }

        }
        //PAYOUT RATES INFO
        if (choice == 5)
        {
            choice = 0;
            Console.WriteLine();
            Console.WriteLine("PAYOUTS:\r\n     Number: 15x Payout \r\n     Range Thirds: 3x Payout\r\n     Range Half: 2x Payout\r\n     Color: 2x Payout\r\n     Odd/Even: 2x Payout\r\n \r\n  \r\n");
        }



        //Choosing Amount

        while (betting == true)
        {


            Console.WriteLine("You currently have " + money + " chips");
            Console.WriteLine("Choose how much to bet: ");
            Console.WriteLine("");


            bet = Convert.ToInt32(Console.ReadLine());

            if (money - bet > 0)
            {
                betting = false;
                choosing = false;
                spin = true;
                money -= bet;
                Console.WriteLine("     Ok, I see. You want to bet " + bet + " chip(s)? You'll have " + money + " left.");
            }
            else if (money - bet == 0)
            {
                betting = false;
                choosing = false;
                spin = true;
                money -= bet;
                choosing = false;
                Console.WriteLine("     " + bet + " chips!? You're goin' all in!");
            }
            else
            {
                Console.WriteLine("        What are you saying!? Try again kiddo.");
            }


        }

        //ADD more bets here 

        //No more bets D: 

    }





    Random rand = new Random();

    if (spin == true)
    {
        //ROULETTE HJULET

        if (graphics == true)
        {
            Thread.Sleep(1000);
            Console.WriteLine("                                          ===- +%-%.=#%%====                                        \r\n                               -*++=-::   ::. :@@@#:-**+----. .::-:=+*-                             \r\n                       .:-#+-  :==+***==.    +%@=.=#: .:     .==+*=+-:....--::.                     \r\n                  .-=+   .:=%%+.:-:++*@%**: *@#  .  --.*%*=@%**#:::.  .=#@-..  .=:.                 \r\n               .#.   :%@+..:@@*+-.-+*=  ... +@@+: ..*.       .-*%+*==.*#. +*%@#.   .--              \r\n            .=:  .=#*::+#*=:-*+-=.*+=...*---:.#@@@@: .*%%**::      :*%@=#+##%=-*@%:   .=:           \r\n         .=-   =#* -##====. .=+:   =+:=       #@- ##  .-:   -=+:*=.-*:. :=#@%**%+=#@*:   :-.        \r\n       :#.  .#*::##-+*%*#=--.-:     +=. .-   +@:   @@.... :-   .=  .*%=.  ..**###+%@=##:    =.      \r\n     .%    *%-*@+.@===    =+  :----  :+..#%@@@:.    #%@=@%=::: .+=+.=   += .*::+*@*@#+-##    -*     \r\n    =:   -@-=#+-%=-.  .=...:.**:*.=*.%+*%%:=#::-     #===:--@=@@+-:.+=%   .*:   :-#*@%*.=%    :+.   \r\n  :=    :%-#++@%+    =- ..=#-*:+@*+++%**@*%@+:...    :%@%@#@@@#%*%++# =*+:-  =- :%+=-####-%.   .*=  \r\n =-    .@*#=*#-==--:= .=##@::@#@@@#**=  .==@#%=:.    +@+%@%==-..*@+*.-: :%@++. %=.:-#@%*:@*-    .#: \r\n:-    .%@=+#.    .@  *#@#.:%#+@@%.    ..:@@@@@@@@@@@@@@ ...%%@@-..*:.%@%* .:@@: -@#.   +# @@      # \r\n+:    .#*:+%*.:.*# :%#.  =@*@*-::%-:@@%@%: .%#%%@%@%.:@. .-.:.+%::*:=:+:%%*@:.#- %#=+-..#:==     :+:\r\n%.    .==+##==+#*= =@@==:@%=+*%  .+*=.   :@+++* =@@%  .%.=+     .  .+   .=.@+=*%  #@=*=+++++     .#=\r\n=.    .++**: :=%*:.**@@+@###@*@*.      :*@*   +*%::=    -%%-+=:  .+ - #%- --+@@@: #-=  *@#+=      =+\r\n*:     :=*-=  .*=-.@@@@+@@%*@+%@.    =@@:      *#.:       .:=..%+. @:...=%+.....  %=   =@@=       :.\r\n*=      .#%#   .%= - . :-@@%-@.+#  ==@-       #%@           .#*  := =@@@@@*.::-= %+:  :=#.      .## \r\n.#=.     .+#%%%#@% -@@#*-++*#+=**=%#.        -@=%@-        . %+:=.#:+=%@#*#=*@* =-   :#+        *@: \r\n +#*.      .**  .+@= -%#@#+::#%+++@*@#=:    ##.:#%:....: ++=++.=#+. =+==@@%*=..#=   *-         +@:  \r\n  ***:        =#.  +#.-+-+%%=. .###:%@%:-@%::    .:::      .#%..@@@%#@: .-*#.*#@*%@+         .++    \r\n   :*=#         :%# .*% +@@*= #+:.%:-#.:%@-##@-%%@-@@@-#%@-.=@*@.:::+@*:+=.##.%@-=.         #*.     \r\n     :+*#.         -*#=:=  =@%%=+=#%:.:-#.#.=# ..*:..:*   ..+--:-@@+*-:.+%@@+:.           #*.       \r\n       -+=*=:         .::*=*+:+=%%@*:*=@%%++#*++ *:*--.-+. -=*%%-+-::=*+=-             =#=.         \r\n         :#*##+=.            ..**:-::=%#@*-#+#%..%@@-=::+*-  :.::**#:               :#%::           \r\n             +*##-::                   :--         .*.@%*=:.-#=  -              :-**-.              \r\n               .:=%@@*#-                                                  ==#%@+=:.                 \r\n                    .-+%@%*=.                                   :-=+=*##%@%+::                      \r\n                           -**%@@%#+-+-...::.         :   .:---*#@@%##+                             \r\n                                     ++*@@@@@@@@@@@@@@@@@%+++=                                      ");
        }
        Thread.Sleep(100);
        //GENERATE NUMBER 
        Console.WriteLine("\r\n It's time to spin the wheel.");
        result = rand.Next(0, 37);

        //CHECK RANGE
        if (result >= 1 && result <= 12)
        {
            resultRange = 1;
        }
        else if (result >= 13 && result <= 24)
        {
            resultRange = 2;
        }
        else if (result >= 25 && result <= 36)
        {
            resultRange = 3;
        }
        else if (result >= 1 && result <= 18)
        {
            resultRange = 4;
        }
        else if (result >= 19 && result <= 36)
        {
            resultRange = 5;
        }
        //CHECK COLOR

        Randomada = rand.Next(0, 2);
        if (Randomada == 0)
        {
            resultCol = "Red";
        }
        else
        {
            resultCol = "Black";
        }

        //CHECK EVEN

        if (result % 2 == 0)
        {
            resultEven = "Even";
        }
        else
        {
            resultEven = "Odd";
        }

    }
    Thread.Sleep(500);
    Console.WriteLine("     The ball landed on:");
    Thread.Sleep(500);
    Console.WriteLine("     " + result + "! The color is " + resultCol);

    // CHECK IF WIN?
    if (chosenBet == result)
    {
        money += bet * 15;
        Console.WriteLine("You WON! Your Number prediction was correct! You got " + (bet * 15) + " chips!");
        Console.WriteLine();
    }



    if (chosenRange == resultRange && chosenRange <= 3 && chosenRange >= 1)
    {
        money += bet * 3;
        Console.WriteLine("You WON! The number landed in your predicted Range! You got " + (bet * 3) + " chips!");
        Console.WriteLine();
    }
    else if (chosenRange == resultRange && chosenRange <= 5 && chosenRange >= 4)
    {
        money += bet * 2;
        Console.WriteLine("You WON! The number landed in your predicted Range! You got " + (bet * 2) + " chips!");
        Console.WriteLine();
    }

    if (color == resultCol)
    {
        money += bet * 2;
        Console.WriteLine("You WON! You predicted the Color! You got " + (bet * 2) + " chips!");
        Console.WriteLine();
    }

    if (evenOdd == resultEven)
    {
        money += bet * 2;
        Console.WriteLine("You WON! You predicted that it was Even/Odd! You got " + (bet * 2) + " chips!");
        Console.WriteLine();
    }


    //SÄTT TILBAKA BETS TILL DERAS URSPRUNGLIGA VÄRDEN

    chosenBet = -1;
    chosenRange = -1;
    color = "Not chosen";
    evenOdd = "Not chosen";

    //FRÅGAR OM ANVÄNDAREN VILL FORTSÄTTA SPELA. OM MAN HAR SLUT PÅ CHIPS STÄNGS DEN OCKSÅ Av
    shutDown = true;
    while (shutDown == true)
    {
        if (money <= 0)
        {
            Console.WriteLine("     You are out of money. You walk out with empty pockets. \r\n           G A M E  O V E R");
            game = false;
            shutDown = false;
        }
        else
        {

            Console.WriteLine("     Do you want to play again? You have " + money + " chips left. Yes / No");
            yesNo = Console.ReadLine();
            if (yesNo == "Yes" || yesNo == "yes")
            {
                choosing = true;
                betting = false;
                spin = false;
                shutDown = false;
            }
            else if (yesNo == "No" || yesNo == "no")
            {
                Console.WriteLine("You exchanged the chips for money and exited the dungeon. You walked out with $" + (money * 10) + " You have $" + (money * 10 - 100) + " more than what you entered with. Shutting down.");
                game = false;
                shutDown = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Write Yes or No");
                Console.WriteLine();
            }
        }
    }
}
Thread.Sleep(5000);

Console.WriteLine("                       +-#%%                                                                        \r\n                       %+:*%%%@                                                                     \r\n                         *:+#%%%@++#%%%                                                             \r\n                          %+=%%%#.+%%%%%%%                                                          \r\n                           %==#%=.=%%%%%@%%%                                                        \r\n                            %#=*-+-*%%%%%%@%%#                                                      \r\n                             %%*+%:=###%%%@@%%@%#+-+++*#*#%@                                        \r\n                              @%@@*:=*##%%%%*=:.:-++*##########%#%%                                 \r\n                                @@%-..-+*+-..-==*##%##%##%%###%%%%##%%                              \r\n                                  %@#+-....-**###%%%#=:::::::-*%%%%%%%#%%    @%*=======*%           \r\n                                  @#.....-++#%%%%%%%%*-#+=------%%%%%%@%@%@@+...:+###%%%%%          \r\n                                %#:.....:+**#%%%%%%%%%%#%##**##%@%%%%@@@@@@@%*##%%%%%%%%@%*-==+**#%%\r\n                              @#-.......--=+****+=+**#***#%%%%%%%%%%@%%@%%@@@@%%%%%%%%%@@%%%%#%%%%##\r\n                             %-....+*-.......................:+@%#%@@@@@@@@@@@@@%@@@@%%%%%%%%%%%%   \r\n                          @+:.:=-:..............+%@@-............:-*%%%%@@@@@@@@@@@%%@@%%%@%%@      \r\n                        %=.-*=.................*@@@@%:......-##-......-#%%%@%@@@@@@@@@@%%%@         \r\n                     %%-:##-..................-@@@@@#:.....+@@@@+........:*%%%@@@@@@@@@%@           \r\n                   %#-+%@*....................+@@@@@+.....=@@@@@#:..........=#%@@@@@@@%             \r\n                  %-*@@@*.:%@@@#:.............*@@@@%.....-@@@@@@+.............-#@@@@@@@@            \r\n                %+*@@@@%.:%@@@@@@@@%#+-........-++-......=@@@@@@:..............:=%@@@@@%            \r\n               #+@@@@@@#.+@@@@@@@@@@@@@@#.................*@@@#..................-*@@@@@%           \r\n              @%@@@@@@@*.*@@@@@@@@@@@@@@@+.....:::...............................:-+%%@@%           \r\n             @@@@@   %@#.*@@@@@@@@@@@@@@@@=.:+*%@@@@%#+=-:.......................:-+*%@@@%          \r\n            @@@@##%#+%@@:+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%:......::::..........=+##@@@@          \r\n            @@@@@@@@@@@@#-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#...:=**@@@@@%#+-....-*##@@@@@         \r\n             @@@*-.::-----+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#++*%@@@@@@@@@@@@@@#+*#%@@@@@@        \r\n             #=...:---------=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*##@@@@@@@@       \r\n            #:..:-------------@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*#@@@@@@@@@@      \r\n           #:...:-------===-:::=#@@@@@@@@@@@@@@%-:=#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@##%@@@@@@@@@@%     \r\n           +...:--=+*++=..::::----%@@@@@@@@@@@@+-=====-==%@@@@@@@@@@@@@@@@@@@@@@%#%@@@%+@ @@@@%     \r\n           *...::::--=+:.::::----=@@@@@@@@@@@@@@*==---====+*@@@@@@@@@@@@@@@@@@@##%@@@@%=%  @@@@     \r\n           %-..:::::---+:.::----=#%@@@@@@@@@@@@@@@@#++===+*%@@@@@@@@@@@@@@@@@%+#@@@@@@@*=#  @@@%    \r\n            #-..:::::-:--====--=*==+:*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@**%@@@@@@@@@@=-#%@@@    \r\n             %+:..::::::::::::----+@%+::+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+*#@+===*% @@@@@@@@@@@    \r\n               %*:::::::::-::::-=#*+=#*@@+-:=#%%@@@@@@@@@@@@@@@@@@@@%%#++*%@@@@+::--*    %@@@%@@    \r\n                 %+::::::-++--=#*+:...:=*%%%%##*+-:------=-==------=+*%+-:-#@%**=--=*               \r\n               #+........::::-*%*-......+%%%%%%%#**++#@@%%####%%%#+*++*###*+.:::::-+#               \r\n              %-...::--=++-::::-++.....:+-+%%-.........-*%%%@%%+=.......:-=::::-----##              \r\n              %...:::::::::-==::-=%*#+=-:=*+-:..........=###%%*:..-+=-:::::==::-==++#@              \r\n              %:..:::::::::::-==:-=*--#:-:-+--..........*:---+::::-----=+-::-+-::::---+#            \r\n               +..::::::::::::-+=-:-:.:#=---=..........=.:::+::::::::::--==::=+-:::::---*           \r\n               #-..:::::::::::--++::::.-:..............=-:---.:::::::::::-=+::*--::::::--+          \r\n                %=..:::::::::::--+-:::.--................+**:.:::::::::::--==:-+-:::::::-=%         \r\n                 #=..::::::::::::-::::.:=..................-:.:::::::::::-=-+:-*--:::::::-*#        \r\n                   *..:::::::::::::::-::=..................-:.:::::::::::-=*::=*---::::::-*         \r\n                    #:..::::::::::::-===#..................--.::::::::::--+=::*@==---:::-=%         \r\n                     @%-..::::-::::--*%@@@%*+=:............=*.:::::::::::--::=@@@%#*+==+*#          \r\n            @@@@@@@@@@@@%-::-------=#@@@@@@@@@@@@@@@%#***#@@@#-:::::::::::::=%@@@@@@@@@@@@@         \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@#+----=#@@@@@@@@@@@@@@@@@@@@@@@@@@@%=---::::::--=%@@@@@@@@@@@@@@@@@@@    \r\n                      %%%@@%@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#+=----==*@@@@@@@@@@@@@@@@@%@@@    \r\n                                                             @@@@@@@@@@@@@@@@@@@@@@@@@@@@    ");



Console.WriteLine();
Console.WriteLine("/ / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / /" );
Console.WriteLine("     Program Has Shut Down");

