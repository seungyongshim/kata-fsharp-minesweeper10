namespace ConsoleApp1

open Microsoft.FSharp.Core
open System.Text


type Minefield =
    | Start of int * int * seq<(int*int)>
    | Playing of int * int * Map<(int*int), Cell>
    | Won
    | Loose

module Minefield =
    let string (minefield: Minefield) =
        match minefield with
        | Start (x, y, mines) -> "Start"
        | Playing (x, y, cells) -> "Playing"
        | Won -> "Won"
        | Loose -> "Loose"

    let ``debug string`` (minefield: Minefield) =
        match minefield with
        | Start (x, y, mines) -> "Start"
        | Playing (x, y, cells) ->
             sb = StringBuilder()
            for i in 0..y-1 do
                for j in 0..x-1 do
                     Cell.string (cells[(j, i)])
        | Won -> "Won"
        | Loose -> "Loose"

