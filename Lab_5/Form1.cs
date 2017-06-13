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
using IMainInterface;
using Serialiser;
using System.Reflection;

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
        ISerialiser serialiser = new JSONSerializer();
        Type resultType;
        bool flag = true;
        Dictionary<string, ISerialiser> serialiserDict = new Dictionary<string, ISerialiser>()
        {
            { "json", new JSONSerializer() }
        };
        private Type[] types = new Type[]
        {
            typeof(Cup),
            typeof(Pan),
            typeof(Steamer),
            typeof(Tureen)
        };


        public Form1()
        {
            InitializeComponent();
            LoadCreators();
            LoadButtonsDict();
            LoadLabels();
            LoadTextBoxes();
            HideProperties();
        }

        private void LoadCreators()
        {
            creators = new Dictionary<Type, BaseUtensilCreator>();
            creators[typeof(Cup)] = new CupCreator();
            creators[typeof(Pan)] = new PanCreator();
            creators[typeof(Steamer)] = new SteamerCreator();
            creators[typeof(Tureen)] = new TureenCreator();
        }

        private void LoadButtonsDict()
        {
            buttonsDict = new Dictionary<Button, Type>();
            buttonsDict[buttonCup] = typeof(Cup);
            buttonsDict[buttonPan] = typeof(Pan);
            buttonsDict[buttonSteamer] = typeof(Steamer);
            buttonsDict[buttonTureen] = typeof(Tureen);
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

        private void ClearValues()
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
                ClearValues();
            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }

        private void HideProperties()
        {
            foreach (var label in Labels)
                label.Visible = false;
            foreach (var textBox in TextBoxes)
                textBox.Visible = false;
        }

        private void SetPropertyNames(List<string> values)
        {
            int index = 0;
            foreach (var value in values)
            {
                Labels[index].Text = value;
                Labels[index].Visible = true;
                TextBoxes[index++].Visible = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            HideProperties();
            ClearValues();
            resultType = buttonsDict[(Button)sender];
            var propertyNames = creators[resultType].GetPropertyNames();
            SetPropertyNames(propertyNames);
        }

        private bool CheckEmptyList()
        {
            if (listBoxItems.SelectedIndex == -1) return false;
            else return true;
        }

        private void SetPropertyValues(List<string> values)
        {
            int index = 0;
            foreach (var value in values)
            {
                TextBoxes[index++].Text = value;
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckEmptyList())
            {
                if (flag)
                {
                    HideProperties();
                    string nameType = mainList[listBoxItems.SelectedIndex].GetType().Name;
                    foreach (Type t in creators.Keys)
                    {
                        if (t.Name == nameType)
                        {
                            var propertyNames = creators[t].GetPropertyNames();
                            var propertyValues = creators[t].GetProperties(mainList[listBoxItems.SelectedIndex]);
                            SetPropertyNames(propertyNames);
                            SetPropertyValues(propertyValues);
                        }
                    }
                }
                else flag = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Utensil temp = mainList[listBoxItems.SelectedIndex];

            mainList.Remove(temp);
            flag = false;
            listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
            ClearValues();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyList()) 
            {
                if (CheckEmptyTextBoxes())
                {
                    var values = GetPropertyValues();
                    creators[mainList[listBoxItems.SelectedIndex].GetType()].SetProperties(mainList[listBoxItems.SelectedIndex], values);
                }
                else
                    MessageBox.Show("Не все поля заполнены!");

            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)

        {
            if (this.listBoxItems.Items.Count != 0)
            {
                this.openFileDialogSr.Title = "Выберите файл";
                if (openFileDialogSr.ShowDialog() != DialogResult.OK) return;
                if (openFileDialogSr.FileName != string.Empty)
                    serialiser.Serialize(openFileDialogSr.FileName, mainList, types);
                MessageBox.Show("Сериализация выполнена");

            }
            else
                MessageBox.Show("Нечего сериализовать :(");
        }

        private void buttonDesirialized_Click(object sender, EventArgs e)
        {
            List<Utensil> deserilizeList = new List<Utensil>();

            this.openFileDialogSr.Title = "Выберите файл";
            if (openFileDialogSr.ShowDialog() != DialogResult.OK) return;
            if (openFileDialogSr.FileName != string.Empty)
                deserilizeList = serialiser.Deserialize(openFileDialogSr.FileName, types);

            foreach (Utensil ut in deserilizeList)
            {
                listBoxItems.Items.Add(ut.Name);
                mainList.Add(ut);
            }
        }

        private List<Type> GetTypes<T>(Assembly assembly)
        {
            if (!typeof(T).IsInterface) return null;
            return assembly.GetTypes().
                Where(x => x.GetInterface(typeof(T).Name) != null)
                .ToList();
        }

        private void buttonAddPlugin_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "DLL files | *.dll";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Assembly mainAssembly = Assembly.LoadFrom(dlg.FileName);
                List<Type> pluginTypes = GetTypes<IPlugin>(mainAssembly);
                if (pluginTypes.Count != 0)
                {
                    foreach (Type item in pluginTypes)
                    {
                        IPlugin plugin = Activator.CreateInstance(item) as IPlugin;
                        serialiserDict.Add(plugin.GetExt(), plugin.GetSerialiser());
                    }
                }
                checkBoxExt.Visible = Visible;
            }
        }

        private void checkBoxExt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExt.Checked) { serialiser = serialiserDict["xml"]; }
            else serialiser = serialiserDict["json"];
        }
    }
}
