namespace FSharp_Single_View_App_tvOS

open System
open UIKit
open Foundation

[<Register("AppDelegate")>]
type AppDelegate() = 
    inherit UIApplicationDelegate()
    member val Window = null with get, set
    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching(app, options) = true
