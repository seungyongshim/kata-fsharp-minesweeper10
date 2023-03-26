module Tests

open System
open Xunit
open ConsoleApp1
open Cell

[<Fact>]
let ``Covered 생성 테스트`` () =
    let cell = Covered Mine
    Assert.Equal(".", string cell)
[<Fact>]
let ``Mine 생성 테스트`` () =
    let cell = Mine
    Assert.Equal("*", string cell)
[<Fact>]
let ``Number 생성 테스트0`` () =
    let cell = Number 0
    Assert.Equal("0", string cell)
[<Fact>]
let ``Number 생성 테스트1`` () =
    let cell = Number 1
    Assert.Equal("1", string cell)
[<Fact>]
let ``Number 생성 테스트2`` () =
    let cell = Number 2
    Assert.Equal("2", string cell)
[<Fact>]
let ``Number 생성 테스트3`` () =
    let cell = Number 3
    Assert.Equal("3", string cell)
[<Fact>]
let ``Number 생성 테스트4`` () =
    let cell = Number 4
    Assert.Equal("4", string cell)
[<Fact>]
let ``Number 생성 테스트5`` () =
    let cell = Number 5
    Assert.Equal("5", string cell)
[<Fact>]
let ``Number 생성 테스트6`` () =
    let cell = Number 6
    Assert.Equal("6", string cell)
[<Fact>]
let ``Number 생성 테스트7`` () =
    let cell = Number 7
    Assert.Equal("7", string cell)
[<Fact>]
let ``Number 생성 테스트8`` () =
    let cell = Number 8
    Assert.Equal("8", string cell)

[<Fact>]
let ``Covered 클릭 테스트`` () =
    let cell = Covered Mine
    Assert.Equal(Mine, click cell)
[<Fact>]
let ``Mine 클릭 테스트`` () =
    let cell = Mine
    Assert.Equal(Mine, click cell)
[<Fact>]
let ``Number 클릭 테스트`` () =
    let cell = Number 0
    Assert.Equal(Number 0, click cell)
