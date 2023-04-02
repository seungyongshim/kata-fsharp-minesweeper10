namespace ConsoleApp1


open Cell
type Minesweeper =
    | Ready of int * int
    | Playing of int * int * Map<int*int, Cell>
    | Win of int * int * Map<int*int, Cell>
    | Lose of int * int * Map<int*int, Cell>
