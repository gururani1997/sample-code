// Download the helper library from https://www.twilio.com/docs/node/install
// Your Account Sid and Auth Token from twilio.com/console
const accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
const authToken = 'your_auth_token';
const client = require('twilio')(accountSid, authToken);

client.calls
      .create({
         record: true,
         url: 'http://demo.twilio.com/docs/voice.xml',
         to: '+14155551212',
         from: '+15017122661'
       })
      .then(call => console.log(call.sid));
