﻿using System;
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
    /*public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }*/

    //Klassen
    class Character
    {
        int name;
        static int counter;
        int id;
        Town position;
        Nation nation;
        int movePoints;

        public void move()
        { }
        public void main(String[] args) //kleine Test, zum debuggen ;)
        {
            Nation Frankreich = new Nation();
            TownListing BingenTowns = new TownListing();
            Town Bingen = new Town("Bingen","Herz",Frankreich,BingenTowns);
            Town 
        }
    }

    class General : Character
    {
        bool supply;
        int army;
        bool onRetreat;
    }

    class Baggage : Character
    {

    }

    class Town
    {
        String name;
        static int counter=0;
        int id;
        String tacticalColor;
        Nation nation;
        TownListing towns;
        Listing inTown;

        public Town(String newName, String newTacticalColor, Nation newNation, TownListing newTowns)
        {
            id = counter;
            counter++;
            name = newName;
            tacticalColor = newTacticalColor;
            nation = newNation;
            towns = newTowns;
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
    }

    class Fort : Town
    {
        Nation conquerNation;
        bool conquered;
        //Problem mit Fragezeichen - Abgegdeckte Festung, durch Vertreibung nach Kampf nicht mehr abgedeckt
    }

    class Nation
    {
        Listing generals;
        Listing forts;
        Listing cards;
        Listing startTowns;
        Listing allies;
    }

    class Card
    {
        static int counter;
        int id;
        string tacticalColor;
        int value;
    }

    class TownListing
    {
        public TownListElement head;
        int number = 0;

        public void add(Town newObject)
        {
            TownListElement newElement = new TownListElement(newObject);
            newElement.next = head.next;
            head.next = newElement;
            number++; //erhöhe Listenanzahl
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
    }
    class Listing
    {
        public ListElement head;
        int number = 0;

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

 
    class ListElement
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
    class TownListElement
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
    }


}