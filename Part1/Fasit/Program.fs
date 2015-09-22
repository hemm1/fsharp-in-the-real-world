module Main
open Car
open System

let createCar make model color = {Make = make; Model = model; Color = color}

let printCar car = printf "Make: %s  Model:%s  Color: %s \n" car.Make car.Model car.Color

[<EntryPoint>]
let main argv = 

    let car = { Make = "Volvo"; Model = "V70"; Color = "Red"}
    printCar car

    Car.Repaint car "Blue" |> printCar
        
    [ createCar "Mazda" "MX2" "Red"; createCar "Toyota" "Corolla" "Red"; createCar "Volvo" "240" "Yellow"] 
        |> List.map (fun c -> Car.Repaint c "Blue")
        |> List.iter (printCar)
    
    let s = Console.ReadLine()    
    0

