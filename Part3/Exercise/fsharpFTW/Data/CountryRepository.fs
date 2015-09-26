namespace fsharpFTW.Data
open System.Data
open System.Data.Linq
open fsharpFTW.Models
open Microsoft.FSharp.Data.TypeProviders
open FSharp.Data

type CountryProvider = JsonProvider<"https://restcountries.eu/rest/v1/all">

type CountryRepository() =
                                                
    member x.ListCountries =
        CountryProvider.GetSamples() 
        |> Seq.toList
        |> List.map (fun c -> {Name = c.Name; Code = c.Alpha2Code.ToString() })            
