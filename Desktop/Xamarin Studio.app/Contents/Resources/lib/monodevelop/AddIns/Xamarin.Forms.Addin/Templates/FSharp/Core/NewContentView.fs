namespace ${Namespace}

open System
open Xamarin.Forms

type ${EscapedIdentifier} () =
    inherit ContentView ()

    do
        base.Content <- Label (Text = "Hello ContentView")
