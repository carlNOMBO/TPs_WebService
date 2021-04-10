package ws;

import com.sun.jmx.snmp.ServiceName;
import metier.Compte;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@WebService(serviceName = "BanqueWS")
public class BanqueService {
    @WebMethod(operationName = "ConversionEuroToDH")
    public double conversion(@WebParam(name = "montant") double mt){
        return mt*10.7;
    }

    @WebMethod
    public Compte getCompte(@WebParam(name = "code") long code){
        return new Compte(code, Math.random()*7000000, new Date());
    }

    @WebMethod
    public List<Compte> listCompte(){
        List<Compte> comptes = new ArrayList<>();
        comptes.add(new Compte(1, Math.random()*7000000, new Date()));
        comptes.add(new Compte(2, Math.random()*7000000, new Date()));
        comptes.add(new Compte(3, Math.random()*7000000, new Date()));
        comptes.add(new Compte(4, Math.random()*7000000, new Date()));
        comptes.add(new Compte(5, Math.random()*7000000, new Date()));

        return comptes;
    }
}
