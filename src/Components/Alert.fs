namespace Components
open Feliz
module AlertComponent =

    type Props = {
        children: ReactElement
    }
    [<ReactComponent>]
    let Alert ({children = children})=
        Html.div [
            children
        ]