namespace Application.PokeAPI.Models;

public class Habilidade
{
    public Habilidade1 ability { get; set; }

    public Habilidade(Habilidade1 ability)
    {
        this.ability = ability;
    }
}

public class Habilidade1 : ClasseBase
{

}
