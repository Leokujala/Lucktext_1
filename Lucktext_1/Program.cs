string name = "";
string food = "";
string drink = "";



Console.WriteLine ("Hej, vad heter du?");
name = Console.ReadLine ();

Console.WriteLine ("Nämn en udda sak att äta.");
food = Console.ReadLine ();

Console.WriteLine ("Nämn en udda sak att dricka.");
drink = Console.ReadLine ();

Console.WriteLine ($"Tja {name}, du måste sluta med att äta {food}. En dag kommer det ta kol på dig.");
Console.WriteLine ($"Man kan säga detsamma om hur mycket {drink} du häller i dig! ");



Console.ReadLine();
