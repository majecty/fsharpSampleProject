#r "packages/FAKE/tools/FakeLib.dll"
 
open Fake
open Fake.FscHelper
 
Target "Build" (fun _ ->
  ["main.fs"] |> Fsc (fun parameters -> parameters)
)
 
Target "Run" (fun _ ->
  Shell.Exec ("mono", "main.exe") |> ignore
)
 
"Build"
==> "Run"
 
RunTargetOrDefault "Run"
