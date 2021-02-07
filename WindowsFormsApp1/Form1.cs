using ApiMarvel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		#region ...:: Variáveis ::...

		List<PersonagensMarvel> personagensMarvel = new List<PersonagensMarvel>();
		readonly string targetPath = string.Format("{0}{1}",
							Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
							@"\personagensMarvel.txt");

		#endregion

		#region ..:: Construtor ::..

		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region ..:: Eventos ::..

		private void btnBucaPeloId_Click(object sender, EventArgs e)
		{
			if (ValidaDados())
			{
				BuscaPeloId();
				CarregaGridResultados();
			}
		}

		private void btnBuscaTodos_Click(object sender, EventArgs e)
		{
			BuscaTodos();
			CarregaGridResultados();
		}

		private void btnGravaArquivo_Click(object sender, EventArgs e)
		{
			string mensagemAdicional = string.Empty;

			if (GravaArquivo(out mensagemAdicional))
				MessageBox.Show("Arquivo gravado com sucesso!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(string.Format("Problemas ao gravar o arquivo: {0}, verifique!", mensagemAdicional), "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void txtId_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = DigitarApenasNumeros(e);
		}

		#endregion

		#region ..:: Métodos ::..

		public async void BuscaPeloId()
		{
			string host = "https://localhost:44321/";
			string metodo = "api/Marvel/";
			Marvel marvel = new Marvel();

			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(host);
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var response = await client.GetAsync(string.Format("{0}{1}", metodo, txtId.Text.Trim())))
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
				MessageBox.Show("Problemas ao executar a requisição pelo campo Id, tente novamente mais tarde!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("Requisição pelo campo Id concluída com sucesso!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public async void BuscaTodos()
		{
			//string JsonString = System.IO.File.ReadAllText(@"C:\Users\Fábio Costa\Desktop\retorno.json");
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
				MessageBox.Show("Problemas ao executar a requisição, tente novamente mais tarde!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("Requisição concluída com sucesso!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		public bool ValidaDados()
		{
			if (string.IsNullOrEmpty(txtId.Text))
			{
				MessageBox.Show("Campo Id não pode estar vazio, verifique!", "Marvel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		public static bool DigitarApenasNumeros(KeyPressEventArgs e)
		{
			return !char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8;
		}

		public void GravaDadosPersonagensMarvel(Marvel marvel)
		{
			/*
			foreach (Result result in marvel.Data.Results)
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
			}
			*/
			
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

		public void CarregaGridResultados()
		{
			dgvResultado.AutoGenerateColumns = true;
			dgvResultado.DataSource = null;
			dgvResultado.DataSource = personagensMarvel;
			dgvResultado.Columns[0].Width = 80;
			dgvResultado.Columns[1].Width = 300;
			dgvResultado.Columns[2].Width = 400;
			Application.DoEvents();
			dgvResultado.Refresh();
		}

		public bool GravaArquivo(out string mensagemAdicional)
		{
			mensagemAdicional = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				using (StreamWriter streamWriter = File.AppendText(targetPath))
				{
					/*
					foreach (PersonagensMarvel personagens in personagensMarvel)
					{
						stringBuilder.AppendFormat("Id: {0} \nName: {1} \nDescription: {2}\n", personagens.Id, personagens.Name, personagens.Description);
						stringBuilder.Append("\n");
						stringBuilder.Append("	Characters: \n");

						foreach (string nome in personagens.Characters)
						{
							stringBuilder.AppendFormat("		{0}\n", nome);
						}
						stringBuilder.Append("\n");
						stringBuilder.Append("	Stories: \n");
						foreach (string nome in personagens.Stories)
						{
							stringBuilder.AppendFormat("		{0}\n", nome);
						}
						stringBuilder.Append("\n");
						stringBuilder.Append("	Comics: \n");
						foreach (string nome in personagens.Comics)
						{
							stringBuilder.AppendFormat("		{0}\n", nome);
						}
						stringBuilder.Append("\n");
						stringBuilder.Append("	Events: \n");
						foreach (string nome in personagens.Events)
						{
							stringBuilder.AppendFormat("		{0}\n", nome);
						}
						stringBuilder.AppendLine("\n");

					}
					*/
					
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

		#endregion

	}
}
