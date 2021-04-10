package client;

import proxy.BanqueService;
import proxy.BanqueWS;
import proxy.Compte;

import java.util.List;

public class ClientWS {
    static public void main(String[] args){
        BanqueService stubWS = new BanqueWS().getBanqueServicePort();
        System.out.println(stubWS.conversionEuroToDH(800));
        Compte cp = stubWS.getCompte(1L);
        System.out.println(cp.getCode());
        System.out.println(cp.getSolde());
        List<Compte> comptes = stubWS.listCompte();
        comptes.forEach(c->{
            System.out.println("*****************");
            System.out.println("Code : "+c.getCode());
            System.out.println("Solde : "+c.getSolde());
        });
    }
}
