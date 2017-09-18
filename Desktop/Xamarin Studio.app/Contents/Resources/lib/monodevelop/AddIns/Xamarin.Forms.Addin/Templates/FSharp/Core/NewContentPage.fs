namespace ${Namespace}

open System
open Xamarin.Forms

type ${EscapedIdentifier} () =
    inherit ContentPage ()

    do
        let layout = StackLayout()
        layout.Children.Add(Label (Text = "Hello ContentPage"))
        base.Content <- layout
