module Minefield

open Xunit
open ConsoleApp1

[<Fact>]
let ``Start 생성 테스트`` () =
    let minefield = Start (10, 10, Seq.empty)
    Assert.Equal("Start", string minefield)

