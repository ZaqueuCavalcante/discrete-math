open System

printfn "Hello from F#"

let printGreeting name = printfn $"Hello {name} from F#!"

let myName = "Zaqueu"

printGreeting myName

type Person = {
    Name: string
    BirthDate: DateTime
}

type CardType = Visa | Master

let ct: CardType = Master
