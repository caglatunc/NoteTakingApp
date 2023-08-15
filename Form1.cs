using System.Data;
using System.Linq.Expressions;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable(); //Data Table is going to act as the back end for our data grid view
        bool editing = false; //Editing note or not
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            notes.Columns.Add("Date", typeof(DateTime));

            previousNotes.DataSource = notes;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();//Seçilen satýrý notes veri tablosundan silmeye çalýþýr. Eðer geçerli bir satýr seçilmediyse hata mesajý görüntülenir.
            }

            catch (Exception ex) { Console.WriteLine("Not a valid note"); }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else //yeni bir not ekleniyorsa
            {
                DateTime currentDate = DateTime.Now;
                notes.Rows.Add(titleBox.Text, noteBox.Text, currentDate);

            }
            titleBox.Text = ""; //Her iki metin kutusunun içeriðini temizler, yani yeni bir not eklenirken veya düzenleme tamamlandýgýnda metin kutularý boþaltýlýr.
            noteBox.Text = "";
            editing = false;
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }


    }
}