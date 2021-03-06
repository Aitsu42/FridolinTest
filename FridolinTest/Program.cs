﻿using System;
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
            Nation Hannover = new Nation("Hannover", 12, 2);
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

            //3.1 - Herz(Fr+Ha+Pr) von Greven bis Warburg (20/20) 
            Town Iserlohn = new Town("Iserlohn", 3, Frankreich);
            Town Soest = new Town("Soest", 3, Preußen);
            Town Lippstadt = new Town("Lippstadt", 3, Frankreich);
            Town Büren = new Town("Büren", 3, Frankreich);
            Town Brilon = new Town("Brilon", 3, Frankreich);
            Town Warburg = new Town("Warburg", 3, Hannover);
            Town Driburg = new Town("Driburg", 3, Frankreich);
            Town Paderborn = new Town("Paderborn", 3, Frankreich);
            Town Detmold = new Town("Detmold", 3, Frankreich);
            Town Gütersloh = new Town("Gütersloh", 3, Frankreich);
            Town Münster = new Town("Münster", 3, Frankreich);
            Town Lemgo = new Town("Lemgo", 3, Frankreich);
            Town Greven = new Town("Greven", 3, Frankreich);
            Town Rinteln = new Town("Rinteln", 3, Frankreich);
            Town Herford = new Town("Herford", 3, Preußen);
            Town Hamm = new Town("Hamm", 3, Preußen);
            Town Bielefeld = new Town("Bielefeld", 3, Preußen);
            Fort Minden = new Fort("Minden", 3, Preußen, Frankreich);
            Town Osnabrück = new Town("Osnabrück", 3, Frankreich);
            Town Rheine = new Town("Rheine", 3, Frankreich);
            
            //4.1 - Kreuz(FR+Ha+Pr) von Diepholz bis Emden

            Town Lingen = new Town("Lingen", 7, Preußen);
            Town Bramsche = new Town("Bramsche", 7, Frankreich);
            Fort Diebholz = new Fort("Diepholz", 7, Hannover, Frankreich);

            //2.2 Karo, Nienburg bis Lübeck
            Town Nienburg = new Town("Nienburg", 2, Hannover);
            
            
            
            
            
            
            
            //5.2 - Pik(Ha+Fr+Pr) von Wunstorf bis Nordhausen (4/26) - !!!
            Town Alfeld = new Town("Alfeld", 5, Hannover);
            Town Northeim = new Town("Northeim", 5, Hannover);
            Town Münden = new Town("Münden", 5, Hannover);
            Fort Göttingen = new Fort("Göttingen", 5, Hannover, Frankreich);
            Town Hofgeismar = new Town("Hofgeismar", 5, Hannover);
            Town Holzminden = new Town("Holzminden", 5, Hannover);
            Town Pyrmont = new Town("Pyrmont", 5, Hannover);
            Town Wunstorf = new Town("Wunstorf", 5, Hannover);

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

            //2.2 - 24 - check
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
            Soest.towns.add(Iserlohn, Hamm, Lippstadt);
            Hamm.towns.add(Münster, Gütersloh, Soest);
            Lippstadt.towns.add(Soest, Büren);
            Büren.towns.add(Lippstadt, Paderborn, Brilon);
            Brilon.towns.add(Corbach, Meschede, Büren);
            Warburg.towns.add(Corbach, Hofgeismar, Paderborn);
            Paderborn.towns.add(Driburg, Paderborn, Holzminden);
            Münster.towns.add(Gütersloh, Hamm, Greven);
            Gütersloh.towns.add(Münster, Bielefeld, Hamm, Paderborn);
            Detmold.towns.add(Paderborn, Pyrmont);
            Bielefeld.towns.add(Gütersloh, Herford);
            Lemgo.towns.add(Pyrmont, Herford);
            Greven.towns.add(Rheine, Osnabrück, Münster);
            Herford.towns.add(Lemgo, Bielefeld, Minden, Osnabrück);
            Rinteln.towns.add(Lemgo, Minden);
            Rheine.towns.add(Greven, Osnabrück, Lingen);
            Osnabrück.towns.add(Rheine, Greven, Herford, Minden, Diebholz);
            Osnabrück.towns.add(Bramsche);  //Osnabrück hat 6 Nachbarn Oo
            Minden.towns.add(Rinteln, Herford, Osnabrück, Wunstorf, Nienburg);

            //5.2 - 4/... - 
            Alfeld.towns.add(Northeim, lx, lx);
            Northeim.towns.add(Alfeld, Göttingen, lx, lx);
            Göttingen.towns.add(Northeim, Münden, lx, lx, lx);
            Münden.towns.add(Kassel, Göttingen);

            
            

            //Hauptstraßen

            //Von Worms, mit Kringel nach Göttingen
            Worms.mainStreet.add(Oppenheim, Mannheim);
            Oppenheim.mainStreet.add(Worms, Mainz);
            Mainz.mainStreet.add(Oppenheim, Wiesbaden);
            Wiesbaden.mainStreet.add(Mainz, Frankfurt);
            Frankfurt.mainStreet.add(Wiesbaden, Hanau, Darmstadt, Homburg);
            Darmstadt.mainStreet.add(Frankfurt, Bensheim);
            Bensheim.mainStreet.add(Darmstadt, Mannheim);
            Mannheim.mainStreet.add(Worms, Bensheim);
            Homburg.mainStreet.add(Nauheim, Frankfurt);
            Nauheim.mainStreet.add(Homburg, Gießen);
            Gießen.mainStreet.add(Nauheim, Wetzlar, Marburg);
            Wetzlar.mainStreet.add(Gießen);
            Marburg.mainStreet.add(Gießen, Alsfeld);
            Alsfeld.mainStreet.add(Marburg, Fritzlar);
            Fritzlar.mainStreet.add(Kassel, Alsfeld);
            Kassel.mainStreet.add(Fritzlar, Münden);
            Münden.mainStreet.add(Kassel, Göttingen);
            Göttingen.mainStreet.add(Münden, Northeim);
            Northeim.mainStreet.add(Göttingen, Alfeld);
            Alfeld.mainStreet.add(Northeim, Pyrmont);

            //Olpe bis Pyrmont
            Olpe.mainStreet.add(Iserlohn);
            Iserlohn.mainStreet.add(Olpe, Soest);
            Soest.mainStreet.add(Iserlohn, Hamm);
            Hamm.mainStreet.add(Soest, Gütersloh);
            Gütersloh.mainStreet.add(Hamm, Bielefeld);
            Bielefeld.mainStreet.add(Gütersloh, Herford);
            Herford.mainStreet.add(Bielefeld, Lemgo);
            Pyrmont.mainStreet.add(Lemgo, Alfeld, lx);


            General Cumberland = new General("Cumberland", Alfeld, Hannover);

            General Chevert = new General("Chevert", Iserlohn, Frankreich);
            General Soubise = new General("Soubise", Fulda, Frankreich);
            General Richelieu = new General("Richelieu", Iserlohn, Frankreich);
            
            General GeneralHildburghausen = new General("Hildburghausen", Hildburghausen, Sachsen); //kann nicht Hildburghausen heißen, da die stadt schon so heißt... :(

            General TestG = new General("TestG", Kassel, Frankreich);

            //Du kannst den String so nennen... nur die Variable nicht ;)


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
            //System.Console.WriteLine(Iserlohn.inTown.resultString());
            //System.Console.WriteLine(Kassel.reachSupply(15, Frankreich).resultString()); //15 schaffe ich in unter 20 sek :) aber 20 dauert länger als 7 min (hab da abgebrochen), aber wir brauchen ja max. 6 ;)
            //System.Console.WriteLine(Kassel.reachMove(12, Hannover).resultString());
           /* System.Console.WriteLine(TestG.currentMovePoints+" "+ TestG.position.reachMove(12, Frankreich).resultString());
            System.Console.WriteLine(Kassel.reachDefense(3, Hannover));
            TestG.move(Münden);
            TestG.move(Göttingen);
            TestG.move(Northeim);
            System.Console.WriteLine(Kassel.conquered);
            General TestG2 = new General("TestG2", Fritzlar, Hannover);
            TestG2.move(Kassel);
            TestG2.move(Fritzlar);
            System.Console.WriteLine(Kassel.conquered);*/
            Listing Liste = new Listing(1);
            System.Console.WriteLine(Liste.resultString());
            Liste.shuffle();
            System.Console.WriteLine(Liste.resultString());
                        Liste.shuffle();
                        System.Console.WriteLine(Liste.resultString());
                            Liste.shuffle();
            System.Console.WriteLine(Liste.resultString());
                            Liste.shuffle();
            System.Console.WriteLine(Liste.resultString());
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
        public int currentMovePoints;

        public Character(Town newTown, Nation newNation, int newMovePoints)
        { 
            id = counter;
            counter++;
            nation = newNation;
            position = newTown;
            movePoints = newMovePoints;
            currentMovePoints = newMovePoints;
            newTown.inTown.add(this);
        }

        public void move(Town newTown)//Ich hab die Movemethode doch nochmal konzeptionell anders gestaltet... siehe Diagramme in der Dropbox
        {
            if (position.reachMove(currentMovePoints, nation).search(newTown))
            {
                if (typeof(Fort) == position.GetType())
                {
                    Fort fort = (Fort)position;
                    if (nation == fort.conquerNation && fort.conquered == false)
                    {
                        if (!position.reachDefense(3, fort.nation))
                            fort.conquered = true;
                        else
                            fort.maybeConquered = true;
                    }
                    else if (nation == fort.nation && fort.conquered == true)
                    {
                        if (!position.reachDefense(3, fort.conquerNation))
                            fort.conquered = false;
                        else
                            fort.maybeConquered = true;
                    }
                }
                if (position.mainStreet.search(newTown))
                    currentMovePoints -= 3;
                else
                    currentMovePoints -= 4;
                position.inTown.remove(this);
                position = newTown;
                newTown.inTown.add(this);
            }
            else
                System.Console.WriteLine("Zielstadt ist nicht in Reichweite");
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
            newNation.bagaggages.add(this);
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
        public Listing mainStreet;

        public Town(String newName, int newTacticalColor, Nation newNation)
        {
            id = counter;
            counter++;
            name = newName;
            tacticalColor = newTacticalColor;
            nation = newNation;
            towns = new Listing();
            inTown = new Listing();
            mainStreet = new Listing();
        }
    
         public bool reachDefense(int distance, Nation defendNation) //Völlig überarbeitet, gibt jetzt aus: true: wenn Fort verteidigt wird, false, wenn nicht
         {
             Town tow;
             
             Listing result = new Listing();
             if (distance > 0)
             {
                 ListElement a = towns.head;
                 while (a.next != null)
                 {
                     a = a.next;
                     if (a.data.GetType() == typeof(Town) || a.data.GetType() == typeof(Fort))
                     {
                         tow = (Town)a.data;
                         if (unitTypeInTown(defendNation) <= 3 && unitTypeInTown(defendNation) >= 1)
                             return true;
                         if (distance > 1)
                         {
                             if (tow.reachDefense(distance - 1, defendNation) == true)
                                 return true;
                         }

                     }
                 }
             }
            return false;
           
  

        }
        public Listing reachSupply(int distance, Nation nationOfGeneral) //ähnlich wie reachDefense, nur schaut es, ob gegnerische Charaktere den Nachschub blockieren
        {
            Town tow;
            Listing result = new Listing();
            if (distance > 0)
            {
                ListElement a = towns.head;
                ListElement b;
                Character cha;
                bool isEnemyInTown;
                while (a.next != null)
                {
                    a = a.next;
                    isEnemyInTown = true;
                    if (!result.search(a.data))
                    {
                        result.add(a.data);
                    }
                    if (distance > 1)
                    {
                        if (a.data.GetType() == typeof(Town) || a.data.GetType() == typeof(Fort))
                        {
                            tow = (Town)a.data;
                            b = tow.inTown.head;
                            if (b.next == null)
                                isEnemyInTown = false;
                            while (b.next != null)
                            {
                                b = b.next;
                                cha = (Character)b.data;
                                if (cha.nation == nationOfGeneral || nationOfGeneral.allies.search(cha.nation))
                                    isEnemyInTown = false;
                            }
                            if (!isEnemyInTown)
                                result.add(tow.reachSupply(distance - 1, nationOfGeneral));
                        }
                    }

                }
            }
            return result;
        }
        public Listing reachMove(int reachMovePoints, Nation nationOfGeneral) //ähnlich wie reachSupply
        //reachMovePoints: Anzahl restlicher Bewegungspunkte der Einheit, Kosten: 4 für Straßen, nur 3 für Hauptstraßen
        {
            Town tow;
            Listing result = new Listing();
            ListElement a = mainStreet.head;
            int unitType; //0:Kein Gegner, 1:ein eigener General, 2:zwei eigene Generäle, 3:drei eigene Generäle, 4:Verbündeter, 5:gegnerischer Tross, 6:gegnerischer General, negative Werte: Fehler
            if (reachMovePoints >= 3) //HauptstraßenTeil
            {
                while (a.next != null)
                {
                    a = a.next;
                    if (a.data.GetType() == typeof(Town) || a.data.GetType() == typeof(Fort))
                    {
                            tow = (Town)a.data;
                            unitType = tow.unitTypeInTown(nationOfGeneral);
                            if (((unitType >= 0 && unitType <= 2) || unitType == 5) && !result.search(a.data)) //Der General darf in die Stadt laufen
                               result.add(a.data);
                                                            
                            if (unitType == 0)
                               result.add(tow.reachMove(reachMovePoints - 3, nationOfGeneral));

                            if (unitType < 0)
                                System.Console.WriteLine("Warnung: Die reachMove Methode hatte Probleme den stationierten Einheiten in der Stadt " + tow.name + " zu finden(HauptstraßenTeil)"); 
                    }
                }
            }
            a = towns.head;
            if(reachMovePoints >= 4) //Nebenstraßenteil
            {
                while (a.next != null)
                {
                    a = a.next;
                    if ((a.data.GetType() == typeof(Town) || a.data.GetType() == typeof(Fort)) && !this.mainStreet.search(a.data))
                    {
                        tow = (Town)a.data;
                        unitType = tow.unitTypeInTown(nationOfGeneral);
                        // System.Console.WriteLine("NebenstraßenTeil reachMove in " + this.name + " unitType der Stadt "+ tow.name+" ist " + unitType+" movePoints: "+ reachMovePoints);
                        if (((unitType >= 0 && unitType <= 2) || unitType == 5) && !result.search(a.data)) //Der General darf in die Stadt laufen
                            result.add(a.data);

                        if (unitType == 0) //Wenn die Stadt leer ist, dann schaue weiter
                        {
                            // System.Console.WriteLine("Z476: "+tow.name+": "+t.resultString());
                            result.add(tow.reachMove(reachMovePoints - 4, nationOfGeneral));
                        }
                        if (unitType < 0)
                            System.Console.WriteLine("Warnung: Die reachMove Methode hatte Probleme den stationierten Einheiten in der Stadt " + tow.name + " zu finden(NebenstraßenTeil)");
                    }
                }
            }
            return result;
        }
        public int unitTypeInTown(Nation nationOfGeneral) //Schaut was für Character in der Stadt sind
        {
            //0:Kein Gegner, 1:ein eigener General, 2:zwei eigene Generäle, 3:drei eigene Generäle, 4:Verbündeter, 5:gegnerischer Tross, 6:gegnerischer General, negative Werte: Fehler
            Character cha;
            ListElement b = inTown.head;
            int unitType = -1;
            if (b.next == null)
                unitType = 0;
            while (b.next != null)
            {
                b = b.next;
                cha = (Character)b.data;
                if (cha.nation == nationOfGeneral && unitType >= -1 && unitType <= 3)
                {
                    if (unitType == -1)
                        unitType = 1;
                    else if (unitType == 3)
                        unitType = -2;
                    else
                        unitType++;
                }
                else if (nationOfGeneral.allies.search(cha.nation))
                    unitType = 4;
                else if (cha.GetType() == typeof(General))
                    unitType = 6;
                else if (cha.GetType() == typeof(Baggage))
                    unitType = 5;
            }
            return unitType;
        }
        public int unitTypeInTown(Nation nationOfGeneral, Nation nationOfDefender) //Schaut was für Character in der Stadt sind, überladene Funktion
        {
            //0:Kein Gegner, 1:ein eigener General, 2:zwei eigene Generäle, 3:drei eigene Generäle, 4:Verbündeter, 5:gegnerischer Tross, 6:gegnerischer General, 7:verteidigender General, negative Werte: Fehler
            Character cha;
            ListElement b = inTown.head;
            int unitType = -1;
            if (b.next == null)
                unitType = 0;
            while (b.next != null)
            {
                b = b.next;
                cha = (Character)b.data;
                if (cha.nation == nationOfGeneral && unitType >= 0 && unitType <= 3)
                    if (unitType == -1)
                        unitType = 1;
                    else if (unitType == 3)
                        unitType = -2;
                    else
                        unitType++;
                else if (nationOfGeneral.allies.search(cha.nation))
                    unitType = 4;
                else if (cha.GetType() == typeof(General))
                {
                    if (nationOfDefender.generals.search(cha))
                        unitType = 7;
                    else
                        unitType = 6;
                }
                else if (cha.GetType() == typeof(Baggage))
                    unitType = 5;
            }
            return unitType;
        }
    }// class Town Ende

    public class Fort : Town
    {
        public Nation conquerNation;
        public bool conquered = false;
        public bool maybeConquered = false;//Falls die Festung abgedeckt ist während der Bewegungsphase, wenn true am Ende der Runde, dann ändere Conquered
        public Fort(String newName, int newTacticalColor, Nation newNation, Nation newConquerNation):base(newName, newTacticalColor, newNation)
        {
            conquerNation = newConquerNation;
        }
        
    }

    public class Nation
    {
        public String name;
        public Listing generals;
        public Listing forts;
        public Listing cards;
        public Listing startTowns;
        public Listing allies;
        public Listing bagaggages;
        public int maxArmies;
        public int cardsPerRound;
        public int cardDismissing;

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
        public void drawCards() //Methode am Anfang eines Nationenzugs um alle Karten zu ziehen und evtl. wieder wegzulegen
        {
            //TODO
            //for cardsPerRound
            //nextCard()
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
            tacticalColor = newTacticalColor;// 2:=Karo 3:=Herz 5:=Pik 7:=Kreuz
            id = counter;
            counter++;
            value = newValue; //value element aus [2, 13] + {1-10} value 0, tackticalColor 0 -> Joker
        }
        public static Card nextCard() //nächste Karte vom Stapel ziehen
        {
            Card newCard = new Card(0, 0);//Bullshit ;)
            //Todo: entscheiden ob wir es so wie im Spiel mit 4 seperaten Kartenstapeln machen wollen oder anders
            return newCard;
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

        public Listing(int Type)
        {
            Card car;
            head = new ListElement(null);
            if (Type == 1) //neuer Kartenstapel
            {
                int i = 2;
                do
                {
                    for (int j = 2; j <= 13; j++)
                    {
                        car = new Card(i, j);
                        this.add(car); 
                    }
                    switch(i)
                    {
                        case 2:
                            i=3; break;
                        case 3:
                            i=5; break;
                        case 5:
                            i=7; break;
                        default:
                            i=0; break;
                    }
                }while(i!=0);
                this.add(new Card(0, 0));//Joker
                this.add(new Card(0, 0));
            }
        }

        public void shuffle() //mischt eine Liste zufällig durch
        {
            ListElement lisE;
            Random random = new Random();
            int position;
            int oldNumber = this.number;
            Listing lis = new Listing();
            lis.head.next = this.head.next;
            this.head.next = null;
            this.number = 0;
            for (int i = oldNumber; i > 0; i--)
            {
                position = random.Next(1, i+1);
                lisE = lis.head;
                for (int j = 1; j <= position; j++)
                {
                    lisE = lisE.next;
                }
                this.add(lisE.data);
                lis.remove(lisE.data);
            }
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
                if (a.data.GetType() == typeof(Town) || a.data.GetType() == typeof(Fort)) //Falls das Object ein Town ist,
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
