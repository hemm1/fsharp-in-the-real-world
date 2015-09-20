module ``Given a Cars repository``

open FsUnit
open NUnit.Framework
open fsharpFTW.Controllers
open fsharpFTW.Models

//open NUnitRunner

let repo = new CarsRepository();


//TODO: Decouple the CarsRepository to allow for testing of the functions

[<Test>]
let ``Get all should return three cars``() =
    let result = repo.GetAll()
    result |> Seq.length |> should equal 6


//[<Test>]
//let ``FsUnit test 1``() =
//    [1; 2; 3] |> should equal [1; 2; 3]
//
//[<Test>]
//let ``FsUnit test 2``() =
//    1 |> should not' (equal 1)
//
//[<Test>]
//let ``FsUnit test 3``() =
//    10.1 |> should (equalWithin 0.1) 10.22
//
//[<Test>]
//let ``FsUnit test 4 (should throw exception)``() =
//    (fun () -> 1 + 2 |> ignore) |> should throw typeof<System.Exception>

