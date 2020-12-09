using ConversorDeFotoBinario.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeFotoBinario
{
    public partial class Imagen : Form
    {
        public string pathzada = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public Imagen()
        {
            InitializeComponent();
            pathzada = pathzada + "/ConversorDeFotoBinario/FotoConvertidaBinario.txt"; //endereço onde cria o arquivo
        }

        private void Imagen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    //O filtro - somente apresentar os arquivos de imagem
                    ofd.Filter = "Arquivos de imagens(*.jpg;*.png*;.jpeg;*.svg)|*.jpg;*.png;*.jpeg;*.svg";
                    //Chamar a janela - entrar somente se confirma a seleção do arquivo
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Carregar a imagem selecionada no picturebox
                        Conversor conversor = new Conversor();
                        var bite = conversor.imageToByteArray(Image.FromFile(ofd.FileName));

                        string test = String.Concat(bite);

                        //cria a ferramenta q vai preencher o arquivo
                        StreamWriter writer = new StreamWriter(pathzada);

                        //Escreve o conteudo convertido em string no arquiivo
                        writer.WriteLine(test);
                        //Exibe a a imagem
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                        MessageBox.Show("Iamgem convertida olhe no aequivo FotoConvertidaBinario.txt na pasta principal do projeto");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
