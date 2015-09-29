module Car

type Car = {
        Make : string
        Year : int
        Color : string
    }   
    
let repaint color car = 
    {car with Color = color}

let print car = printfn "Make: %s  Year:%i  Color: %s" car.Make car.Year car.Color

let create make year color = {Make = make; Year = year; Color = color}
