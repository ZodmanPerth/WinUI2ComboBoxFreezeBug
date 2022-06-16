# Description

This is a test project replicating a hang issue with `ComboBox` on `AppWindow` with versions of `WinUI 2` after `2.6.0-prerelease.210430001`

# Replication steps

To observe the issue, we will be use the following replication steps:

1. Run the app
1. Click the button to spawn an AppWindow
1. On the AppWindow, click the ComboBox
1. Scrub the mouse pointer across the open Combobox, making sure the mouse goes past the airspace of the open Combobox

![image](https://user-images.githubusercontent.com/546368/174015880-b3523705-8500-4fee-8deb-5faab350de4f.png)

# No issues on version `2.6.0-prerelease.210430001`

When running the solution without alteration from the Git repo you are running on WinUI 2 (`Microsoft.UI.XAML` is version `2.6.0-prerelease.210430001`).  In this version of `WinUI` the `ComboBox` does not have an issue.

# Issues on versions after `2.6.0-prerelease.210430001`

Now upgrade the version of `WinUI` to any version after `2.6.0-prerelease.210430001`, run the solution, and repeat the replication steps.  Observe that the hover state stops working and the application hangs.
