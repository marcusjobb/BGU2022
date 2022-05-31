namespace BGU_GissaTal;

public class Story
{
    public Story()
    {
        SetStory(0); // Sätter alla värden till standard
    }

    public string Guess { get; set; }
    public string Intro { get; set; }
    public string LostGame { get; set; }
    public string TooHigh { get; set; }
    public string TooLow { get; set; }
    public string WinGame { get; set; }
    public void SetStory(int story)
    {
        switch(story)
        {
            case 1: // UFO
                Guess = "Kapten du måste välja en koordinat mellan {0} och {1}";
                TooHigh = "Kapten, din gissning var för hög";
                TooLow = "Kapten, din gissning var för låg";
                WinGame = "Kapten! Du har sprängt UFOt! Yay! Världens popcorn är trygg igen!";
                LostGame = "Oh Noes! Kapten du schabblade och UFOt snodde all popcorn i världen!!!";
                Intro = "Ett rymdskepp är på väg mot din stad och ska stjäla all världens popcorn" + Environment.NewLine +
                        "Du måste skicka upp en missil, med koordinater mellan {0} och {1}" + Environment.NewLine +
                        "Du har 10 försök innan rymdskeppet landar och stjäl all popcorn från jorden";
                break;

            default: // Standardvärden
                TooHigh = "Du gissade för högt";
                TooLow = "Du gissade för lågt";
                WinGame = "Du gissade rätt";
                LostGame = "Du förlorade!";
                break;
        }
    }
}