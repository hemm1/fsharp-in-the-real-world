module Main
open Car
open System

[<EntryPoint>]
let main argv = 

    let car = { Make = "Volvo"; Year = 1987; Color = "Red"}
    Car.print car

    Car.repaint "Blue" car 
        |> Car.print
        
    [ Car.create "Mazda" 1980 "Red"; Car.create "Toyota" 2003 "Red"; Car.create "Volvo" 2011 "Yellow" ] 
        |> List.map (Car.repaint "Blue")
        |> List.iter Car.print
    
    let s = Console.ReadLine()    
    0

