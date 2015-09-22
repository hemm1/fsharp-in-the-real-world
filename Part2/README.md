# Part 2

Før du begynner:
 - Du må ha en instans av SQL server kjørende lokalt som du kan koble deg til. Tilpass connection stringen til databasen i CarsRepository.fs hvis nødvendig.
 - Kjør SQL-scriptene du finner i repoet i en rekkefølge du finner fornuftig for å opprette databasen og tabellen, og populere den med data.
 - Applikasjonen kjøres fra Visual Studio.


 Kjør applikasjonen i Visual Studio og verifiser at du får se noen biler fra databasen i lista. Hvis du har utviklerconsollen oppe i nettleseren mens du forsøker å slette, endre eller opprette en bil vil du se at serveren svarer med 405 - Method not allowed. Det er deres jobb å implementere DELETE, POST og UPDATE i controlleren og repositoryet slik at man kan slette, endre og opprette biler. Forsøk å lage små, generelle funksjoner i repoet som du kan gjenbruke.

## A
Implementer DELETE-funksjonalitet i repoet.

## B
Implementer POST-funksjonalitet i repoet.

## C
Implementer UPDATE-funksjonalitet i repoet.

## BONUS

### Refaktorer repoet til mange små funksjoner som kaller hverandre

### Bytt til å bruke SqlCommandProvider fremfor SqlDataConnection - http://fsprojects.github.io/FSharp.Data.SqlClient/

### Hjelp de som ikke er ferdige enda
