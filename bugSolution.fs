let mutable x = 10
let mutable y = 20

let add x y = 
    let temp = x
    x <- y
    y <- temp
    x

printf "%d %d" (add 10 20) (add 10 20) 