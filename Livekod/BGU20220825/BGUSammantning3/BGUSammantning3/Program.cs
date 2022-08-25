Console.WriteLine("Hello, BGU!");

int start = 10;

// Loopar från 0 till 4
for (int loop = 0; loop <5; loop++)
{
    Console.WriteLine(loop);
}

// Loopar och lägger till värde
for (int loop = 0; loop < 5; loop++)
{
    Console.WriteLine(loop + start);
}

// Loopar varannan gång
for (int loop = 0; loop < 5; loop += 2)
{
    Console.WriteLine(loop + start);
}

// Loopar baklänges
for (int loop = 10; loop>0; loop--)
{
    Console.WriteLine(loop);
}