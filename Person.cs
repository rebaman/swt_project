namespace PromilleApp{
    enum geschlect {
        // Verteilungsfaktor im Körper (0,7 für Männer / 0,6 für Frauen)
        mannlich = 0.7 , 
        weiblich = 0.6  
    };
    class Person{
        private string Name { get; set; }
        private geschlect Geschlect {get; set; }
        private int Gewicht {get; set;}
        private int Größe {get; set;}
        Person(){}
    }
}