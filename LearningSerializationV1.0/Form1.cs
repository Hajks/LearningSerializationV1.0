using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LearningSerializationV1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            Box box = new Box("small box");
            string folderPath = @"C: \Users\Praca\Desktop\Visual StreamWriter\testingObjects.dat";
            using (Stream output = File.Create(folderPath))
            {
                formatter.Serialize(output, box);
            }
            using (Stream input = File.OpenRead(folderPath)) //It works, if we delete stream output stream input can still load data from saved file !
            {
                Box box2 = (Box)formatter.Deserialize(input);
            }
        }
    }
}
