using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fridolin
{
    class Program
    {
        static void Main(string[] args)


        {
            //Nationen
            Nation Frankreich = new Nation("Frankreich", 20, 3); //Karte 4 auswählen noch basteln!
            Nation Hannover = new Nation("Hannover",12, 2);
            Nation Preußen = new Nation("Preußen", 32, 7);
            Nation Schweden = new Nation("Schweden", 4, 1);
            Nation Sachsen = new Nation("Sachsen", 6, 1);


            //Liste Allies
            Hannover.allies.add(Preußen);
            Preußen.allies.add(Hannover);
            Frankreich.allies.add(Schweden); //für special szenario
            Schweden.allies.add(Frankreich); //für special szenario
            Sachsen.allies.add(Schweden, Frankreich);


            
            //Städte

            // 2:=Karo 3:=Herz 5:=Pik 7:=Kreuz

            Town lx = new Town("Lücke", 0, Schweden); //Lückenfüller 

            //sortiert nach Gebieten

            //3.1 - Herz(Fr+Ha) von Boppard bis Miltenberg (15) - ready
            Town Bingen = new Town("Bingen", 3, Frankreich);
            Town Mainz = new Town("Mainz", 3, Frankreich);
            Town Wiesbaden = new Town("Wiesbaden", 3, Frankreich);
            Town Boppard = new Town("Boppard", 3, Frankreich);
            Town Oppenheim = new Town("Oppenheim", 3, Frankreich);
            Town Worms = new Town("Worms", 3, Frankreich);
            Town Mannheim = new Town("Mannheim", 3, Frankreich);
            Town Bensheim = new Town("Bensheim", 3, Frankreich);
            Town Darmstadt = new Town("Darmstadt", 3, Frankreich);
            Town Frankfurt = new Town("Frankfurt", 3, Frankreich);
            Town Hanau = new Town("Hanau", 3, Hannover);
            Town Aschaffenburg = new Town("Aschaffenburg", 3, Frankreich);
            Town Gelnhausen = new Town("Gelnhausen", 3, Frankreich);
            Town Erbach = new Town("Erbach", 3, Frankreich);
            Town Miltenberg = new Town("Miltenberg", 3, Frankreich);

            //5.1 - Pik(Fr) Gemünden bis Erlangen (14) - ready
            Town Lohr = new Town("Lohr", 5, Frankreich);
            Town Wertheim = new Town("Wertheim", 5, Frankreich);
            Town Ochsenfurt = new Town("Ochsenfurt", 5, Frankreich);
            Town Kitzingen = new Town("Kitzingen", 5, Frankreich);
            Town Neustadt = new Town("Neustadt", 5, Frankreich);
            Town Erlangen = new Town("Erlangen", 5, Frankreich);
            Town Forchheim = new Town("Forchheim", 5, Frankreich);
            Town Bamberg = new Town("Bamberg", 5, Frankreich);
            Town Coburg = new Town("Coburg", 5, Frankreich);
            Town Haßfurt = new Town("Haßfurt", 5, Frankreich);
            Town Schweinfurt = new Town("Schweinfurt", 5, Frankreich);
            Town Kissingen = new Town("Kissingen", 5, Frankreich);
            Town Gemünden = new Town("Gemünden", 5, Frankreich);
            Town Würzburg = new Town("Würzburg", 5, Frankreich);
            
            //7.1 - Kreuz(Fr+Ha) von Olpe bis Nauheim (19) - ready
            Town Koblenz = new Town("Koblenz", 7, Frankreich);
            Town Limburg = new Town("Limburg", 7, Frankreich);
            Town Weilburg = new Town("Weilburg", 7, Frankreich);
            Town Wetzlar = new Town("Wetzlar", 7, Frankreich);
            Town Gießen = new Town("Gießen", 7, Frankreich);
            Town Nauheim = new Town("Nauheim", 7, Frankreich);
            Town Homburg = new Town("Homburg", 7, Frankreich);
            Town Betzdorf = new Town("Betzdorf", 7, Frankreich);
            Town Waldbröll = new Town("Waldbröll", 7, Frankreich);
            Town Olpe = new Town("Olpe", 7, Frankreich);
            Town Meschede = new Town("Meschede", 7, Frankreich);
            Town Siegen = new Town("Siegen", 7, Frankreich);
            Town Biedenkopf = new Town("Biedenkopf", 7, Frankreich);
            Town Dillenburg = new Town("Dillenburg", 7, Frankreich);
            Town Marburg = new Town("Marburg", 7, Hannover);
            Town Frankenberg = new Town("Frankenberg", 7, Hannover);
            Town Corbach = new Town("Corbach", 7, Frankreich);
            Town Wildungen = new Town("Wildungen", 7, Hannover);
            Town Alsfeld = new Town("Alsfeld", 7, Frankreich);

            //2.1 - Karo(Fr+Ha+Sa) von Kassel bis Sonneberg (24) - check
            Town Fritzlar = new Town("Fritzlar", 2, Hannover);
            Town Hünfeld = new Town("Hünfeld", 2, Frankreich);
            Town Lauterbach = new Town("Lauterbach", 2, Frankreich);
            Town Fulda = new Town("Fulda", 2, Frankreich);
            Town Schlüchtern = new Town("Schlüchtern", 2, Hannover);
            Fort Kassel = new Fort("Kassel", 2, Hannover, Frankreich);
            Town Bebra = new Town("Bebra", 2, Hannover);
            Town Hersfeld = new Town("Hersfeld", 2, Hannover);
            Town Sontra = new Town("Sontra", 2, Hannover);
            Town Eschwege = new Town("Eschwege", 2, Hannover);
            Town Mühlhausen = new Town("Mühlhausen", 2, Frankreich);
            Town Langensalza = new Town("Langensalza", 2, Sachsen);
            Town Eisenach = new Town("Eisenach", 2, Frankreich);
            Town Gotha = new Town("Gotha", 2, Frankreich);
            Town Erfurt = new Town("Erfurt", 2, Frankreich);
            Town Sömmerda = new Town("Sömmerda", 2, Frankreich);
            Town Arnstadt = new Town("Arnstadt", 2, Frankreich);
            Town Salzungen = new Town("Salzungen", 2, Frankreich);
            Town Brückenau = new Town("Brückenau", 2, Frankreich);
            Town Meiningen = new Town("Meiningen", 2, Frankreich);
            Town Hildburghausen = new Town("Hildburghausen", 2, Frankreich);
            Town Sonneberg = new Town("Sonneberg", 2, Frankreich);
            Town Schmalkalden = new Town("Schmalkalden", 2, Hannover);
            Town Suhl = new Town("Suhl", 2, Frankreich);

            //3.2 - Herz(Fr+Ha+Pr) von Greven bis Warburg (2/17) - !!!
            Town Iserlohn = new Town("Iserlohn", 3, Frankreich);
            Town Soest = new Town("Soest", 3, Preußen);
            
            //5.2 - Pik(Ha+Fr+Pr) von Wunstorf bis Nordhausen (4/26) - !!!
            Town Alfeld = new Town("Alfeld", 5, Hannover);
            Town Northeim = new Town("Northeim", 5, Hannover);         
            Town Münden = new Town("Münden", 5, Hannover);
            Fort Göttingen = new Fort("Göttingen", 5, Hannover, Frankreich);        
            

            //Nachbarstädte

            //3.1 - 15 - check
            Bingen.towns.add(Mainz, Boppard);
            Mainz.towns.add(Bingen, Wiesbaden, Oppenheim);
            Wiesbaden.towns.add(Mainz, Limburg, Frankfurt);
            Boppard.towns.add(Koblenz, Bingen);
            Oppenheim.towns.add(Mainz, Worms);
            Worms.towns.add(Oppenheim, Mannheim);
            Mannheim.towns.add(Bensheim, Worms);
            Bensheim.towns.add(Darmstadt, Mannheim, Erbach);
            Darmstadt.towns.add(Frankfurt, Bensheim, Aschaffenburg);
            Frankfurt.towns.add(Hanau, Wiesbaden, Darmstadt, Homburg);
            Hanau.towns.add(Frankfurt, Aschaffenburg, Gelnhausen, Nauheim);
            Aschaffenburg.towns.add(Hanau, Darmstadt, Lohr, Miltenberg);
            Gelnhausen.towns.add(Schlüchtern, Hanau);
            Erbach.towns.add(Bensheim, Miltenberg);
            Miltenberg.towns.add(Erbach, lx);

            //5.1 - 14 - check
            Lohr.towns.add(Aschaffenburg, lx);
            Gemünden.towns.add(Lohr, Würzburg, Kissingen, Schlüchtern);
            Würzburg.towns.add(Gemünden, Schweinfurt, Wertheim, Kitzingen);
            Wertheim.towns.add(Miltenberg, Ochsenfurt, Würzburg);
            Ochsenfurt.towns.add(Wertheim, Kitzingen);
            Kitzingen.towns.add(Würzburg, Ochsenfurt, Neustadt);
            Neustadt.towns.add(Kitzingen, Erlangen, Bamberg);
            Erlangen.towns.add(Neustadt, Forchheim, lx);
            Forchheim.towns.add(Erlangen, Bamberg);
            Bamberg.towns.add(Neustadt, Forchheim, Haßfurt, Coburg, lx);
            Coburg.towns.add(Bamberg, lx);
            Haßfurt.towns.add(Bamberg, Schweinfurt);
            Schweinfurt.towns.add(Haßfurt, Würzburg, Kissingen);
            Kissingen.towns.add(Gemünden, Schweinfurt, lx, lx);
            
            //7.1 - 19 - check
            Koblenz.towns.add(Boppard, Limburg, Betzdorf);
            Limburg.towns.add(Wiesbaden, Koblenz, Weilburg);
            Weilburg.towns.add(Limburg, Wetzlar);
            Wetzlar.towns.add(Weilburg, Wetzlar, Dillenburg);
            Gießen.towns.add(Wetzlar, Nauheim, Marburg, Lauterbach);
            Nauheim.towns.add(Gießen, Homburg, Hanau);
            Homburg.towns.add(Nauheim, Frankfurt);
            Betzdorf.towns.add(Waldbröll, Siegen, Koblenz);
            Waldbröll.towns.add(Olpe, Betzdorf);
            Siegen.towns.add(Olpe, Biedenkopf, Dillenburg, Betzdorf);
            Biedenkopf.towns.add(Siegen, Marburg);
            Dillenburg.towns.add(Siegen, Marburg, Wetzlar);
            Marburg.towns.add(Biedenkopf, Dillenburg, Gießen, Alsfeld, Frankenberg);
            Alsfeld.towns.add(Marburg, Fritzlar, Hünfeld, Lauterbach);
            Frankenberg.towns.add(Corbach, Wildungen, Marburg);
            Corbach.towns.add(Frankenberg, lx, lx);
            Wildungen.towns.add(Frankenberg, Fritzlar);
            Meschede.towns.add(Olpe, lx);
            Olpe.towns.add(Meschede, Waldbröll, Siegen, Iserlohn);
            
            //2.1 - 24 - check
            Fulda.towns.add(Schlüchtern, Lauterbach, Hünfeld, Brückenau);
            Schlüchtern.towns.add(Gelnhausen, Fulda, lx);
            Fritzlar.towns.add(Alsfeld, Kassel, Wildungen);
            Kassel.towns.add(Fritzlar, Münden, lx, lx);
            Lauterbach.towns.add(Fulda, Gießen, Alsfeld);
            Hünfeld.towns.add(Fulda, Alsfeld, Salzungen, Hersfeld);
            Eschwege.towns.add(lx, Göttingen, Sontra);
            Mühlhausen.towns.add(lx, lx, Langensalza);
            Sontra.towns.add(Eschwege, Eisenach, Bebra);
            Langensalza.towns.add(Mühlhausen, Gotha);
            Bebra.towns.add(Kassel, Sontra, Hersfeld, Salzungen);
            Eisenach.towns.add(Sontra, Gotha, Salzungen);
            Sömmerda.towns.add(lx, Erfurt);
            Gotha.towns.add(Langensalza, Erfurt, Eisenach);
            Erfurt.towns.add(Sömmerda, Gotha, Arnstadt, lx);
            Hersfeld.towns.add(Bebra, Hünfeld);
            Salzungen.towns.add(Eisenach, Bebra, Hünfeld, Schmalkalden, Meiningen);
            Arnstadt.towns.add(Erfurt, lx);
            Meiningen.towns.add(Suhl, Salzungen, Hildburghausen, Kissingen);
            Suhl.towns.add(Schmalkalden, Meiningen);
            Brückenau.towns.add(Fulda, Kissingen);
            Hildburghausen.towns.add(Meiningen, Sonneberg);
            Sonneberg.towns.add(Hildburghausen, lx, Coburg, lx);
            Schmalkalden.towns.add(Salzungen, Suhl);

            //3.2 - 2/... - 
            Iserlohn.towns.add(Olpe, Soest);
            Soest.towns.add(Iserlohn, lx, lx);
            
            
            //5.2 - 4/... - 
            Alfeld.towns.add(Northeim, lx, lx);
            Northeim.towns.add(Alfeld, Göttingen, lx, lx);
            Göttingen.towns.add(Northeim, Münden, lx, lx, lx);
            Münden.towns.add(Kassel, Göttingen);
           
            
            General Cumberland = new General("Cumberland", Alfeld, Hannover); 

            General Chevert = new General("Chevert", Iserlohn, Frankreich);
            General Soubise = new General("Soubise", Fulda, Frankreich);
            General Richelieu = new General("Richelieu", Iserlohn, Frankreich);

            General vHildburghausen = new General("vHildburghausen", Hildburghausen, Sachsen); //kann nicht Hildburghausen heißen, da die stadt schon so heißt... :(
            
            
            //Tests

           
            //System.Console.WriteLine(Koblenz.towns.resultString());
            //System.Console.WriteLine(Wiesbaden.towns.resultString());
            //System.Console.WriteLine(Dillenburg.reachDefense(3).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(2).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(1).resultString());
            //System.Console.WriteLine(Frankreich.generals.resultString());
            //System.Console.WriteLine(Hannover.generals.resultString());
            //System.Console.WriteLine(Preußen.generals.resultString());
            //System.Console.WriteLine(Schweden.generals.resultString());
            //System.Console.WriteLine(Schweden.allies.resultString());
            //System.Console.WriteLine(Fulda.towns.resultString());
            //System.Console.WriteLine(Worms.reachSupply(6,Frankreich).resultString());
            //Wiesbaden.inTown.add(Cumberland); // Das sollte auskommentiert werden weil es unsere Daten kaputt macht ;)
            System.Console.WriteLine(Kassel.reachSupply(15, Frankreich).resultString()); //15 schaffe ich in unter 20 sek :) aber 20 dauert länger als 7 min (hab da abgebrochen), aber wir brauchen ja max. 6 ;)
            System.Console.ReadKey();
             
 
        }
    }


    //Klassen
    public class Character
    {      
        public static int counter;
        public int id;
        public Town position;
        public Nation nation;
        public int movePoints;

        public Character(Town newTown, Nation newNation, int newMovePoints)
        { 
            id = counter;
            counter++;
            nation = newNation;
            position = newTown;
            movePoints = newMovePoints;
        }

        public void move(Town targetTown) //Fang doch schonmal an hierdran zu arbeiten
        {
            //Methode um eine Figur ein Feld weiter zu schieben
            //mir fällt auf, wir brauchen für den move Befehl gar keine reachBefehle... uups xD
            //Sollte eig gar nicht so schwer sein... Fang einfach an zu schreiben und vor allem, trau dich :)
            // Meine erste Überlegung wäre: Was muss ich überprüfen? 
            //z.b. ob die Städte nebeneinander sind, oder ob da nicht nen gegnerischer General drinsteht... (Tipp: sowas ähnliches hab ich schon im reachSupply gemacht)
            //und dann natürlich die Figur eins weiterschieben ;)
            
        }        
    }

    public class General : Character
    {
        public bool supply = true; 
        public int army = 1;
        public bool onRetreat = false;
        public string name;

        public General(string newName, Town newTown, Nation newNation):base(newTown, newNation, 12)
        { 
            name = newName;

            newNation.generals.add(this);

        }
    }

    public class Baggage : Character
    {
        public Baggage(Town newTown, Nation newNation):base(newTown, newNation, 9)
        {

        }
    }

    public class Town
    {
        public String name;
        public static int counter = 0;
        public int id;
        public int tacticalColor;
        public Nation nation;
        public Listing towns;
        public Listing inTown;

        public Town(String newName, int newTacticalColor, Nation newNation)
        {
            id = counter;
            counter++;
            name = newName;
            tacticalColor = newTacticalColor;
            nation = newNation;
            towns = new Listing();
            inTown = new Listing();
        }
    
         public Listing reachDefense(int distance) // Startmethode
         {
             Town tow;
             
             Listing result = new Listing();
            if (distance > 0)
            {
                ListElement a = towns.head;
                do
                {
                  a = a.next;
                  if (!result.search(a.data))
                  {
                      result.add(a.data);
                  }
                  if (distance > 1)
                  {
                      if (a.data.GetType() == typeof(Town))
                      {
                          tow = (Town)a.data;
                          tow.reachDefense(distance - 1, result); //KEINE AHNUNG - Rapha -- Genau wie bei der resultString-Methode - Maddin
                      }
                  }
                  
                 }while(a.next != null);
                return result;

            }
            return result;
           }

        public void reachDefense(int distance, Listing result) // methode bezüglich versorgung und abdeckung
        {
            Town tow;
            //Console.WriteLine(name+": reachDefense("+distance+", "+result.resultString()+")");
            if (distance > 0)
            {
                ListElement a = towns.head;
                while (a.next != null)
                {
                    a = a.next;
                    if (!result.search(a.data))
                    {
                        result.add(a.data);
                    }
                    if (distance > 1)
                    {
                        if (a.data.GetType() == typeof(Town))
                        {
                            tow = (Town)a.data;
                            tow.reachDefense(distance - 1, result); //KEINE AHNUNG - Rapha -- Genau wie bei der resultString-Methode - Maddin
                        }
                    }

                }
            }    

        }
        public Listing reachSupply(int distance, Nation nation) //ähnlich wie reachDefense, nur schaut es, ob gegnerische Charaktere den Nachschub blockieren
        {
            Town tow;
            Listing result = new Listing();
            if (distance > 0)
            {
                ListElement a = towns.head;
                ListElement b;
                Character cha;
                bool isEnemy;
                while (a.next != null)
                {
                    a = a.next;
                    isEnemy = true;
                    if (!result.search(a.data))
                    {
                        result.add(a.data);
                    }
                    if (distance > 1)
                    {
                        if (a.data.GetType() == typeof(Town))
                        {
                            tow = (Town)a.data;
                            b = tow.inTown.head;
                            if (b.next == null)
                                isEnemy = false;
                            while (b.next != null)
                            {
                                b = b.next;
                                cha = (Character)b.data;
                                if (cha.nation == nation || nation.allies.search(cha.nation))
                                    isEnemy = false;
                            }
                            if (!isEnemy)
                                result.add(tow.reachSupply(distance - 1, nation));
                        }
                    }

                }
            }
            return result;
        }
    }// class Town Ende

    public class Fort : Town
    {
        public Nation conquerNation;
        public bool conquered=false;
        public Fort(String newName, int newTacticalColor, Nation newNation, Nation newConquerNation):base(newName, newTacticalColor, newNation)
        {
            conquerNation = newConquerNation;
        }
        //Problem mit Fragezeichen - Abgegdeckte Festung, durch Vertreibung nach Kampf nicht mehr abgedeckt
    }

    public class Nation
    {
        public String name;
        public Listing generals;
        public Listing forts;
        public Listing cards;
        public Listing startTowns;
        public Listing allies;
        public int maxArmies;
        public int cardsPerRound;

        public Nation(String newName, int newMaxArmy, int newCardsPerRound)
        {
            generals = new Listing();
            forts = new Listing();
            cards = new Listing();
            startTowns = new Listing();
            allies = new Listing();
            name = newName;
            maxArmies = newMaxArmy;
            cardsPerRound = newCardsPerRound;
        }
    }

    public class Card
    {
        public static int counter;
        public int id=0;
        public int tacticalColor;
        public int value;
        public Card(int newTacticalColor, int newValue)
        {
            // 2:=Karo 3:=Herz 5:=Pik 7:=Kreuz
            tacticalColor = newTacticalColor;
            id = counter;
            counter++;
            newValue = value; //value element aus [2, 13] + {1-10}
        }
    }

 
    public class Listing
    {
        public ListElement head;
        public int number = 0;

        public void add(Listing newListing) //Methode um ganze Listen zusammenzufügen
        {
            ListElement temp = newListing.head;
            while (temp.next != null) //solange temp nicht das letzte Listenelement ist, dann
            {
                temp = temp.next; //gehe zum nächsten Listenelement
                if (!this.search(temp.data))
                    this.add(temp.data); //und füge dessen data zur eigentlichen Liste hinzu
            }

        }


        public void add(Object newObject1)
        {
            ListElement newElement = new ListElement(newObject1);
            newElement.next = head.next;
            head.next = newElement;
            number++; //erhöhe Listenanzahl
        }

        public void add(Object newObject1, Object newObject2)
        {
            ListElement newElement1 = new ListElement(newObject1);
            ListElement newElement2 = new ListElement(newObject2);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            head.next = newElement2;
            number += 2; //erhöhe Listenanzahl
        }

        public void add(Object newObject1, Object newObject2, Object newObject3)
        {
            ListElement newElement1 = new ListElement(newObject1);
            ListElement newElement2 = new ListElement(newObject2);
            ListElement newElement3 = new ListElement(newObject3);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            head.next = newElement3;
            number += 3; //erhöhe Listenanzahl
        }

        public void add(Object newObject1, Object newObject2, Object newObject3, Object newObject4)
        {
            ListElement newElement1 = new ListElement(newObject1);
            ListElement newElement2 = new ListElement(newObject2);
            ListElement newElement3 = new ListElement(newObject3);
            ListElement newElement4 = new ListElement(newObject4);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            newElement4.next = newElement3;
            head.next = newElement4;
            number += 4; //erhöhe Listenanzahl
        }

        public void add(Object newObject1, Object newObject2, Object newObject3, Object newObject4, Object newObject5)
        {
            ListElement newElement1 = new ListElement(newObject1);
            ListElement newElement2 = new ListElement(newObject2);
            ListElement newElement3 = new ListElement(newObject3);
            ListElement newElement4 = new ListElement(newObject4);
            ListElement newElement5 = new ListElement(newObject5);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            newElement4.next = newElement3;
            newElement5.next = newElement4;
            head.next = newElement5;
            number += 5; //erhöhe Listenanzahl
        }

        public bool search(Object toFind) //das fragt die liste ob das einzutragende schon in der liste ist
        {
            return head.find(toFind);
        }

        public void remove(Object toRemove) //Methode zum löschen eines Objektes aus einer Liste
        {
           if (head.rm(toRemove)) //Start am Kopf
           {
               number--; //verringere Listenanzahl
           }
        }

        public Listing()
        {
            head = new ListElement(null);
        }


        public String resultString() //debugMethode, um Listen auszugeben
        {
            String result = "";
            ListElement a = head.next;
            Town tow; //ab hier Hilfsvariablen erstellen, eig. wird immer nur eine davon gebraucht
            General gen;
            Nation nat;
            Baggage bag;
            Card car;
            for (int i = 1; i < number+1; i++)
            {
                if (a.data.GetType() == typeof(Town)) //Falls das Object ein Town ist,
                {
                    tow = (Town)a.data; //dann spreche es nicht mehr als Object, sondern als Town an ;)
                    if (i == 1)
                    {
                        result += "Städte: ";
                    }
                    result += i + ". " + tow.name + ", "; //Weil object keine "name"-Variable hat...
                }
                if (a.data.GetType() == typeof(General))
                {
                    gen = (General)a.data;
                    if (i == 1)
                    {
                        result += "Generäle von " + gen.nation.name + ": ";
                    }
                    result += i + ". " + gen.name + ", ";
                }
                if (a.data.GetType() == typeof(Nation))
                {
                    nat = (Nation)a.data;
                    if (i == 1)
                    {
                        result += "Verbündete: ";
                    }
                    result += i + ". " + nat.name + ", " ;
                }
                if (a.data.GetType() == typeof(Baggage))
                {
                    bag = (Baggage)a.data;
                    result += i + ". Tross" + ", ";
                }
                if (a.data.GetType() == typeof(Card)) //Das könnte noch schöner gemacht werden.. z.b. mit tacticalColor anzeigen
                {
                    car = (Card)a.data;
                    result += i + ". " + car.value + ", ";
                }
                a = a.next;
            }
            if (result == "")
                result = "leer";
            return result;
        }
        

   }

    public class ListElement
    {
        public ListElement next;
        public Object data;
        public ListElement(Object newObject)
        {
            data = newObject;
        }
        public bool rm(Object toRemove)
        {
            if (next.data == toRemove) //falls der Inhalt des nächsten Objekt das löschende ist
            {
                next = next.next; //überspringe dieses Objekt
                return true;
            }

            if (next.next == null) //falls das Ende der Liste, dann beende
            {
               return false;
            }
            return next.rm(toRemove); //Rufe das nächste Objekt auf

        }

        public bool find(Object toFind)
        {

            if (data == toFind)
            {
                return true;
            }

            if (next == null)
            {
                return false;
            }

            return next.find(toFind);
        }
    }


}
