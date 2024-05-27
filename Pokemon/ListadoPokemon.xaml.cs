using Newtonsoft.Json;
using Pokemon.Models;
using Pokemon.Servicios;
using System.Diagnostics;

namespace Pokemon;

public partial class ListadoPokemon : ContentPage
{

	public List<PokemonInfo> PokemonList;

	public ListadoPokemon()
	{
	


		InitializeComponent();
		LoadData();
    }


	public async void LoadData()
	{
        PokemonApis _poke_apis = new PokemonApis();
        PokemonList = await _poke_apis.DevuelveListaPokemon();

		Debug.WriteLine("Siuuuuuuuuuuuu");
		Debug.WriteLine(JsonConvert.SerializeObject(PokemonList));
		PokemonList1.ItemsSource = PokemonList;
    }
}