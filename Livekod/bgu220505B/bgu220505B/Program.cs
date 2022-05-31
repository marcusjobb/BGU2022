/*
     .---------.
     |  Start  |
     `---------´
          |
     +--------------------+
     |  Ta reda på tiden  |
     +--------------------+
          |
          /\
         /  \   Ja   +--------------------+
        /<12 \-------+ "God morgon"       +--+
        \>6  /       +--------------------+  |
         \  /                                |
          \/                                 |
           |                                 |
          /\                                 |
         /  \   Ja   +--------------------+  |
        /<18 \-------+ "God eftermiddag"  +--|
        \    /       +--------------------+  |
         \  /                                |
          \/                                 |
           |                                 |
           |                                 |
          /\                                 |
         /  \   Ja   +--------------------+  |
        /<20 \-------+ "God Kväll"        +--|
        \    /       +--------------------+  |
         \  /                                |
          \/                                 |
           |                                 |
           |                                 |
          /\                                 |
         /  \   Ja   +--------------------+  |
        />20 \-------+ "God natt"         +--| 
        \    /       +--------------------+  |
         \  /                                |
          \/                                 |
           |                                 |
           |                                 |
           |---------------------------------+                                
     .---------.
     |  End    |
     `---------´
*/

// Frågar DateTime.Now vilken timme det är
int hour = DateTime.Now.Hour;
string greeting = "God natt";
if(hour > 6)
{
    if(hour < 12) greeting = "God morgon";
    else if(hour < 18) greeting = "God eftermiddag";
    else if(hour < 20) greeting = "God kväll";
    else if(hour > 20) greeting = "God natt";
}

Console.WriteLine("Timmen är " + hour);
Console.WriteLine(greeting);
