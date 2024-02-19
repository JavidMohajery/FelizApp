module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Components
importSideEffects "bootstrap/dist/css/bootstrap.css"
let root = ReactDOM.createRoot(document.getElementById "feliz-app")



root.render(AlertComponent.Alert 
    {
        children = Html.div [
                        prop.children [
                            Html.span "Hello "
                            Html.strong [prop.text "World"]
                        ]
                      ]
    }
)