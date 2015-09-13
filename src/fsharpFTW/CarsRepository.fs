namespace fsharpFTW.Controllers

open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open fsharpFTW.Models

type SqlConnection = Microsoft.FSharp.Data.TypeProviders.SqlDataConnection<ConnectionString = @"Data Source=.;database=faggruppe;Integrated Security=True">

type CarsRepository() =
    let db = SqlConnection.GetDataContext()

    let deleteRowsFrom (table:Table<_>) rows =
        table.DeleteAllOnSubmit(rows)

    let delete = query {
                            for car in db.Car do
                            where (car.Make = "Ferrari")
                            select car
                        }

    member x.GetAll() = 

        query 
            {
                for car in db.Car do
                select car 
            } 
                |> Seq.toList
                |> List.map (fun c -> {Make = c.Make; Model = c.Model})

    member x.Delete() =
        delete |> deleteRowsFrom db.Car
        db.DataContext.SubmitChanges()
     
