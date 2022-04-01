using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_Project_GUI
{
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Medijana");
            comboBox1.Items.Add("Palilula");
            comboBox1.Items.Add("Crveni krst");
            comboBox1.Items.Add("Pantelej");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void opstina_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (comboBox1.Text == "Medijana")
            {
                dataGridView1.Rows.Add("9. бригаде", "1", "2", "");
                dataGridView1.Rows.Add("Булевар др Зорана Ђинђића", "1", "ВЗ", "испред кућног броја 2");
                dataGridView1.Rows.Add("Булевар др Зорана Ђинђића", "1", "ВЗ", "испред кућног броја 8");
                dataGridView1.Rows.Add("Булевар др Зорана Ђинђића", "1", "ВЗ", "испред СИМПА");
                dataGridView1.Rows.Add("Булевар Немањића", "1", "E", "Код пијаце „Криве ливаде“");
                dataGridView1.Rows.Add("Византијски булевар", "3", "ВЗ", "");
                dataGridView1.Rows.Add("Војводе Танкосића", "2", "2", "Дом здравља");
                dataGridView1.Rows.Add("Војводе Танкосића", "1", "2", "Месна заједница „Филип Кљајић“");
                dataGridView1.Rows.Add("Гаража “Горан Остојић”", "4", "П", "Код Дома здравља");
                dataGridView1.Rows.Add("Доситеја Обрадовића", "2", "2", "Месна канцеларија");
                dataGridView1.Rows.Add("Драгише Цветковић", "1", "ВЗ", "");
                dataGridView1.Rows.Add("Јеронимова", "2", "2", "Гимназија 9. мај");
                dataGridView1.Rows.Add("Јована Ристића", "1", "2", "Општинска организација цивилних инвалида рата");
                dataGridView1.Rows.Add("Јована Скерлића", "1", "2", "");
                dataGridView1.Rows.Add("Југовићева", "1", "2", "код кућног броја 24");
                dataGridView1.Rows.Add("Кеј Кола српских сестара", "2", "2", "Војни диспанзер");
                dataGridView1.Rows.Add("Наде Томић", "2", "1", "испред Услужног центра код бр.13");
                dataGridView1.Rows.Add("Николе Пашића", "3", "E", "ТЦ Калча");
                dataGridView1.Rows.Add("Николе Пашића", "4", "E", "Скупштина Града");
                dataGridView1.Rows.Add("Обилићев венац - плато", "1", "1", "испред  Телекома");
                dataGridView1.Rows.Add("Орловића Павла", "2", "1", "Главна пошта");
                dataGridView1.Rows.Add("Париске Комуне", "2", "2", "ГО Медијана");
                dataGridView1.Rows.Add("Паркиралиште Синђелићев Трг", "6", "П", "");
                dataGridView1.Rows.Add("Паркиралиште Чаир", "3", "П", "Код источне трибине стадиона Чаир");
                dataGridView1.Rows.Add("ПЛАТО у 9. бригаде", "3", "2", "Паркинг поред хале Чаир");
                dataGridView1.Rows.Add("Првомајска", "1", "2", "код школе");
                dataGridView1.Rows.Add("Пријездина", "3", "2", "Саборна Црква");
                dataGridView1.Rows.Add("Рајићева", "2", "2", "");
                dataGridView1.Rows.Add("Светозара Марковића", "2", "1", "Међуопштинска организација савеза слепих");
                dataGridView1.Rows.Add("Синђелићев Трг (код Дечје библ.)", "2", "2", "Спортски савез инвалида");
                dataGridView1.Rows.Add("Стојана Новаковића", "2", "2", "");
                dataGridView1.Rows.Add("Страхињића бана", "1", "1", "испред кућног броја 02");
                dataGridView1.Rows.Add("Трг 14. октобра", "2", "2", "Пошта");
                dataGridView1.Rows.Add("Трг Краља Александра", "3", "2", "Правни и Економски факултет");
                dataGridView1.Rows.Add("Ћирила и Методија", "3", "2", "Филозофски факултет");
                dataGridView1.Rows.Add("Хајдук Вељкова", "3", "2", "Градска огранизација инвалида рада");
                dataGridView1.Rows.Add("Цара Душана", "2", "1", "Републички фонд за здравствено осигурање");
                dataGridView1.Rows.Add("Цара Душана", "1", "2", "испред кућног броја 92, на раскрсници са Првомајском");        
            }

            else if (comboBox1.Text == "Palilula")
            {
                dataGridView1.Rows.Add("Божидарчева", "1", "ВЗ", "испред кућног броја 24");
                dataGridView1.Rows.Add("Марина Држића", "1", "ВЗ", "Здравствена станица Делијски Вис");
            }

            else if (comboBox1.Text == "Crveni krst")
            {
                dataGridView1.Rows.Add("Ђуке Динић", "4", "E", "Пијаца „Тврђава“");
                dataGridView1.Rows.Add("Јелене Димитријевић", "1", "2", "преко пута амбуланте");
                dataGridView1.Rows.Add("Кеј Мике Палигорића", "2", "2", "Зграда Универзитета");
                dataGridView1.Rows.Add("Паркиралиште Ровче", "4", "2", "");
            }

            else 
            {
                dataGridView1.Rows.Add("Kњажевачка", "4", "ВЗ", "Градско Удружење церебралне и дечије парализе Ниш");
                dataGridView1.Rows.Add("Србињска", "4", "БЗ", "код Дурланске пијаце");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Izaberite opstinu";
        }
    }
}
