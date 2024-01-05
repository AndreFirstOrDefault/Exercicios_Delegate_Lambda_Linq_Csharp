/*
7- Suponha que você possui uma lista de planetas com informações sobre o nome, diâmetro e massa de cada 
planeta. 
Crie um programa e implemente um método que recebe essa lista e um delegate Predicate<Planeta> para 
filtrar os planetas de acordo com um critério específico. 
 
*/

List<Planeta> planetas = new List<Planeta>
{
            new Planeta { Nome = "Mercúrio", Diametro = 4879, Massa = 3.3011 * Math.Pow(10, 23) },
            new Planeta { Nome = "Vênus", Diametro = 12104, Massa = 4.8675 * Math.Pow(10, 24) },
            new Planeta { Nome = "Terra", Diametro = 12742, Massa = 5.97237 * Math.Pow(10, 24) },
            new Planeta { Nome = "Marte", Diametro = 6779, Massa = 6.4171 * Math.Pow(10, 23) },
            new Planeta { Nome = "Júpiter", Diametro = 139820, Massa = 1.8982 * Math.Pow(10, 27) },
            new Planeta { Nome = "Saturno", Diametro = 116460, Massa = 5.6834 * Math.Pow(10, 26) },
            new Planeta { Nome = "Urano", Diametro = 50724, Massa = 8.6810 * Math.Pow(10, 25) },
            new Planeta { Nome = "Netuno", Diametro = 49244, Massa = 1.02413 * Math.Pow(10, 26) }
};

Planeta p = new Planeta();
p.FiltroDePlanetas(planetas);
Console.ReadKey();

public class Planeta
{
    public string? Nome { get; set; }
    public double Diametro { get; set; } // em quilômetros
    public double Massa { get; set; } // em quilogramas

    //Predicate<Planeta> planetaGrande = p => p.Diametro > 10000;
    //Predicate<Planeta> planetaGrande = p => p.Nome.Contains('a');
    //Predicate<Planeta> planetaGrande = p => p.Massa >= 5.97237 * Math.Pow(10, 24);
    Predicate<Planeta> planetaGrande = p => p.Nome.StartsWith('T');

    public void FiltroDePlanetas(List<Planeta> planetas)
    {
        foreach (var item in planetas)
        {
            if (item != null)
            {
                if (planetaGrande(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

    public override string ToString()
    {
        return $"Nome: {Nome}\tDiâmetro: {Diametro} Km\tMassa: {Massa/1000} Toneladas";
    }
}