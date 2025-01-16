﻿/*
Du skal lage en konsollapp med en bil som skal kjøre 1000m. 
Bilen har en start-hastighet på 10m/s (en iterasjon i en løkke er et sekund).
Bilen skal øke farten med 10m/s frem til den har kjørt 500m, 
også skal den senke farten med 10m/s 
igjen frem til den når minimumshastigheten sin på 10m/s.
Når bilen har kommet seg til slutt-målet printes det ut til skjermen at bilen er fremme og har parkert.

Utvid oppgaven til at du kan lage 2 biler som kjører om kapp i en løkke, 
der de har en metode som genererer en random hastighet til dem mellom 60-200m/s som varer en runde. 
Det er førstemann til å kjøre 10000m
*/

using CodeAlong_02;

List<Car> drivers = [
    new Car(1, 10),
    new Car(2, 10),
];

foreach (Car car in drivers)
{
    new RaceTrack(car);
}
