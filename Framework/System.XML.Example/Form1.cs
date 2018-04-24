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
            if (!File.Exists(arquivo))
            {
                //criando arquivo Xml 
                XmlNode nodeRoot = xmlDocument.CreateElement("Contatos");
                //colocando o documento dentro do diretorio Raiz
                xmlDocument.AppendChild(nodeRoot);
                //usando o save e passando o caminho
                xmlDocument.Save(arquivo);
            }

            ReadAgenda();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            xmlDocument.Load(arquivo);
            //criando os nodes a serem atribuidos
            XmlNode xmlNome = xmlDocument.CreateElement("Nome");
            XmlNode xmlTelefone = xmlDocument.CreateElement("Telefone");

            //criando um novo no e atrelando ao arquivo
            XmlNode nodeChild = xmlDocument.CreateElement("Contato");
            //adicioando elemento contato no começo da lista de filhos.
            xmlDocument.SelectSingleNode("Contatos").PrependChild(nodeChild);

            //Get informacoes do TextInbox e armazendo em um node
            xmlNome.InnerText = textnome.Text;
            xmlTelefone.InnerText = textTelefone.Text;

            //passando o node de gravacao e rederenciado os dados a serem gravados
            xmlDocument.SelectSingleNode("Contatos/Contato").AppendChild(xmlNome);
            xmlDocument.SelectSingleNode("Contatos/Contato").AppendChild(xmlTelefone);


            //salvando arquivo
            xmlDocument.Save(arquivo);

        }


        private void ReadAgenda()
        {
            xmlDocument.Load(arquivo);

            foreach (XmlNode no in xmlDocument.GetElementsByTagName("Contato"))
            {
                label1.Text += "Nome: " + no.ChildNodes[0].InnerText;

            }

        }
    }
}

