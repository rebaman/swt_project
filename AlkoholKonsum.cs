namespace PromilleApp{
    enum Alkohol{
        //Vol.-%
        Bier = 5.0,
        Wein = 12.5, 
        Schnaps = 40.0,
        Cocktail = 40.0 
    }
    class AlkoholKonsum{
        // Konsumierte Getränke
        static double   Bier { get; set; }  //0,3 Liter Bier (5 Vol.-%)
        static double Wein { get; set; }   //0,1 Liter Wein/Sekt (12,5 Vol.-%)
        static double Schnaps { get; set; }  //4 cl Schnaps/Spirituosen (40 Vol.-%)
        static double Cocktail { get; set; }   // 0,1 Liter Cocktail mit 4cl Schnaps (40 Vol.-%)

    }

}