#Part1

## A
Lag en ny F# Console Application i Visual Studio. Lag en ny type, Car, i en egen fil(og egen modul) med feltene, Make, Year og Color.
instiansier denne i Main-metoden og print ut Make og Color (`printfn`). Bruk gjerne `Console.ReadLine()` (ligger i System)  slik     at du får sett hva som skrives ut før vinduet lukkes.

## B
Lag en metode Print på Car-modulen, som tar inn en bil og skrive ut alle feltene i bilene (`printfn`). Bruke denne til å printe ut bilen i Main-metoden.

## C
Lag en metode Repaint på Car-modulen som tar inn en Car og en farge-streng, som returnerer en ny Car med tilsvarende Id, Make og Year, men fargen som ble sendt inn.
Bruk den nye metoden i Main til å gi bilen en annen farge. Print ut fargen til den nye bilen for å verifisere at den er som forventet.  

## D
Lag en liste med minst 3 biler i forskjellige farger. Bruk `List.map (fun x -> x)` og repaint-funksjonen pluss `List.iter (fun x -> x)` til å male om bilene, og print de ut.
