# unity-bunnys-adventure-3d

Simple game about a bunny that needs to find all the salad leafs and avoid getting hit by a car :rabbit:

#Lopputyön dokumentaatio

Loppuharjoitustyöni on yksinkertainen peli, jossa ohjataan valkoista kania ja yritetään löytää kaikki salaatinlehdet jäämättä auton alle. 

Käytin unityn ilmaisia grafiikoita pelissäni ja ensimmäiseksi muodostui ongelma, kun tein kani assetista ohjattavaa, 3d-mallin pivot on ilmeisesti vähän pielessä eikä se liikkunut oikeisiin suuntiin. Ongelma ratkesi, kun muutin projektin input-asetuksia. 

Pelikentän objektit asetin staattisiksi ja tein navigation meshin alueelle, jossa autot kulkevat nav mesh agentteina. Asetin autoille pisteet, joita pitkin kulkevat. En halunnut niiden törmäävän toisiinsa tai olevan triggereitä, joten asetin niiden box colliderit kinemaattisiksi ja osuessaan kaniin peli loppuu. 

Valoituksessa käytin lightmapping asetuksia ja halusin pelin olevan mahdollisimman kirkas ja värikäs.

Kerättävät salaatinlehdet laitoin pyörimään akselinsa ympäri, jotta ne huomaisi ympäristöstä paremmin ja ääni soi.

