module Extensions

open System
open Fable.Core
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module StaticFiles =
    let inline import (path : string) : string  = importDefault<string> path

module Stylesheet =

    type IStylesheet =
        [<Emit "$0[$1]">]
        abstract Item : className:string -> string

    /// Loads a CSS module and makes the classes within available
    let inline load (path: string) = importDefault<IStylesheet> path