namespace ConsoleApp1

// minesweeper
type Cell =
    | Covered of Cell
    | Mine
    | Number of int

module Cell =
    let string (cell: Cell) =
        match cell with
        | Covered _ -> "."
        | Mine -> "*"
        | Number n -> string n

