package ws;

import javax.xml.ws.Endpoint;

public class ServeurWS {
    public static void main(String[] args){
        String url = "http://0.0.0.0:8686/";//quelque soit l'ip de la machine
        Endpoint.publish(url, new BanqueService());
        System.out.println("Web service déployé avec succès sur : "+url);
    }
}
