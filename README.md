# push-notifications

An application to send web notifications

Steps:
- Download project
- run "push-notifications" project.
  - A web page will be opened
  - Click "Enable Web notifications" and Click Allow
  - You will get a json output with endpoint, key (p256dh,auth) details
  - You are now listening to push notification
- To send push notification
  - Update the pushEndpoint, p256dh, auth values in "notification-pusher" project  
  - Run the "notification-pusher" project
  - A console will open asking you for a message. Type a message and press Enter
  - A notification will popup on your system
  
## Note
- You should enable the notification atleast once.
- Notification will be shown regardless of the web site opened or not
