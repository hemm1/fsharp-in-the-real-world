#Part1

1a) 
Lag en ny F# Console Application i Visual Studio. Lag en ny type, Car, i en egen fil(og egen modul) med feltene, Make, Model og Color.
instiansier denne i Main-metoden og print ut Make og Color (printf). Bruk gjerne Console.ReadLine() (ligger i System)  slik     at du får sett hva som skrives ut før vinduet lukkes.

1b) 
Lag en metode Repaint på Car-modulen som tar inn en Car og en farge-streng, som returnerer en ny Car med tilsvarende Id, Make og Model, men fargen som ble sendt inn.
Bruk den nye metoden i Main til å gi bilen en annen farge. Print ut fargen til den nye bilen for å verifisere at den er som forventet.

1c)
Lag en liste med minst 3 biler i forskjellige farger. Bruk list.Map og Car.Repaint til å male om bilene, og print de ut.