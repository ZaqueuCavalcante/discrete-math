module Tests

open NUnit.Framework
open FluentAssertions
open Src

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test () =
    let number = 5
    let result = Sum.two number
    result.Should().Be(7, "5 + 2 = 7") |> ignore
