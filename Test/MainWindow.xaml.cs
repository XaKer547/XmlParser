using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Test.Models;

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
            
            Ae();
        }

        private void Ae()
        {
            using (var fs = new FileStream(@"C:\Users\student\Downloads\sus.XML", FileMode.Open))
            {
                var data = new XmlSerializer(typeof(EDPFR)).Deserialize(fs);

                //это прям весь объект
                //я бы попробовал посокращать такие путя, но я немного заебался ლ(́◉◞౪◟◉‵ლ)

            }
        }
    }
}
//        List<XmlItem> collection = new();


//        /// <summary>
//        /// Нынешняя позиция чтения
//        /// </summary>
//        private XmlNode node;


//        int x;

//        //потому что мы могли где угодно застрять 
//        Stack<int> positions = new();
//        private void StartParsing()
//        {
//            var doc = new XmlDocument();

//            doc.Load(@"C:\Users\student\Downloads\sus.XML");

//            //берем первую запись
//            positions.Push(0);


//            //Eфс-1         Служебная информация
//            foreach (XmlNode child in doc.DocumentElement.ChildNodes)
//            {
//                node = child;

//                x = 0;

//                ScrollDown();


//                //берет соседа с этого уровня
//                //var a = child.NextSibling;

//                //если в этом уровне уже все пройдено
//                //if(a is null)
//            }
//        }

//        /// <summary>
//        /// Опускается на один уровень в иерархию
//        /// </summary>
//        private void ScrollDown()
//        {
//            var position = positions.Peek();

//            for (int i = position; i < node.ChildNodes.Count; i++)
//            {
//                var item = node.ChildNodes[i];

//                if (item.NodeType == XmlNodeType.Element)
//                {
//                    //прыгаем глубже
//                    node = item;

//                    x++;

//                    positions.Push(i + 1);
//                    positions.Push(0);

//                    ScrollDown();
//                }

//                if (item.NodeType == XmlNodeType.Text)
//                {
//                    collection.Add(new()
//                    {
//                        Name = item.ParentNode.Name,
//                        Value = item.InnerText,
//                        X = x,
//                        Y = i
//                    });

//                    x--;

//                    //идем обратно
//                    node = item.ParentNode;
//                    node = node.ParentNode;
//                    positions.Pop();

//                    ScrollDown();
//                }
//            }
//        }

//        /// <summary>
//        /// Возвращается на один уровень иерархии
//        /// </summary>
//        private void Goback()
//        {
//            if (x == 0)
//                return;

//            x--;



//        }



//        //childNodes до value


//        //NodeType == Element, Value null
//        //NodeType == Text, Value string

//        //if (child.NodeType == XmlNodeType.Text)
//        //{
//        //    yield return new XmlItem()
//        //    {
//        //        Name = child.ParentNode.Name,
//        //        Value = child.InnerText,
//        //        X = x,
//        //        Y = y,
//        //    };
//        //}


//        //foreach (XmlNode kid in child)
//        //{
//        //    foreach (XmlNode node in kid)
//        //    {
//        //        var v = node.ChildNodes;
//        //    }
//        //}



//        private void Fill(XDocument document)
//        {
//            var data = new StringBuilder();

//            //берет каждый тег(один раз) кроме самого первого

//            var a = document.Descendants();


//            foreach (var child in a)
//            {
//                var ac = child.Value;

//                //выдергивает все поля с таким тегом
//                var ae = document.Descendants(child.Name).Select(s => s.Value);


//                var beb = document.Descendants("Страхователь");

//                //если впереди закрывающий тег, то null

//                //следующий тег, (не внутренний)
//                var n = child.NextNode;

//                var qa = child.NodeType;

//            }


//            //как определить иерахию





//        }
//    }
//}

