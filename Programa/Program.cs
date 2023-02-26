using Modelos;

var dolar1 = new Dolares(100);
Billetera.AgregarMoneda(dolar1);

var crypto1 = new Crypto();
crypto1.tipoDeCrypto = Crypto.Cryptos.Bitcoin;
crypto1.Cantidad = 5;
Billetera.AgregarMoneda(crypto1);

var dolar2 = new Dolares(2);
Billetera.AgregarMoneda(dolar2);

var dolar3 = new Dolares(50);
Billetera.AgregarMoneda(dolar3);

var crypto2 = new Crypto();
crypto2.tipoDeCrypto = Crypto.Cryptos.Ethereum;
crypto2.Cantidad = 14;
Billetera.AgregarMoneda(crypto2);

Billetera.MostrarMonedas(210);


var dolar4 = new Dolares(100);
Billetera.AgregarMoneda(dolar4);






