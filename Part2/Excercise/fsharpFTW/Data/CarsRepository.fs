namespace fsharpFTW.Data

open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open fsharpFTW.Models

type SqlConnection = Microsoft.FSharp.Data.TypeProviders.SqlDataConnection<ConnectionString = @"Data Source=.;database=fsharpFTW;Integrated Security=True">
type DbCar = SqlConnection.ServiceTypes.Car

type CarsRepository() =
    let db = SqlConnection.GetDataContext()

    let selectAllCars =
        query {
            for car in db.Car do
            select car 
        }
           
    member x.GetAll = 
        selectAllCars 
            |> Seq.toList 
            |> List.map (fun c -> {Id = c.Id; Make = c.Make; Model = c.Model})