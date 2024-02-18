open Feliz

type Props = {
    Items: string []
    Heading: string
    ItemSelected : string -> unit
}
[<ReactComponent>]
let ListGroup ({Items = items; Heading = heading; ItemSelected = itemSelected} : Props) =
    let message = if items.Length = 0 then Html.p "No item found" else Html.p ""
    // let mutable selectedIndex = 0
    let (selectedIndex, setSelectedIndex) = React.useState(0)
    let listGroupItemClases index = if index = selectedIndex 
                                        then [
                                                "list-group-item"
                                                "active"
                                            ] 
                                        else ["list-group-item"]

    Html.div [
        Html.h1 heading
        message
        Html.ul [
                prop.className "list-group"
                prop.children 
                    (items 
                        |> Array.mapi (fun index item-> Html.li [
                                                prop.className (listGroupItemClases index)
                                                prop.text item
                                                prop.onClick (fun _ -> 
                                                                        setSelectedIndex(index)
                                                                        itemSelected(item)
                                                                        )
                                            ]))
        ] // end of ul
    ]// end of div

