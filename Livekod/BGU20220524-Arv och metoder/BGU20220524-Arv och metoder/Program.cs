// See https://aka.ms/new-console-template for more information
using BGU20220524_Arv_och_metoder;

Console.WriteLine("Instruments");

Piano p = new Piano();
Trumpet t = new Trumpet();

PlayMusic(p);
PlayMusic(t);

void PlayMusic(Instrument instrument)
{
    Console.WriteLine(instrument);
    instrument.Play();
    Console.WriteLine();
}