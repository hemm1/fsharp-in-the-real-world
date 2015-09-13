namespace fsharpFTW.Controllers
open System
open System.Collections.Generic
open System.Linq
open System.Net.Http
open System.Web.Http
open fsharpFTW.Models

type CarsController() =
    inherit ApiController()

    let repo = CarsRepository()

    member x.Get() = repo.GetAll()
