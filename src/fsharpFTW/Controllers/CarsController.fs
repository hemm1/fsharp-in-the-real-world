namespace fsharpFTW.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http
open fsharpFTW.Models

type CarsController(repo : CarsRepository) =
    inherit ApiController()

    new() = new CarsController(CarsRepository())

    member x.Get() = repo.GetAll()

    member x.Delete id = repo.Delete id

    member x.Post (car:Car) = repo.Create car

    member x.Put (id:int, car:Car) = 
        System.Diagnostics.Debug.WriteLine ("PUT called with Id = " + id.ToString() + " Make = " + car.Make + " and Model = " + car.Model)
