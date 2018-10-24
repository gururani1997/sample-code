// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Authy.V1.Service.Entity.Factor;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var challenge = ChallengeResource.Create(
            pathServiceSid: "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathIdentity: "PathIdentity",
            pathFactorSid: "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        );

        Console.WriteLine(challenge.Sid);
    }
}
