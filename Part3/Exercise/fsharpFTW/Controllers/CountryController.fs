namespace fsharpFTW.Data
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

type CountryController(repo : CountryRepository) =
    inherit ApiController()

    new() = new CountryController(CountryRepository())

    [<HttpGet>]
    [<Route("api/countries")>]
    member x.Get () = repo.ListCountries

    
    [<HttpGet>]
    [<Route("api/countries")>]
    member x.Get (countryCode : string) = repo.GetCountry countryCode

