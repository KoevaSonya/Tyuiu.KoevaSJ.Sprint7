using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tyuiu.KoevaSJ.Sprint7.Project.V12.Forms
{
    public partial class FormProduct : Form
    {
        public BindingList<Product> productList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;
        public FormProduct()
        {
            InitializeComponent();
            productList = new BindingList<Product>();
            bindingSource = new BindingSource(productList, null);

            dataGridViewTable_KSJ.DataSource = bindingSource;
        }



        private void buttonAdd_KSJ_Click_1(object sender, EventArgs e)
        {
            try
            {
                string model = textBoxModel_KSJ.Text;
                int price = Convert.ToInt32(textBoxPrice_KSJ.Text);
                string color = textBoxColor_KSJ.Text;
                string processor = textBoxProcessor_KSJ.Text;
                string memory = textBoxMemory_KSJ.Text;
                string hd = textBoxHD_KSJ.Text;

                // Создаем объект продукта
                Product newProduct = new Product(model, price, color, processor, memory, hd);

                // Добавляем продукт в список
                productList.Add(newProduct);

                // Очищаем текстовые поля после добавления
                textBoxModel_KSJ.Clear();
                textBoxPrice_KSJ.Clear();
                textBoxColor_KSJ.Clear();
                textBoxProcessor_KSJ.Clear();
                textBoxMemory_KSJ.Clear();
                textBoxHD_KSJ.Clear();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonOpenFile_KSJ_Click_1(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл для открытия";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // Парсим заголовки столбцов
                    string[] headers = lines[0].Split(',');

                    // Очищаем старые данные в BindingList
                    productList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');
                        productList.Add(new Product
                        {
                            Model = values[0],
                            Price = Convert.ToInt32(values[1]),
                            Color = values[2],
                            Processor = values[3],
                            Memory = values[4],
                            Hd = values[5],

                        });
                    }

                    MessageBox.Show("Файл успешно открыт!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_KSJ_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewTable_KSJ.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridViewTable_KSJ.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                // Удалить продукт из списка
                productList.Remove(selectedProduct);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSaveFile_KSJ_Click_1(object sender, EventArgs e)
        {
            try
            {

                string directoryPath = $@"{Directory.GetCurrentDirectory()}";
                string fileName = "TableOfOrder.csv";
                string path = Path.Combine(directoryPath, fileName);

                string header = string.Join(",", dataGridViewTable_KSJ.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));

                // Создаем строки для каждой записи данных
                List<string> lines = new List<string>();
                foreach (DataGridViewRow row in dataGridViewTable_KSJ.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()));
                        lines.Add(line);
                    }
                }

                // Соединяем заголовок и строки вместе
                string content = header + Environment.NewLine + string.Join(Environment.NewLine, lines);

                // Записываем содержимое в файл
                File.WriteAllText(path, content);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен!\nОткрыть его в блокнотике?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public class Product
        {
            public string Model { get; set; }
            public int Price { get; set; }
            public string Color { get; set; }
            public string Processor { get; set; }
            public string Memory { get; set; }
            public string Hd { get; set; }


            // Конструктор по умолчанию 
            public Product()
            {

            }
            public Product(string model, int price, string color, string processor, string memory, string hd)
            {
                Model = model;
                Price = price;
                Color = color;
                Processor = processor;
                Memory = memory;
                Hd = hd;

            }
        }

        private void SortDataGridViewByColumn(string columnName)
        {
            if (currentSortOrder == SortOrder.Ascending)
            {
                bindingSource.DataSource = new BindingList<Product>(productList.OrderBy(x => typeof(Product).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Descending;
            }
            else
            {
                bindingSource.DataSource = new BindingList<Product>(productList.OrderByDescending(x => typeof(Product).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Ascending;
            }
        }

        private void buttonSort_KSJ_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sortName = textBoxSort_KSJ.Text;
                SortDataGridViewByColumn(sortName);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchInDataGridView(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Если поле поиска пусто, отобразить все данные
                dataGridViewTable_KSJ.DataSource = bindingSource;
            }
            else
            {
                // Иначе выполните поиск и отобразить результаты
                var searchResults = productList.Where(product =>
                    product.Price.ToString().Contains(searchText) ||
                    product.Model.Contains(searchText) ||
                    product.Color.Contains(searchText) ||
                    product.Processor.Contains(searchText) ||
                    product.Memory.Contains(searchText) ||
                    product.Hd.Contains(searchText)

                ).ToList();

                dataGridViewTable_KSJ.DataSource = new BindingList<Product>(searchResults);
            }
        }

        private void textBoxSerach_KSJ_TextChanged_1(object sender, EventArgs e)
        {
            SearchInDataGridView(textBoxSerach_KSJ.Text);
        }

        private void textBoxPrice_KSJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // только циферки)
        }

        private void saveFileDialog_KSJ_FileOk(object sender, CancelEventArgs e)
        {

        }

       
    }
}
