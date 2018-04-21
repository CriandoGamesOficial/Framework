using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace System.XML.Example
{
    public partial class Form1 : Form
    {
        //caminha pre definido
        string arquivo = @"C:\Users\POSITIVO\Desktop\contato.xml";

        //criando variavel XmlDocument 
        XmlDocument xmlDocument = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
            if(!File.Exists(arquivo))
            {
                //criando arquivo Xml 
                XmlNode nodeRoot = xmlDocument.CreateElement("Contato");
                //colocando o documento dentro do diretorio Raiz
                xmlDocument.AppendChild(nodeRoot);
                //usando o save e passando o caminho
                xmlDocument.Save(arquivo);
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            xmlDocument.Load(arquivo);
            //criando os nodes a serem atribuidos
            XmlNode xmlNome = xmlDocument.CreateElement("Nome");
            XmlNode xmlTelefone = xmlDocument.CreateElement("Telefone");

            //Get informacoes do TextInbox e armazendo em um node
            xmlNome.InnerText = textnome.Text;
            xmlTelefone.InnerText = textTelefone.Text;

            //passando o node de gravacao e rederenciado os dados a serem gravados
            xmlDocument.SelectSingleNode("/Contato").AppendChild(xmlNome);
            xmlDocument.SelectSingleNode("/Contato").AppendChild(xmlTelefone);


            //salvando arquivo
            xmlDocument.Save(arquivo);

        }
    }
}
