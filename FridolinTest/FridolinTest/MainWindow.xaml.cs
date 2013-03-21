using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Friedrich
{
    public class Test
    {
        public void main(String[] args) //kleine Test, zum debuggen ;)
        {
            //Nationen
            Nation Frankreich = new Nation();
            Nation Hannover = new Nation();

            //Städte
            Town Bingen = new Town("Bingen", "Herz", Frankreich);
            Town Mainz = new Town("Mainz", "Herz", Frankreich);
            Town Wiesbaden = new Town("Wiesbaden", "Herz", Frankreich);
            Town Boppard = new Town("Boppard", "Herz", Frankreich);
            Town Koblenz = new Town("Koblenz", "Kreuz", Frankreich);
            Town Limburg = new Town("Limburg", "Kreuz", Frankreich);
            Town Oppenheim = new Town("Oppenheim", "Kreuz", Frankreich);
            Town Worms = new Town("Worms", "Kreuz", Frankreich);
            Town Mannheim = new Town("Mannheim", "Kreuz", Frankreich);
            Town Bensheim = new Town("Bensheim", "Kreuz", Frankreich);
            Town Darmstadt = new Town("Darmstadt", "Kreuz", Frankreich);
            Town Frankfurt = new Town("Frankfurt", "Kreuz", Frankreich);
            Town Hanau = new Town("Hanau", "Kreuz", Hannover);

            
            //Fort(Zielstädte/Festungen)
            Town Kassel = new Fort("Kassel", "Pik", Hannover, Frankreich); // Für Festungen
            
            //Nachbarstädte
            Bingen.towns.add(Mainz, Boppard);
            Mainz.towns.add(Bingen, Wiesbaden, Oppenheim);
            Wiesbaden.towns.add(Mainz, Limburg, Frankfurt);
            Limburg.towns.add(Wiesbaden, Koblenz);
            Koblenz.towns.add(Boppard, Limburg);
            Boppard.towns.add(Koblenz, Bingen);
            Frankfurt.towns.add(Hanau, Wiesbaden, Darmstadt);
            Darmstadt.towns.add(Frankfurt, Bensheim);
            Bensheim.towns.add(Darmstadt, Mannheim);
            Worms.towns.add(Oppenheim, Mannheim);

            System.Console.WriteLine(Koblenz.reachDefense(2).ToString);

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
                  if (result.search(a.data))
                  {
                      result.add(a.data);
                      a.data.reachDefense(distance - 1, result);
                  }
                 }while(a.next != null);
                return result;

            }
            return result;
           }

        public void reachDefense(int distance, TownListing result) // methode bezüglich versorgung und abdeckung
        {
            if (distance > 0)
            {
                TownListElement a = towns.head;
                do
                {
                    a = a.next;
                    if (result.search(a.data))
                        result.add(a.data);
                    reachDefense(distance - 1, result);

                } while (a.next != null);
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
        public String ToString()
        {
            
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