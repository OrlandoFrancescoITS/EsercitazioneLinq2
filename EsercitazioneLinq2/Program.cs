using EsercitazioneLinq2;

Box box = new Box("a2b","via le mani dal naso",70032,"Bitonto",4,"Box",4);
Villa villa = new Villa("c3d", "via dalle scatole", 70032, "Bitonto", 5, "villa",4,3,4);

Agenzia agenzia = new Agenzia();
agenzia.listaImmobili.Add(box);
agenzia.listaImmobili.Add(villa);

agenzia.cerca("a2b");