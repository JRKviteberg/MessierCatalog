# Messier Catalogue Console Application

## Developer
Name: Jan-Roger Kviteberg


## Project Description
- Dette er en konsollapplikasjon for å søke og sortere i Messier-katalogen, som inneholder informasjon om stjernehoper, galakser og andre himmelobjekter.
- Programmet er bygget i C# og kan kjøres på Windows, Linux eller macOS.
- Prosjektet er testet i Rider, men kan åpnes og bygges i hvilken som helst IDE som støtter C#.
- Katalogen leses fra en CSV-fil, og brukeren kan velge mellom ulike søke- og sorteringsalternativer.

## Features
- Søk:
  - Søk gjennom hele katalogen for å finne objekter basert på et enkelt søkeord.
  - Maksimalt 10 treff vises for å gjøre resultatene oversiktlige.
- Sorter:
  - Sorter katalogen basert på:
    - Messier-nummer: Numerisk basert på tallene etter "M".
    - NGC-nummer: Numerisk hvis mulig, ellers alfabetisk.
    - Visual Magnitude: Numerisk for lysstyrke, med lavere verdier som indikerer sterkere lys.
  - Velg mellom stigende (Ascending) eller synkende (Descending) rekkefølge.
  - Maksimalt 20 treff vises etter sortering.

  - Brukervennlig meny:
    - Velg søk, sortering eller avslutt programmet enkelt via en meny.

## Search and Sort Implementation
- Search:
   - Søkemetoden går gjennom alle rader i katalogen og sjekker om søkeordet finnes i noen av kolonnene. Hvis det finnes en match, legges raden til i resultatene.
   - Maksimalt 10 treff returneres for å holde resultatene håndterbare.
- Sort:
   - Sorteringen bruker en egendefinert Bubble Sort for å sammenligne og sortere rader basert på brukerens valg av kolonne og rekkefølge.
   - Messier-numre sorteres korrekt basert på det numeriske innholdet etter "M".
   - Visual Magnitude sorteres numerisk for å indikere styrken på lysstyrken.

## How to use

# Slik kjører du programmet:
1. Klon prosjektet fra repository eller legg til filene i en C# IDE (som Rider eller Visual Studio).
2. Åpne prosjektfilen og bygg løsningen.
3. Kjør programmet i konsollen.
4. Følg menyinstruksjonene for å søke, sortere eller avslutte.

## Example Commands
# Slik kjører du programmet:
  1. Klon prosjektet fra repository eller legg til filene i en C# IDE (som Rider eller Visual Studio).
  2. Åpne prosjektfilen og bygg løsningen.
  3. Kjør programmet i konsollen.
  4. Følg menyinstruksjonene for å søke, sortere eller avslutte.

## Github
[Jan-Roger](https://github.com/JRKviteberg)

## LICENSE
[MIT License](./LICENSE)