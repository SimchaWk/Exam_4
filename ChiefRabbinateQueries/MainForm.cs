using ChiefRabbinateQueries.Model;
using static ChiefRabbinateQueries.Service.DateService;
namespace ChiefRabbinateQueries
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CreateXmlIfNotExist();

            // DateModel dateModel = new DateModel("יום", "יום בחודש", "חודש", "שנה", "מחרוזת תוצאה");
            // AddNewDate(dateModel);
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {

            DateModel newDate = AddNewDate(GenerateDateModelFromUI());
            ResultLabel.Text = newDate.Result;
        }

        private DateModel GenerateDateModelFromUI()
        {
            Dictionary<string, string> weekDays = new()
            {
                { "ראשון", "באחד" },
                { "שני", "בשני" },
                { "שלישי", "בשלישי" },
                { "רביעי", "ברביעי" },
                { "חמישי", "בחמישי" },
                { "ששי", "בששי" }
            };

            Dictionary<string, string> nextMunths = new()
            {
                { "תשרי", "מרחשון" },
                { "מרחשון", "כסלו" },
                { "כסלו", "טבת" },
                { "טבת", "שבט" },
                { "שבט", "אדר" },
                { "אדר", "ניסן" },
                { "ניסן", "אייר" },
                { "אייר", "סיון" },
                { "סיון", "תמוז" },
                { "תמוז", "אב" },
                { "אב", "אלול" },
                { "אלול", "תשרי" },
                { "אדר הראשון", "אדר השני" },
                { "אדר השני", "ניסן" },
            };

            Dictionary<string, string> monthDays = new()
            {
                { "1", "יום אחד" },
                { "2", "שני ימים" },
                { "3", "שלשה ימים" },
                { "4", "ארבעה ימים" },
                { "5", "חמשה ימים" },
                { "6", "ששה ימים" },
                { "7", "שבעה ימים" },
                { "8", "שמנה ימים" },
                { "9", "תשעה ימים" },
                { "10", "עשרה ימים" },
                { "11", "אחד עשר יום" },
                { "12", "שנים עשר יום" },
                { "13", "שלשה עשר יום" },
                { "14", "ארבעה עשר יום" },
                { "15", "חמשה עשר יום" },
                { "16", "ששה עשר יום" },
                { "17", "שבעה עשר יום" },
                { "18", "שמנה עשר יום" },
                { "19", "תשעה עשר יום" },
                { "20", "עשרים יום" },
                { "21", "אחד ועשרים יום" },
                { "22", "שנים ועשרים יום" },
                { "23", "שלשה ועשרים יום" },
                { "24", "ארבעה ועשרים יום" },
                { "25", "חמשה ועשרים יום" },
                { "26", "ששה ועשרים יום" },
                { "27", "שבעה ועשרים יום" },
                { "28", "שמנה ועשרים יום" },
                { "29", "תשעה ועשרים יום" },
                { "30", $"יום שלשים לחודש {MonthComboBox.Text} שהוא ראש חודש {nextMunths[MonthComboBox.Text]}" }
            };

            string day = WeekDayComboBox.Text;
            string dayMonth = MonthDayComboBox.Text;
            string month = MonthComboBox.Text;
            string year = YearComboBox.Text;
            string result = 
                $"{weekDays[WeekDayComboBox.Text]} בשבת {monthDays[MonthDayComboBox.Text]} לירח {month} שנת {year} לבריאת העולם";

            DateModel newData = new(day, dayMonth, month, year, result);

            return newData;

        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
