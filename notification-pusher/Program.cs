using System;
using WebPush;

namespace Pusher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Message to send : ");

            var message = Console.ReadLine();

            var pushEndpoint = @"https://fcm.googleapis.com/fcm/send/c2aV-RwGEWc:APA91bGoPMrJ_RNiOf4G_QZytyweUKlO9EdnbdWH2WiExObIFdfAJeFrPcqnwhkFqa5ADxj3RRcMMRIpW_5-jJHE7J9MXsWodm91oPNtSom003-R3rMY_mc8zc-ZCjBrHhSs5toqAg-o";
            var p256dh = @"BLIdHjbtDRpU-kzquUkceRCaLk0jzAgUxBVk9odbUbiuhe8k0fBUAJoIF0QGNRJ69ov7_QsFiUkuSC8KxRxL5tw";
            var auth = @"zWIWT0Yz5qYUg5Dh9Q5B-w";

            var subject = @"mailto:example@example.com";
            var publicKey = @"BI7MRNqE6bbLu41huIwqS_b_1OEfyeQV6ASNVXnXKXSzmiRFf8CnJrROILPV3jJA-GB74NI9XwoR0k4CVZ4wtYI";
            var privateKey = @"7Oohexq90FYnLyo9EyIPFKYiWBitCSK4EzIaiSOBSro";

            var subscription = new PushSubscription(pushEndpoint, p256dh, auth);
            var vapidDetails = new VapidDetails(subject, publicKey, privateKey);
            //var gcmAPIKey = @"[your key here]";

            var webPushClient = new WebPushClient();
            try
            {
                webPushClient.SendNotification(subscription, message, vapidDetails);
                //webPushClient.SendNotification(subscription, "payload", gcmAPIKey);
            }
            catch (WebPushException exception)
            {
                Console.WriteLine("Http STATUS code" + exception.StatusCode);
            }

            Console.ReadLine();
        }
    }
}
