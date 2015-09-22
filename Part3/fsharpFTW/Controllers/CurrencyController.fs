namespace fsharpFTW.Data
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http

type CurrencyController(repo : CurrencyRepository) =
    inherit ApiController()

    new() = new CurrencyController(CurrencyRepository())

    [<HttpGet>]
    [<Route("api/currency")>]
    member x.Convert (fromCurrency:string) (toCurrency:string) (amount:int) = repo.Convert fromCurrency toCurrency amount