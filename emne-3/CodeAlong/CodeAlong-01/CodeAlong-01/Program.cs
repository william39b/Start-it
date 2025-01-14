/*
Du skal lage en consoleapp som simulerer et butikksalg.
Noen kunder kommer inn i butikken og skal kjøpe øl. En Kassa ansatt er nødt til å sjekke om kunden kan kjøpe på lovlig vis.
Med fokus på objektorientering, lag en løsning på dette som simulerer 4 ulike kunder og prosessen med sjekk av legitimasjon i kassen.

Regler for alkoholsalg:

Det er ikke lov å kjøpe alkohol etter kl 20, dersom kunden ser eldre ut enn 25 kan de kjøpe uansett.
Dersom de ser yngre ut enn 25 må de fremvise gyldig legitimasjon som viser at de er over 18 år
*/

using CodeAlong_01;

List<Person> people = [
    new Person("William", 23),
    new Person("Anders", 30),
    new Person("Pål", 17),
    new Person("Per", 20),
    new Person("Jon", 11),
];

bool beerTime = CurrentTime.Time();

if (beerTime == true)
{
    foreach (var p in people)
    {
        var shop = new Shop(p);
        shop.BuyBeer();
    }
}