namespace ${Namespace}

open System
open NUnit.Framework
open Xamarin.UITest
open Xamarin.UITest.Queries

type Tests() =

  [<TestCase (Platform.Android)>]
  [<TestCase (Platform.iOS)>]
  member this.AppLaunches (platform: Platform) =
    let platform = platform
    let app = AppInitializer.startApp (platform)
    app.Screenshot ("First screen.")
