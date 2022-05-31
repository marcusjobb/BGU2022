namespace BGU_Klasser20220517 // Hyreshus
{
    using System;
    using System.Collections.Generic;

    public static class Program // Lägenhet
    {
        public static void Main() // Rum i lägenheten
        {
            // instansierar PersonDTO, alltså skapar ett objekt av det
            var Batman = new PersonPOCO();
            Batman.Age = 37;
            Batman.Lastname = "Wayne";
            Batman.Name = "Bruce";

            var Robin = new PersonPOCO();
            Robin.Name = "Dick";
            Robin.Lastname = "Grayson";
            Robin.Age = 21;

            Robin.PrintName();
            Batman.PrintName();
        }
    }
}