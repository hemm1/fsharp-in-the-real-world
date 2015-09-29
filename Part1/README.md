#Part1

1a)
Lag en ny F# Console Application i Visual Studio. Lag en ny type, Car, i en egen fil(og egen modul) med feltene, Make, Year og Color.
instiansier denne i Main-metoden og print ut Make og Color (printfn). Bruk gjerne Console.ReadLine() (ligger i System)  slik     at du får sett hva som skrives ut før vinduet lukkes.

1b)
Lag en metode Print på Car-modulen, som tar inn en bil og skrive ut alle feltene i bilene (printfn). Bruke denne til å printe ut bilen i Main-metoden.

1c) 
Lag en metode Repaint på Car-modulen som tar inn en Car og en farge-streng, som returnerer en ny Car med tilsvarende Id, Make og Year, men fargen som ble sendt inn.
Bruk den nye metoden i Main til å gi bilen en annen farge. Print ut fargen til den nye bilen for å verifisere at den er som forventet.
  *Tips: List.map (fun x -> x) og List.iter (fun y -> y) kan være kjekke metoder å bruke

1d)
Lag en liste med minst 3 biler i forskjellige farger. Bruk list.Map og Car.Repaint til å male om bilene, og print de ut.
