using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_5.Utensils;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        List<Utensil> mainList = new List<Utensil>();
        List<TextBox> TextBoxes;
        List<Label> Labels;
        Utensil utensil;
        Dictionary<Button, Type> buttonsDict;
        Dictionary<Type, BaseUtensilCreator> creators;
        Type resultType;

        public Form1()
        {
            InitializeComponent();
            LoadCreators();
            LoadButtonsDict();
            LoadLabels();
            LoadTextBoxes();
        }

        private void LoadCreators()
        {
            creators = new Dictionary<Type, BaseUtensilCreator>();
            creators[typeof(Cup)] = new CupCreator();
            /*creators[typeof(Pan)] = new CreatePan();
            creators[typeof(Stewpan)] = new CreateStewpan();
            creators[typeof(Plate)] = new CreatePlate();*/
        }

        private void LoadButtonsDict()
        {
            buttonsDict = new Dictionary<Button, Type>();
            buttonsDict[buttonCup] = typeof(Cup);
            /*buttonsDict[btnPan] = typeof(Pan);
            buttonsDict[btnStewpan] = typeof(Stewpan);
            buttonsDict[btnGlass] = typeof(Glass);*/
        }

        private void LoadLabels()
        {
            Labels = new List<Label>();

            Labels.Add(label1);
            Labels.Add(label2);
            Labels.Add(label3);
            Labels.Add(label4);
            Labels.Add(label5);
            Labels.Add(label6);
            Labels.Add(label7);
            Labels.Add(label8);
        }

        private void LoadTextBoxes()
        {
            TextBoxes = new List<TextBox>();

            TextBoxes.Add(textBox1);
            TextBoxes.Add(textBox2);
            TextBoxes.Add(textBox3);
            TextBoxes.Add(textBox4);
            TextBoxes.Add(textBox5);
            TextBoxes.Add(textBox6);
            TextBoxes.Add(textBox7);
            TextBoxes.Add(textBox8);
        }

        private bool CheckEmptyTextBoxes()
        {
            bool flag = true;

            foreach (var textBox in TextBoxes)
            {
                if (textBox.Visible == true)
                {
                    if (textBox.Text == string.Empty) return flag = false;
                }
            }
            return flag;
        }

        private void clearValues()
        {
            foreach (var textBox in TextBoxes)
                textBox.Clear();
        }

        private List<string> GetPropertyValues()
        {
            var values = new List<string>();
            foreach (var textBox in TextBoxes)
                values.Add(textBox.Text);
            return values;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyTextBoxes())
            {
                var values = GetPropertyValues();
                utensil = creators[resultType].CreateUtensil(values);
                mainList.Add(utensil);
                listBoxItems.Items.Add(utensil.Name);
                clearValues();
            }
            else
                MessageBox.Show("Не все поля заполнены!");
            //добавление элемента в список
        }

        private void button_Click(object sender, EventArgs e)
        {
            resultType = buttonsDict[(Button)sender];
        }
    }
}
