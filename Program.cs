// See https://aka.ms/new-console-template for more information


// Als je de waarde van keuze veranderd, dan zal een andere functie aangeroepen worden
using System.Diagnostics.CodeAnalysis;

int keuze = 4; // verander de waarde 1 in 2, 3 of 4 en een andere functie zal aangeroepen worden

if (keuze == 1)
{
    // roep de functie oneven aan
    oneven();
}
if (keuze == 2)
{
    fibonacci_1();
}
if (keuze == 3)
{
    fibonacci_2();
}
if (keuze == 4)
{
    hogerLager();
}


/*
 * toon 10 oneven nummers
 * Druk op het driehoekje rechts van Oefeningen (Control-F5 mag ook)
 * Je ziet nu oneven cijfers
 * a) Verander het startgetal in 25. Start nogmaals het programma. Je krijgt nu een andere reeks
 * b) Verander het getal 10 in 15. Start nogmaals het programma. Je hebt nu een grotere reeks
 * c) Verander het ophooggetal van 2 naar 8.
 */
int oneven()
{
    int getal = 1;
    for (int i = 0; i < 10; i++) 
    {
        Console.WriteLine(getal);
        getal = getal + 2;          // Hoog het getal op met 2
    }
    return (0);
}

/*
 * Hier komt de reeks van fibonacci
 * De fibonacci reeks is een reeks van getallen waarbij de som van 2 getallen
 *   het volgende getal vormt.
 * Het eerste getal = 0. Het tweede getal is 1. het derde getal is de som van 'eerste' en 'tweede'
 * Opdracht: Plaats onder elke opdrachtregel de gewenste computerregel(s)
 *    
 */
int fibonacci_1()
{
    int eerste = 0;
    int tweede = 1;
    int derde;
    Console.WriteLine("Fibonacci reeks 1");
    // a) schrijf eerste getal naar console mbv Console.WriteLine( ); 

    // b) schrijf 2de getal naar console

    // c) bereken derde getal en schrijf getal naar console

    // d) Geef variabele 'eerste' de waarde van variabele 'tweede'

    // e) Geef variabele 'tweede' de waarde van variabele 'derde'

    // f) bereken derde getal en schrijf getal naar console

    // g) Geef variabele 'eerste' de waarde van variabele 'tweede'

    // h) Geef variabele 'tweede' de waarde van variabele 'derde'

    // i) bereken derde getal en schrijf getal naar console

    // j) Geef variabele 'eerste' de waarde van variabele 'tweede'

    // k) Geef variabele 'tweede' de waarde van variabele 'derde'

    // Je ziet nu een herhaling van opdrachten (opdracht c,d,e is hetzelfde als opdracht f,g,h enz)
    return (0);
}


/* verbeterde versie van fibonacci
 */
int fibonacci_2()
{
    int eerste = 0;
    int tweede = 1;
    int derde;
    Console.WriteLine("Fibonacci reeks 2");
    // a) schrijf eerste getal naar console mbv Console.WriteLine( ); 

    // b) schrijf 2de getal naar console


    // We gaan repeterende opdrachten in een lus plaatsen
    for (int i=0; i<10; i++)
    {
        // c) bereken derde getal en schrijf getal naar console

        // d) Geef variabele 'eerste' de waarde van variabele 'tweede'

        // e) Geef variabele 'tweede' de waarde van variabele 'derde'

    }
    // f) run het programma. Je hebt nu 12 getallen van fibonacci.
    // g) wijzig de 10 in 20. Nu heb je een rij van 22 getallen

    return (0);
}

/*
 * Hier komt het hoger lager spelletje
 * Pas de code aan 
 */
int hogerLager()
{
    int max = 128;
    int min = 0;
    int midden;
    bool geraden = false;
    string input;
    int aantalKeer = 0;

    Console.WriteLine("Hoger lager spel");
    Console.WriteLine("0=geraden 1=tehoog 2=telaag");
    while (geraden == false)
    {
        midden = (max + min) / 2;
        Console.Write("Gok = " + midden + ": ");
        input = Console.ReadLine();
        if (input == "0")
        {
            geraden = true;
        }
        else if (input == "1")
        {
            max += midden;
        }
        else
        {
            min -= midden;
        }
        aantalKeer++;
    }
    Console.WriteLine("Geraden in "+ Convert.ToString(aantalKeer) + " keer.");

    return (0);
}

