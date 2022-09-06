using Kordamine_OOP_1;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Koduloom kass = new Koduloom("Murka", "punane", 'E', 5.5, 7, true);
//kass.print_Info();
//Koduloom kassKloon = new Koduloom(kass);
//kassKloon.muuda_Nimi("Murkakloon");
//kassKloon.muuda_Sugu('I');
//kassKloon.muuda_Kaal 5.2;
//kassKloon.print_Info();

// Koer koer = new Koer("lambakoer", "Gray", "must", Koduloom.sugu.isane, 15.0, 10, true);
// koer.print_Info();

//Tootaja tootaja = new Tootaja();
//tootaja.amet = "Klienditeenindaja";

//tootaja.arvutaSissetulek(2.0, 5.0);
//tootaja.muudaNimi("Oleg");
//tootaja.tunnitasu = 6.0;
//tootaja.tootasu = 600;
//double tootunnid = tootaja.arvutaTootunnid();
//Console.WriteLine(tootunnid);
//tootaja.muudaAmet("juhataja");

//Kutsekooliopilane ko = new Kutsekooliopilane();
//ko.lisaTund("programmerimine");
//ko.lisaTund("matemaatika");


Opilane opilane = new Opilane();
opilane.eriala("Programmerija");

opilane.lisaAine("informaatika");
opilane.lisaHinne("informaatika", 4);
opilane.vaataHinded();
opilane.lisaAine("matemaatika");
opilane.vaataHinded();

opilane.lisaHinne("informaatika", 5);
//opilane.vaataHinded();
opilane.vaataHindedAineKohta("informaatika");
opilane.eemaldaAine("matemaatika");




//Isik inimene = new Opilane("Nikita", 2003, Isik.Sugu.mees, "tthk", "Programmeerija", 5000, 30.76);
//inimene.printinfo();
//int a = inimene.arvutaVanus();
//Console.WriteLine(a);
//inimene.printinfo();
