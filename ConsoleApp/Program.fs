open System

type Shape = 
    | Circle of radius: float
    | Rectangle of width: float * height: float
    | Triangle of base_: float * height: float
    
let area shape =
    match shape with 
    | Circle radius -> 3.14 * radius * radius
    | Rectangle (width, height) -> width * height
    | Triangle (base_, height) -> 0.5 * base_ * height
    
[<EntryPoint>]
let main argv =
    let circle = Circle 10.0
    let rectangle = Rectangle (2.0, 3.0)
    let triangle = Triangle (4.0, 5.0)
    
    [circle; rectangle; triangle]
    |> List.map area
    |> List.iter (printfn "%A")
    
    0 // return an integer exit code
