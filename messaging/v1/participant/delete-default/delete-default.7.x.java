// Install the Java helper library from twilio.com/docs/java/install

import com.twilio.Twilio;
import com.twilio.rest.messaging.v1.session.Participant;

public class Example {
    // Find your Account Sid and Token at twilio.com/console
    public static final String ACCOUNT_SID = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    public static final String AUTH_TOKEN = "your_auth_token";

    public static void main(String[] args) {
        Twilio.init(ACCOUNT_SID, AUTH_TOKEN);
        Participant.deleter(
                "CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
            .delete();
    }
}