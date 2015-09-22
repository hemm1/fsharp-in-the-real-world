module Car

type Car = {
        Make : string
        Year : int
        Color : string
    }   
    
let Repaint color car = 
    {car with Color = color}

let Print car = printfn "Make: %s  Year:%i  Color: %s" car.Make car.Year car.Color

let New make year color = {Make = make; Year = year; Color = color}
