﻿namespace FSharp_Blank_App_iPhone

open UIKit

module Main = 
    [<EntryPoint>]
    let main args = 
        UIApplication.Main(args, null, "AppDelegate")
        0