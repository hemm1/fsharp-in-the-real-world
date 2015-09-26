# Part 3

I denne delen skal vi se på JSON-TypeProvidern fra biblioteket FSharp.Data (https://www.nuget.org/packages/FSharp.Data/).
Oppgavene gjøres i løsningen i Exercise-mappa, der er denne pakken allerede inkludert.

## A
I denne oppgaven skal du benytte JSON-TypeProvidern til å konvertere valuta med en oppdatert kurs.

Vi har allerede en et konverteringsskjema på forsiden, en `CurrencyController` og et `CurrencyRepository`.  
Fullfør metoden i `CurrencyRepository` slik at den henter en oppdatert kurs fra endepunktet `"http://api.fixer.io/latest?base=EUR"` og konverterer fra Euro til NOK.
Synktaks for JSON-TypeProvider:   
`type CurrencyProvider = JsonProvider<"http://api.fixer.io/latest?base=EUR">`.

## B
I denne oppgaven skal du implementere et nytt REST-endepunkt som returnerer en liste av land med Name og Code (alpha2code).

Implementer et CountryRepository som benytter seg av endepunktet `"https://restcountries.eu/rest/v1/all"` for å hente ut land og landkoder.
Repositoriet skal tilby en metode som returnerer en liste med land. Benytt den allerede eksisterende typen `CountryCode` som datastruktur.

Implementer en `CountryController` med en action som returnerer listen fra `CountryRepository`. 
Routen må være `[<Route("api/countries")>]`.

## C
Implementer en action på `CountryController` som tar inn en `(countryCode: string)` og returnerer land-informasjon. Routen må være `"api/countries"`.
Denne skal igjen kalle på `CountryRepository`, som benytter seg av JSON-TypeProvidern til å hente informasjon fra følgende endepunkt:
`"https://restcountries.eu/rest/v1/alpha?codes=<landkode>"`.
Det kan være lurt å lage en Type som representerer et land(Country). Feltene som vises automatisk i skjermbildet er `name`, `population` og `languages`, men inkluder gjerne flere felter.

## BONUS

Benytt dataen du allerede får fra restcountries og fixer til å utbedre valutakalkulatoren:  
*Gi brukeren en liste med valutaer man kan konvertere fra og til, som er hentet fra restcountries.  
*Endre kalkulatoren slik at den konverterer til og fra de oppgitte valutaene
  * apples
