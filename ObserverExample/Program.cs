using ObserverExample;

EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();
NovasAgenciasNoticias agenciasNoticias1 = new NovasAgenciasNoticias("Agência de notícia Brasília");
estacaoMeteorologica.Anexar(agenciasNoticias1);

NovasAgenciasNoticias agenciasNoticias2 = new NovasAgenciasNoticias("Agência de notícia Asa Sul");
estacaoMeteorologica.Anexar(agenciasNoticias2);

estacaoMeteorologica.Temperatura = 31.4F;
estacaoMeteorologica.Temperatura = 25F;
estacaoMeteorologica.Temperatura = 26.7F;
estacaoMeteorologica.Temperatura = 34.4F;
estacaoMeteorologica.Temperatura = 22.7F;
estacaoMeteorologica.Temperatura = 15.1F;

Console.ReadLine();
