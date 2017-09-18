namespace ${Namespace}

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS

[<Register ("AppDelegate")>]
type AppDelegate () =
  inherit FormsApplicationDelegate ()

  override this.FinishedLaunching (app, options) =
    Forms.Init()
    this.LoadApplication (new ${AppName}.App())
    base.FinishedLaunching(app, options)
