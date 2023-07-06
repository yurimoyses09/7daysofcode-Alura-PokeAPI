namespace Application.PokeAPI.Models;

public class Mascote : ClasseBase
{
    public List<Habilidade> abilities { get; set; }
    public List<Forma> forms { get; set; }
    public int height { get; set; }
    public string location_area_encounters { get; set; }
    public int weight { get; set; }

    public Mascote(List<Habilidade> abilities, List<Forma> forms, int height, string location_area_encounters, int weight)
    {
        this.abilities = abilities;
        this.forms = forms;
        this.height = height;
        this.location_area_encounters = location_area_encounters;
        this.weight = weight;
    }
}