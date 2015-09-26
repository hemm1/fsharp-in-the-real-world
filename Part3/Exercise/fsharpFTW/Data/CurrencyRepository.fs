namespace fsharpFTW.Data
open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open FSharp.Data

type CurrencyProvider = JsonProvider<"http://api.fixer.io/latest?base=EUR">

type CurrencyRepository() =
                        
    member x.ConvertFromEuroToNok amount =
        let sample = CurrencyProvider.GetSample()
        amount * sample.Rates.Nok;
    
            
