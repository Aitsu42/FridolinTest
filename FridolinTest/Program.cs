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


            
            //Städte

            Town lx = new Town("Lücke", 0, Schweden); //Lückenfüller 

            Town Bingen = new Town("Bingen", 3, Frankreich);
            Town Mainz = new Town("Mainz", 3, Frankreich);
            Town Wiesbaden = new Town("Wiesbaden", 3, Frankreich);
            Town Boppard = new Town("Boppard", 3, Frankreich);
            Town Koblenz = new Town("Koblenz", 7, Frankreich);//5
            Town Limburg = new Town("Limburg", 7, Frankreich);
            Town Oppenheim = new Town("Oppenheim", 3, Frankreich);
            Town Worms = new Town("Worms", 3, Frankreich);
            Town Mannheim = new Town("Mannheim", 3, Frankreich);
            Town Bensheim = new Town("Bensheim", 3, Frankreich);//10
            Town Darmstadt = new Town("Darmstadt", 3, Frankreich);
            Town Frankfurt = new Town("Frankfurt", 3, Frankreich);
            Town Hanau = new Town("Hanau", 3, Hannover);
            Town Aschaffenburg = new Town("Aschaffenburg", 3, Frankreich);
            Town Weilburg = new Town("Weilburg", 7, Frankreich);//15
            Town Wetzlar = new Town("Wetzlar", 7, Frankreich);
            Town Gießen = new Town("Gießen", 7, Frankreich);
            Town Nauheim = new Town("Nauheim", 7, Frankreich);
            Town Homburg = new Town("Homburg", 7, Frankreich);
            Town Betzdorf = new Town("Betzdorf", 7, Frankreich);//20
            Town Waldbröll = new Town("Waldbröll", 7, Frankreich);
            Town Olpe = new Town("Olpe", 7, Frankreich);
            Town Meschede = new Town("Meschede", 7, Frankreich);
            Town Siegen = new Town("Siegen", 7, Frankreich);
            Town Biedenkopf = new Town("Biedenkopf", 7, Frankreich);//25
            Town Dillenburg = new Town("Dillenburg", 7, Frankreich);
            Town Marburg = new Town("Marburg", 7, Frankreich);
            Town Frankenberg = new Town("Frankenberg", 7, Frankreich);
            Town Corbach = new Town("Corbach", 7, Frankreich);
            Town Wildungen = new Town("Wildungen", 7, Frankreich);//30
            Town Alsfeld = new Town("Alsfeld", 7, Frankreich);
            Town Iserlohn = new Town("Iserlohn", 3, Frankreich);
            Town Fulda = new Town("Fulda", 2, Frankreich);
            Town Schlüchtern = new Town("Schlüchtern", 2, Hannover);
            Town Gelnhausen = new Town("Gelnhausen", 3, Frankreich);//35
            Town Alfeld = new Town("Alfeld", 5, Hannover);
            Town Northeim = new Town("Northeim", 5, Hannover);         
            Town Münden = new Town("Münden", 5, Hannover);
            Town Fritzlar = new Town("Fritzlar", 2, Hannover);
            Town Erbach = new Town("Erbach", 3, Frankreich);//40
            Town Miltenberg = new Town("Miltenberg", 3, Frankreich);
            Town Hünfeld = new Town("Hünfeld", 2, Frankreich);
            Town Lohr = new Town("Lohr", 5, Frankreich);
            Town Lauterbach = new Town("Lauterbach", 2, Frankreich);



            //Fort(Zielstädte/Festungen)
            Fort Kassel = new Fort("Kassel", 2, Hannover, Frankreich);
            Fort Göttingen = new Fort("Göttingen", 5, Hannover, Frankreich);

            //Nachbarstädte
            Bingen.towns.add(Mainz, Boppard);
            Mainz.towns.add(Bingen, Wiesbaden, Oppenheim);
            Wiesbaden.towns.add(Mainz, Limburg, Frankfurt);
            Boppard.towns.add(Koblenz, Bingen);
            Koblenz.towns.add(Boppard, Limburg, Betzdorf);//5
            Limburg.towns.add(Wiesbaden, Koblenz, Weilburg);
            Oppenheim.towns.add(Mainz, Worms);
            Worms.towns.add(Oppenheim, Mannheim);
            Mannheim.towns.add(Bensheim, Worms);
            Bensheim.towns.add(Darmstadt, Mannheim, Erbach);//10
            Darmstadt.towns.add(Frankfurt, Bensheim, Aschaffenburg);
            Frankfurt.towns.add(Hanau, Wiesbaden, Darmstadt, Homburg);
            Hanau.towns.add(Frankfurt, Aschaffenburg, Gelnhausen, Nauheim);
            Aschaffenburg.towns.add(Hanau, Darmstadt, Lohr, Miltenberg); //HIER
            Weilburg.towns.add(Limburg, Wetzlar);//15
            Wetzlar.towns.add(Weilburg, Wetzlar, Dillenburg);
            Gießen.towns.add(Wetzlar, Nauheim, Marburg, Lauterbach);
            Nauheim.towns.add(Gießen, Homburg, Hanau);
            Homburg.towns.add(Nauheim, Frankfurt);
            Betzdorf.towns.add(Waldbröll, Siegen, Koblenz);//20
            Waldbröll.towns.add(Olpe, Betzdorf);
            Siegen.towns.add(Olpe, Biedenkopf, Dillenburg, Betzdorf);
            Biedenkopf.towns.add(Siegen, Marburg);
            Dillenburg.towns.add(Siegen, Marburg, Wetzlar);
            Marburg.towns.add(Biedenkopf, Dillenburg, Gießen, Alsfeld, Frankenberg);//25
            Alsfeld.towns.add(Marburg, Fritzlar, Hünfeld, Lauterbach);
            Frankenberg.towns.add(Corbach, Wildungen, Marburg);
            Corbach.towns.add(Frankenberg, lx, lx);
            Wildungen.towns.add(Frankenberg, Fritzlar);
            Meschede.towns.add(Olpe, lx);//30
            Olpe.towns.add(Meschede, Waldbröll, Siegen, Iserlohn);
            Iserlohn.towns.add(Olpe, lx);
            Fulda.towns.add(Schlüchtern, Lauterbach, Hünfeld, lx);
            Schlüchtern.towns.add(Gelnhausen, Fulda, lx);
            Gelnhausen.towns.add(Schlüchtern, Hanau);//35
            Alfeld.towns.add(Northeim, lx, lx);
            Northeim.towns.add(Alfeld, Göttingen, lx, lx);
            Göttingen.towns.add(Northeim, Münden, lx, lx, lx);
            Fritzlar.towns.add(Alsfeld, Kassel, Wildungen);
            Kassel.towns.add(Fritzlar, Münden, lx, lx);//40
            Münden.towns.add(Kassel, Göttingen);
            Lauterbach.towns.add(Fulda, Gießen, Alsfeld);
            Lohr.towns.add(Aschaffenburg, lx);
            Hünfeld.towns.add(Fulda, Alsfeld, lx, lx);
            Erbach.towns.add(Bensheim, Miltenberg);//45
            Miltenberg.towns.add(Erbach, lx);



            General Cumberland = new General("Cumberland", Alfeld, Hannover); 

            General Richelieu = new General("Richelieu", Iserlohn, Frankreich);
            General Soubise = new General("Soubise", Fulda, Frankreich);
            General Chevert = new General("Chevert", Iserlohn, Frankreich);




            //System.Console.WriteLine(Koblenz.towns.resultString());
            //System.Console.WriteLine(Wiesbaden.towns.resultString());
            //System.Console.WriteLine(Dillenburg.reachDefense(3).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(2).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(1).resultString());
            //System.Console.ReadKey();


            System.Console.WriteLine(Frankreich.generals.resultString());
            System.Console.WriteLine(Hannover.generals.resultString());
            System.Console.WriteLine(Preußen.generals.resultString());
            System.Console.WriteLine(Schweden.generals.resultString());
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

        public void move()
        { 
            
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
        public TownListing towns;
        public Listing inTown;

        public Town(String newName, int newTacticalColor, Nation newNation)
        {
            id = counter;
            counter++;
            name = newName;
            tacticalColor = newTacticalColor;
            nation = newNation;
            towns = new TownListing();
            inTown = new Listing();
        }
    
         public TownListing reachDefense(int distance) // Startmethode
         {
            TownListing result = new TownListing();
            if (distance > 0)
            {
                TownListElement a = towns.head;
                do
                {
                  a = a.next;
                  if (!result.search(a.data))
                  {
                      result.add(a.data);
                  }
                  if (distance > 1)
                  {
                      a.data.reachDefense(distance - 1, result);
                  }
                  
                 }while(a.next != null);
                return result;

            }
            return result;
           }

        public void reachDefense(int distance, TownListing result) // methode bezüglich versorgung und abdeckung
        {
            //Console.WriteLine(name+": reachDefense("+distance+", "+result.resultString()+")");
            if (distance > 0)
            {
                TownListElement a = towns.head;
                while (a.next != null)
                {
                    a = a.next;
                    if (!result.search(a.data))
                    {
                        result.add(a.data);
                    }
                    if (distance > 1)
                    {
                        a.data.reachDefense(distance - 1, result);
                    }

                }
            }    

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

        public Nation(String newName, int newMaxArmy, int cardsPerRound)
        {
            generals = new Listing();
            forts = new Listing();
            cards = new Listing();
            startTowns = new Listing();
            allies = new Listing();
            name = newName;

        }
    }

    public class Card
    {
        public static int counter;
        public int id;
        public string tacticalColor;
        public int value;
    }

    public class TownListing
    {
        public TownListElement head;
        public int number = 0;

        public void add(Town newObject)
        {
            TownListElement newElement = new TownListElement(newObject);
            newElement.next = head.next;
            head.next = newElement;
            number++; //erhöhe Listenanzahl
        }

        public void add(Town newObject1, Town newObject2)
        {
            TownListElement newElement1 = new TownListElement(newObject1);
            TownListElement newElement2 = new TownListElement(newObject2);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            head.next = newElement2;
            number += 2; //erhöhe Listenanzahl
        }

        public void add(Town newObject1, Town newObject2, Town newObject3)
        {
            TownListElement newElement1 = new TownListElement(newObject1);
            TownListElement newElement2 = new TownListElement(newObject2);
            TownListElement newElement3 = new TownListElement(newObject3);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            head.next = newElement3;
            number += 3; //erhöhe Listenanzahl
        }

        public void add(Town newObject1, Town newObject2, Town newObject3, Town newObject4)
        {
            TownListElement newElement1 = new TownListElement(newObject1);
            TownListElement newElement2 = new TownListElement(newObject2);
            TownListElement newElement3 = new TownListElement(newObject3);
            TownListElement newElement4 = new TownListElement(newObject4);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            newElement4.next = newElement3;
            head.next = newElement4;
            number += 4; //erhöhe Listenanzahl
        }

        public void add(Town newObject1, Town newObject2, Town newObject3, Town newObject4, Town newObject5)
        {
            TownListElement newElement1 = new TownListElement(newObject1);
            TownListElement newElement2 = new TownListElement(newObject2);
            TownListElement newElement3 = new TownListElement(newObject3);
            TownListElement newElement4 = new TownListElement(newObject4);
            TownListElement newElement5 = new TownListElement(newObject5);
            newElement1.next = head.next;
            newElement2.next = newElement1;
            newElement3.next = newElement2;
            newElement4.next = newElement3;
            newElement5.next = newElement4;
            head.next = newElement5;
            number += 5; //erhöhe Listenanzahl
        }


        public bool search(Town toFind) //das fragt die liste ob das einzutragende schon in der liste ist
        {
            return head.find(toFind);
        }

        public void remove(Town toRemove) //Methode zum löschen eines Objektes aus einer Liste
        {
            if (head.rm(toRemove)) //Start am Kopf
            {
                number--; //verringere Listenanzahl
            }
        }

        public TownListing()
        {
            head = new TownListElement(null);
        }
        public String resultString()
        {
            String result = "";
            TownListElement a = head.next;
            for (int i = 0; i < number; i++)
            {
                result += ", "+i+". "+a.data.name;
                a = a.next;
            }
            if (result == "")
                result = "leer";
            return result;
        }
    } // ende: public class TownListing

    public class Listing
    {
        public ListElement head;
        public int number = 0;

        public void add(Object newObject)
        {
            ListElement newElement = new ListElement(newObject);
            newElement.next = head.next;
            head.next = newElement;
            number++; //erhöhe Listenanzahl
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
            General b;
            Nation c;
            Baggage d;
            Card e;
            for (int i = 0; i < number; i++)
            {
                if (a.data.GetType() == typeof(General))
                {
                    b = (General)a.data;
                    result += ", " + i + ". " + b.name;
                }
                if (a.data.GetType() == typeof(Nation))
                {
                    c = (Nation)a.data;
                    result += ", " + i + ". " + c.name;
                }
                if (a.data.GetType() == typeof(Baggage))
                {
                    d = (Baggage)a.data;
                    result += ", " + i+1 + ". Tross";
                }
                if (a.data.GetType() == typeof(Card))
                {
                    e = (Card)a.data;
                    result += ", " + i + ". " + e.value;
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

    public class TownListElement
    {
        public TownListElement next;
        public Town data;
        public TownListElement(Town newTown)
        {
            data = newTown;
        }

        public bool rm(Town toRemove)
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

        public bool find(Town toFind)
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
    } // Ende public class TownListElement



}
