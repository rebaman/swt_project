

namespace PromilleApp{
    // Widmark Formel
    // 1 Promille BAK = 1 Liter Blut enthält 1 Milliliter reinen Alkohol.

    // Menge in ml x (Vol.-% / 100) x 0,8 = Gramm reiner Alkohol
    // Aufgenommene Alkoholmenge in Gramm / (Körpergewicht in Kilogramm x Anteil Körperflüssigkeit) = BAK (Promille) 

     int AufgenommeneAlkoholmengeInGramm = AlkoholKonsum.Bier.get()*Alkohol.Bier*0.8 + AlkoholKonsum.Wein.get()*Alkohol.Wein*0.8 + AlkoholKonsum.Schnaps.get()*Alkohol.Schnaps*0.8 + AlkoholKonsum.Wein.get()*Alkohol.Wein*0.8 + AlkoholKonsum.Cocktail.get()*Alkohol.Cocktail*0.8;
     int Promille = AufgenommeneAlkoholmengeInGramm / (Person.Gewicht * Person.Geschlecht); // Geschlecht wird in Verbindung mit Verteilungsfaktor gesetzt

}