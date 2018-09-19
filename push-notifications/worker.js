'use strict';

// listen to push event and show notification
self.addEventListener('push', function (event) {
    console.log('[Service Worker] Push Received.');
    console.log(`[Service Worker] Push had this data: "${event.data.text()}"`);

    const title = 'Push Message';
    const options = {
        body: event.data.text(),
        icon: 'images/icon.png',
        badge: 'images/badge.png'
    };

    console.log(event.data);
    event.waitUntil(self.registration.showNotification(title, options));
});


self.addEventListener('notificationclick', function (event) {
    console.log('[Service Worker] Notification click Received.');

    event.notification.close();

    event.waitUntil(
        clients.openWindow('https://developers.google.com/web/')
    );
});