module MinesweeperSpec

open ConsoleApp1
open Xunit

[<Fact>]
let ``Minesweeper Ready 생성 테스트`` () =
    let minesweeper = Ready(10, 10)
    Assert.Equal(Ready(10, 10), minesweeper)
[<Fact>]
