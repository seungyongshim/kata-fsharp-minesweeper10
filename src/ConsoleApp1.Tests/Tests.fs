module Tests

open System
open Xunit
open ConsoleApp1
open Cell

[<Fact>]
let ``Covered 생성 테스트`` () =
    let cell = Covered Mine
    Assert.Equal(".", string cell)
