namespace fsharpFTW.Models

type CountryCode = {
    Name : string
    Code : string
}

type Country = {
    Name : string
    Capital : Option<string>
    Region : Option<string>
    Population : int
    Area : Option<float>
    Languages : string[]
}

