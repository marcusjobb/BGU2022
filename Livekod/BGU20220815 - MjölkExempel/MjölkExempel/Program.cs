// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Gå till butiken, handla 1 paket mjök. Om det finns ägg handla 6 st");

//Mjölk = 1
int mjölk = 1;
bool eggs = false;

//Om Ägg finns 
//Mjölk = 6
if (eggs == true)
    mjölk = 6;
else
    mjölk = 1;

//Handla mjölk
Console.WriteLine($"Handlar {mjölk}st paket mjölk");
//Gå hem
