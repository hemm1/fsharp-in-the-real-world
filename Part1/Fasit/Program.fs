module Main
open Car
open System

let createCar make year color = {Make = make; Year = year; Color = color}

[<EntryPoint>]
let main argv = 

    let car = { Make = "Volvo"; Year = 1987; Color = "Red"}
    Car.Print car

    Car.Repaint "Blue" car 
        |> Car.Print
        
    [ createCar "Mazda" 1980 "Red"; createCar "Toyota" 2003 "Red"; createCar "Volvo" 2011 "Yellow"] 
        |> List.map (Car.Repaint "Blue")
        |> List.iter Car.Print
    
    let s = Console.ReadLine()    
    0

