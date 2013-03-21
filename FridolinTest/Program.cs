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
            Nation Frankreich = new Nation();
            Nation Hannover = new Nation();

            //Städte
            Town Bingen = new Town("Bingen", "Herz", Frankreich);
            Town Mainz = new Town("Mainz", "Herz", Frankreich);
            Town Wiesbaden = new Town("Wiesbaden", "Herz", Frankreich);
            Town Boppard = new Town("Boppard", "Herz", Frankreich);
            Town Koblenz = new Town("Koblenz", "Kreuz", Frankreich);//5
            Town Limburg = new Town("Limburg", "Kreuz", Frankreich);
            Town Oppenheim = new Town("Oppenheim", "Herz", Frankreich);
            Town Worms = new Town("Worms", "Herz", Frankreich);
            Town Mannheim = new Town("Mannheim", "Herz", Frankreich);
            Town Bensheim = new Town("Bensheim", "Herz", Frankreich);//10
            Town Darmstadt = new Town("Darmstadt", "Herz", Frankreich);
            Town Frankfurt = new Town("Frankfurt", "Herz", Frankreich);
            Town Hanau = new Town("Hanau", "Herz", Hannover);
            Town Aschaffenburg = new Town("Aschaffenburg", "Herz", Frankreich);
            Town Weilburg = new Town("Weilburg", "Kreuz", Frankreich);//15
            Town Wetzlar = new Town("Wetzlar", "Kreuz", Frankreich);
            Town Gießen = new Town("Gießen", "Kreuz", Frankreich);
            Town Nauheim = new Town("Nauheim", "Kreuz", Frankreich);
            Town Homburg = new Town("Homburg", "Kreuz", Frankreich);
            Town Betzdorf = new Town("Betzdorf", "Kreuz", Frankreich);//20
            Town Waldbröll = new Town("Waldbröll", "Kreuz", Frankreich);
            Town Olpe = new Town("Olpe", "Kreuz", Frankreich);
            Town Meschede = new Town("Meschede", "Kreuz", Frankreich);
            Town Siegen = new Town("Siegen", "Kreuz", Frankreich);
            Town Biedenkopf = new Town("Biedenkopf", "Kreuz", Frankreich);//25
            Town Dillenburg = new Town("Dillenburg", "Kreuz", Frankreich);
            Town Marburg = new Town("Marburg", "Kreuz", Frankreich);
            Town Frankenberg = new Town("Frankenberg", "Kreuz", Frankreich);
            Town Corbach = new Town("Corbach", "Kreuz", Frankreich);
            Town Wildungen = new Town("Wildungen", "Kreuz", Frankreich);//30
            Town Alsfeld = new Town("Alsfeld", "Kreuz", Frankreich);
            
            //Fort(Zielstädte/Festungen)
            Town Kassel = new Fort("Kassel", "Pik", Hannover, Frankreich); // Für Festungen

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
            Bensheim.towns.add(Darmstadt, Mannheim);//10
            Darmstadt.towns.add(Frankfurt, Bensheim, Aschaffenburg);
            Frankfurt.towns.add(Hanau, Wiesbaden, Darmstadt, Homburg);
            Hanau.towns.add(Frankfurt, Aschaffenburg);
            Aschaffenburg.towns.add(Hanau, Darmstadt);
            Weilburg.towns.add(Limburg, Wetzlar);//15
            Wetzlar.towns.add(Weilburg, Wetzlar, Dillenburg);
            Gießen.towns.add(Wetzlar, Nauheim, Marburg);
            Nauheim.towns.add(Gießen, Homburg, Hanau);
            Homburg.towns.add(Nauheim, Frankfurt);
            Betzdorf.towns.add(Waldbröll, Siegen, Koblenz);//20
            Waldbröll.towns.add(Olpe, Betzdorf);
            Siegen.towns.add(Olpe, Biedenkopf, Dillenburg, Betzdorf);
            Biedenkopf.towns.add(Siegen, Marburg);
            Dillenburg.towns.add(Siegen, Marburg, Wetzlar);
            Marburg.towns.add(Biedenkopf, Dillenburg, Gießen, Alsfeld, Frankenberg);//25
            Alsfeld.towns.add(Marburg);
            Frankenberg.towns.add(Corbach, Wildungen, Marburg);
            Corbach.towns.add(Frankenberg);
            Wildungen.towns.add(Frankenberg);
            Meschede.towns.add(Olpe);//30
            Olpe.towns.add(Meschede, Waldbröll, Siegen);


            
            //System.Console.WriteLine(Koblenz.towns.resultString());
            //System.Console.WriteLine(Wiesbaden.towns.resultString());
            System.Console.WriteLine(Dillenburg.reachDefense(3).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(2).resultString());
            //System.Console.WriteLine(Wiesbaden.reachDefense(1).resultString());
            System.Console.ReadKey();


        }
    }
    //public partial class MainWindow : Window
    //{
    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //    }

    //    private void button1_Click(object sender, RoutedEventArgs e)
    //    {
    //        label1.content = (Koblenz.reachDefense(2).resultString());
           
    //    }
    //}


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
        public String tacticalColor;
        public Nation nation;
        public TownListing towns;
        public Listing inTown;

        public Town(String newName, String newTacticalColor, Nation newNation)
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
        public Fort(String newName, String newTacticalColor, Nation newNation, Nation newConquerNation):base(newName, newTacticalColor, newNation)
        {
            conquerNation = newConquerNation;
        }
        //Problem mit Fragezeichen - Abgegdeckte Festung, durch Vertreibung nach Kampf nicht mehr abgedeckt
    }

    public class Nation
    {
        public Listing generals;
        public Listing forts;
        public Listing cards;
        public Listing startTowns;
        public Listing allies;
        public int maxArmies;
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
