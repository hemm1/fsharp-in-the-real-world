namespace fsharpFTW.Controllers

open System.Data
open System.Data.Linq
open Microsoft.FSharp.Data.TypeProviders
open fsharpFTW.Models

type SqlConnection = Microsoft.FSharp.Data.TypeProviders.SqlDataConnection<ConnectionString = @"Data Source=.;database=fsharpFTW;Integrated Security=True">

type CarsRepository() =
    let db = SqlConnection.GetDataContext()

    let deleteRowFromCar row =
        db.Car.DeleteOnSubmit row

    let selectRowWithId (id:int) = 
                        query {
                            for car in db.Car do
                            where (car.Id = id)
                            select car
                        }
                            |> Seq.head

    let createNewCar car =  
       new SqlConnection.ServiceTypes.Car(Make = car.Make, Model = car.Model)

    let insertIntoCarTable car =
       db.Car.InsertOnSubmit car |> ignore
        

    member x.GetAll() = 

        query 
            {
                for car in db.Car do
                select car 
            } 
                |> Seq.toList
                |> List.map (fun c -> {Id = c.Id; Make = c.Make; Model = c.Model})

    member x.Delete id =
        selectRowWithId id |> deleteRowFromCar
        db.DataContext.SubmitChanges()
     
     member x.Create car =
        let ignore = createNewCar car |> insertIntoCarTable
        db.DataContext.SubmitChanges()
        
