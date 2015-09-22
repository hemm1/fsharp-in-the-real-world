namespace fsharpFTW.Data

open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders

type CurrencyRepository() =
    
    
    member x.Convert fromCurrency toCurrency amount =
        System.Diagnostics.Debug.WriteLine ("convert called with fromCurrency = " + fromCurrency + " toCurrency = " + toCurrency + " and amount = " + amount.ToString())
        amount * 2