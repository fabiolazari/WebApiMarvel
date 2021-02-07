using ApiMarvel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestes
{
	public class Program
	{
		static List<PersonagensMarvel> personagensMarvel = new List<PersonagensMarvel>();
		static readonly string targetPath = string.Format("{0}{1}",
									Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
									@"\personagensMarvel.txt");

		public static void Main(string[] args)
		{
			string mensagemAdicional = string.Empty;
			BuscaTodos();
			GravaArquivo(out mensagemAdicional);
		}

		public static async void BuscaTodos()
		{
			string host = "https://localhost:44321/";
			string metodo = "api/Marvel";
			Marvel marvel = new Marvel();

			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(host);
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var response = await client.GetAsync(metodo))
					{
						if (response.IsSuccessStatusCode)
						{
							String JsonString = await response.Content.ReadAsStringAsync();
							marvel = JsonConvert.DeserializeObject<Marvel>(JsonString);
							GravaDadosPersonagensMarvel(marvel);
						}
					}
				}
			}
			catch (Exception ex) when (!string.IsNullOrEmpty(ex.Message))
			{
				Console.WriteLine("Problemas ao executar a requisição, tente novamente mais tarde!");
			}
			Console.WriteLine("Requisição concluída com sucesso!");
		}

		public static void GravaDadosPersonagensMarvel(Marvel marvel)
		{
			marvel.Data.Results.ForEach(result =>
			{
				personagensMarvel.Add(new PersonagensMarvel()
				{
					Id = result.Id,
					Name = result.Title?.ToString(),
					Description = result.Description?.ToString(),
					Characters = result.Characters?.Items.Select(cha => cha.Name?.ToString()).ToList(),
					Stories = result.Stories?.Items.Select(sto => sto.Name?.ToString()).ToList(),
					Comics = result.Comics?.Items.Select(com => com.Name?.ToString()).ToList(),
					Events = result.Events?.Items.Select(eve => eve.Name?.ToString()).ToList()
				});
			});
		}

		public static bool GravaArquivo(out string mensagemAdicional)
		{
			mensagemAdicional = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				using (StreamWriter streamWriter = File.AppendText(targetPath))
				{
					personagensMarvel.ForEach(personagens =>
					{
						stringBuilder.AppendFormat("Id: {0} \nName: {1} \nDescription: {2}\n", personagens.Id, personagens.Name, personagens.Description);
						stringBuilder.Append("\n");

						stringBuilder.Append("	Characters: \n");
						personagens.Characters.ForEach(cha => stringBuilder.AppendFormat("		{0}\n", cha));
						stringBuilder.Append("\n");

						stringBuilder.Append("	Stories: \n");
						personagens.Stories.ForEach(sto => stringBuilder.AppendFormat("		{0}\n", sto));
						stringBuilder.Append("\n");

						stringBuilder.Append("	Comics: \n");
						personagens.Comics.ForEach(com => stringBuilder.AppendFormat("		{0}\n", com));
						stringBuilder.Append("\n");

						stringBuilder.Append("	Events: \n");
						personagens.Events.ForEach(eve => stringBuilder.AppendFormat("		{0}\n", eve));
						stringBuilder.AppendLine("");
					});

					streamWriter.WriteLine(stringBuilder.ToString());
				}
			}
			catch (IOException ex) when (!string.IsNullOrEmpty(ex.Message))
			{
				mensagemAdicional = ex.Message;
				return false;
			}
			return true;
		}
	}
}
