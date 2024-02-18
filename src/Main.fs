module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open ListGroup

importSideEffects "bootstrap/dist/css/bootstrap.css"
let root = ReactDOM.createRoot(document.getElementById "feliz-app")
let items = [|"Item1";"Item2";"Items"|]
root.render(ListGroup{items = items; heading = "Cities"})