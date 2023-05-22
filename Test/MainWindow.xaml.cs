using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var document = XDocument.Load(@"C:\Users\student\Downloads\sus.XML");
            //Fill(document);


            StartParsing();
        }

        List<XmlItem> collection = new();


        /// <summary>
        /// Нынешняя позиция чтения
        /// </summary>
        private XmlNode node;


        int x;

        //потому что мы могли где угодно застрять 
        Stack<int> positions = new();
        private void StartParsing()
        {
            var doc = new XmlDocument();

            doc.Load(@"C:\Users\student\Downloads\sus.XML");

            //берем первую запись


            //Eфс-1         Служебная информация
            foreach (XmlNode child in doc.DocumentElement.ChildNodes)
            {
                node = child;

                x = 0;

                ScrollDown();


                //берет соседа с этого уровня
                //var a = child.NextSibling;

                //если в этом уровне уже все пройдено
                //if(a is null)
            }
        }

        /// <summary>
        /// Опускается на один уровень в иерархию
        /// </summary>
        private void ScrollDown()
        {
            //указатель на текущую позицию
            var position = 0;

            foreach (XmlNode item in node.ChildNodes)
            {

                //->
                if (item.NodeType == XmlNodeType.Element)
                {
                    //прыгаем глубже
                    node = item;

                    x++;

                    positions.Push(position);

                    ScrollDown();
                }

                //|
                //V
                if (item.NodeType == XmlNodeType.Text)
                {
                    collection.Add(new()
                    {
                        Name = item.ParentNode.Name,
                        Value = item.InnerText,
                        X = x,
                        Y = position
                    });



                }
            }

            //когда закончили
        }



        /// <summary>
        /// Возвращается на один уровень иерархии
        /// </summary>
        private void Goback()
        {
            if (x == 0)
                return;

            x--;



        }



        //childNodes до value


        //NodeType == Element, Value null
        //NodeType == Text, Value string

        //if (child.NodeType == XmlNodeType.Text)
        //{
        //    yield return new XmlItem()
        //    {
        //        Name = child.ParentNode.Name,
        //        Value = child.InnerText,
        //        X = x,
        //        Y = y,
        //    };
        //}


        //foreach (XmlNode kid in child)
        //{
        //    foreach (XmlNode node in kid)
        //    {
        //        var v = node.ChildNodes;
        //    }
        //}



        private void Fill(XDocument document)
        {
            var data = new StringBuilder();

            //берет каждый тег(один раз) кроме самого первого

            var a = document.Descendants();


            foreach (var child in a)
            {
                var ac = child.Value;

                //выдергивает все поля с таким тегом
                var ae = document.Descendants(child.Name).Select(s => s.Value);


                var beb = document.Descendants("Страхователь");

                //если впереди закрывающий тег, то null

                //следующий тег, (не внутренний)
                var n = child.NextNode;

                var qa = child.NodeType;

            }


            //как определить иерахию





        }
    }
}
