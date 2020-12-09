using ConversorDeFoto.Forms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeFoto.Forms
{
    public partial class TelaDeInicio : Form
    {
        public string pathzada = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public TelaDeInicio()
        {
            InitializeComponent();

            pathzada = pathzada + "/ConversorDeFoto.Forms/FotoConvertida.txt"; //endereço onde cria o arquivo
        }

        private void bt_SelecionarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    //O filtro - somente apresentar os arquivos de imagem
                    ofd.Filter = "Arquivos de imagens(*.jpg;*.png*;.jpeg;)|*.jpg;*.png;*.jpeg";
                    //Chamar a janela - entrar somente se confirma a seleção do arquivo
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Carregar a imagem selecionada no picturebox
                        Conversor conversor = new Conversor();
                        var bite = conversor.imageToByteArray(Image.FromFile(ofd.FileName));
                        var ar = ofd.FileName;

                        //cria a ferramenta q vai preencher o arquivo
                        StreamWriter writer = new StreamWriter(pathzada);

                        //Escreve o conteudo convertido em string no arquiivo
                        writer.WriteLine(bite);
                        //Exibe a a imagem
                        Imagen.Image = Image.FromFile(ofd.FileName);

                        MessageBox.Show("Imagem convertida com sucesso,olhe no FotoConvertida.txt na pasta principal do projeto");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void Imagen_Click(object sender, EventArgs e)
        {

        }
        private void bt_ArrayToImage_Click(object sender, EventArgs e)
        {
            try
            {
                //cria  o objeto q vai converter 
                Conversor conversor = new Conversor();

                //le tds as linhas do arquivoS
                var linhas = File.ReadAllLines(pathzada);

                //ReadALL lines sempre retorna um array o concat transforma td em uma string
                string test = String.Concat(linhas);

                //vai ao conversor levando uma string ,converte ela para byte e dps para imagem
                var image = conversor.Base64ToImage(test);

                Imagen.Image = image;
            }
            catch (Exception cex)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Erro");
            }
        }

        private void TelaDeInicio_Load(object sender, EventArgs e)
        {
        }
    }
}
