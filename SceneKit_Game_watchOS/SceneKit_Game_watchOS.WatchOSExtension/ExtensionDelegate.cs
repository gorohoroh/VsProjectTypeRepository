using Foundation;
using WatchKit;

namespace SceneKit_Game_watchOS.WatchOSExtension
{
    public class ExtensionDelegate : WKExtensionDelegate
    {
        public override void ApplicationDidFinishLaunching()
        {
            // Perform any final initialization of your application.
        }

        public override void ApplicationDidBecomeActive()
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive.
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void ApplicationWillResignActive()
        {
            // Sent when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message)
            // or when the user quits the application and it begins the transition to the background state.
            // Use this method to pause ongoing tasks, disable timers, etc.
        }

        public override void HandleBackgroundTasks(NSSet<WKRefreshBackgroundTask> backgroundTasks)
        {
            // Sent when the system needs to launch the application in the background to process tasks.
            // Tasks arrive in a set, so loop through and process each one.

            foreach (WKRefreshBackgroundTask task in backgroundTasks)
            {
                // Check the Class of each task to decide how to process it
                if (task.GetType() == typeof(WKApplicationRefreshBackgroundTask))
                {
                    // Be sure to complete the background task once you’re done.
                    var backgroundTask = (WKApplicationRefreshBackgroundTask)task;
                    backgroundTask.SetTaskCompleted();
                }
                else if (task.GetType() == typeof(WKSnapshotRefreshBackgroundTask))
                {
                    // Snapshot tasks have a unique completion call, make sure to set your expiration date
                    var snapshotTask = (WKSnapshotRefreshBackgroundTask)task;
                    snapshotTask.SetTaskCompleted(true, NSDate.DistantFuture, null);
                }
                else if (task.GetType() == typeof(WKWatchConnectivityRefreshBackgroundTask))
                {
                    // Be sure to complete the background task once you’re done.
                    var backgroundTask = (WKWatchConnectivityRefreshBackgroundTask)task;
                    backgroundTask.SetTaskCompleted();
                }
                else if (task.GetType() == typeof(WKUrlSessionRefreshBackgroundTask))
                {
                    // Be sure to complete the background task once you’re done.
                    var backgroundTask = (WKUrlSessionRefreshBackgroundTask)task;
                    backgroundTask.SetTaskCompleted();
                }
                else
                {
                    // make sure to complete unhandled task types
                    task.SetTaskCompleted();
                }
            }
        }
    }
}
