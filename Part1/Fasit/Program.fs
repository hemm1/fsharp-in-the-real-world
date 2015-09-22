module Main
open Car
open System

[<EntryPoint>]
let main argv = 

    let car = { Make = "Volvo"; Year = 1987; Color = "Red"}
    Car.Print car

    Car.Repaint "Blue" car 
        |> Car.Print
        
    [ Car.New "Mazda" 1980 "Red"; Car.New "Toyota" 2003 "Red"; Car.New "Volvo" 2011 "Yellow" ] 
        |> List.map (Car.Repaint "Blue")
        |> List.iter Car.Print
    
    let s = Console.ReadLine()    
    0

