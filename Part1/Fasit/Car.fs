module Car

type Car = {
        Make : string
        Model : string
        Color : string
    }   


let Repaint car color = 
    {Make = car.Make; Model = car.Model; Color = color}
