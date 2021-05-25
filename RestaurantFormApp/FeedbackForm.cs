using System;
using System.IO;
using System.Windows.Forms;
using DataAccess;
using RestaurantObjects;

namespace RestaurantFormApp
{
    public partial class FeedbackForm : Form
    {

        IDataAccessFeedbacks adminFeedbacks = FeedbackDataFactory.GetFeedbacksDataAccess();
        public FeedbackForm()
        {
            InitializeComponent();
            PopulateFeedbackTable();
        }

        void PopulateFeedbackTable()
        {
            Log.AllFeedbacks.Clear();
            Log.AllFeedbacks = adminFeedbacks.GetFeedbacks();
            ListFeedback.DataSource = null;
            ListFeedback.DataSource = Log.AllFeedbacks;
        }

        void Clear()
        {
            TxtFeedbackFrom.Text = String.Empty;
            TxtFeedbackMessage.Text = String.Empty;
        }

        private void BtnFeedbackSubmit_Click(object sender, System.EventArgs e)
        {
            int rating = 1;
            if (RdFeedback1Star.Checked)
                rating = 1;
            if (RdFeedback2Stars.Checked)
                rating = 2;
            if (RdFeedback3Stars.Checked)
                rating = 3;
            if (RdFeedback4Stars.Checked)
                rating = 4;
            if (RdFeedback5Stars.Checked)
                rating = 5;
            adminFeedbacks.AddFeedback(new Feedback(DtFeedbackDate.Value, TxtFeedbackFrom.Text, TxtFeedbackMessage.Text, rating));
            PopulateFeedbackTable();
            Clear();
        }

        private void BtnExportFeedbacks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.DefaultExt = "txt";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String fileName = saveDialog.FileName;
                try
                {
                    using (StreamWriter swFisierText = new StreamWriter(fileName, true))
                    {
                        foreach (Feedback f in Log.AllFeedbacks)
                        {
                            swFisierText.WriteLine(f.ConvertToFileString());
                        }
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("The file couldn't be open. Error: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Generric Error: " + eGen.Message);
                }
            }
        }
    }
}
