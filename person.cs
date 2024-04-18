using System;

public class Class1
{
	public Class1()
	{

    public int Id { get; set; }
    public string Vezeteknev { get; set; }
    public string Keresztnev { get; set; }
    public string Targy { get; set; }
    public int Szazalek { get; set; }

    public int Erdemjegy
    {
        get
        {
            if (Szazalek < 25) { return 1; }
            else if (Szazalek < 40) { return 2; }
            else if (Szazalek < 60) { return 3; }
            else if (Szazalek < 80) { return 4; }
            else if (Szazalek >= 80) { return 5; }
            else { return 1; }
        }
    }

    public Eredmeny(int id, string vezeteknev, string keresztnev, string targy, int szazalek)
    {
        this.Id = id;
        this.Vezeteknev = vezeteknev;
        this.Keresztnev = keresztnev;
        this.Targy = targy;
        this.Szazalek = szazalek;

    }





}
}
