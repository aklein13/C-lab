using System;

class Osoba
{
    public string Imie;
    public string Nazwisko;
}

public class Konto
{
    public Osoba Wlasciciel;
    private decimal saldo = 0;
    private int pin = 0;
    public Konto()
	{
	}
    private bool SprawdzPin(int pin)
    {
        if (this.pin == pin)
            return true;
        return false;
    }
}
