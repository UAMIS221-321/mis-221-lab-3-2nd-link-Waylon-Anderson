//Start Main


string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);

DisplayStadiumDetails(stadium, game);

//End Main


// User input for the enjoyment level they want
static string GetEnjoymentLevel(){
    Console.Clear();
    System.Console.WriteLine("What's the level of enjoyment you would like at your game? \nBoring\nAverage\nFun\nEpic");
    return (System.Console.ReadLine().ToLower());
}

// Selecting stadium based off of enjoyment
static string GetStadiumRecommendation(string enjoymentLevel){
    string stadium = null;
    if (enjoymentLevel == "epic"){
         stadium = "Saban Field at Bryant-Denny Stadium";
    }
    else if (enjoymentLevel == "fun"){
         stadium = "Tiger Stadium";
    }
    else if (enjoymentLevel == "average"){
         stadium = "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "boring"){
         stadium = "Neyland Stadium";
    }
    else{
        Console.Clear();
    }
    return stadium;
}

// Selecting game based off of stadium
static string GetGameRecommendation(string stadium){
    string game = null;
    if (stadium == "Saban Field at Bryant-Denny Stadium"){
         game = "Auburn";
    }
    else if (stadium == "Tiger Stadium"){
         game = "Alabama";
    }
    else if (stadium == "Jordan-Hare Stadium"){
         game = "Kentucky";
    }
    else if (stadium == "Neyland Stadium"){
         game = "Kent State";
    }
    else{
        System.Console.WriteLine("This was not a valid choice.");
    }
    return game;
}

// Displaying the game and stadium for the user
static void DisplayStadiumDetails(string stadium, string game){
    if (stadium == "Saban Field at Bryant-Denny Stadium" && game == "Auburn"){
        Console.Clear();
        System.Console.WriteLine("I recommend the game vs "+game+" at the stadium "+stadium);
    } 
    else if (stadium == "Tiger Stadium" && game == "Alabama"){
        Console.Clear();
        System.Console.WriteLine("I recommend the game vs "+game+" at the stadium "+stadium);
    }
    else if (stadium == "Jordan-Hare Stadium" && game == "Kentucky"){
        Console.Clear();
        System.Console.WriteLine("I recommend the game vs "+game+" at the stadium "+stadium);
    }
    else if (stadium == "Neyland Stadium" && game == "Kent State"){
        Console.Clear();
        System.Console.WriteLine("I recommend the game vs "+game+" at the stadium "+stadium);
    }
}