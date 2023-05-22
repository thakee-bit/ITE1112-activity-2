namespace ITE1112_activity_2
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();

      txtAverage.ReadOnly = true;
      txtGrade.ReadOnly = true;

    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      int subject1 = 0, subject2 = 0;

      if (!int.TryParse(txtSubject1.Text, out subject1) || subject1 < 0 || subject1 > 100)
      {
        MessageBox.Show("Invalid input for subject 1, it should be an integer between 0 and 100.", "Error!");
        return;
      }

      if (!int.TryParse(txtSubject2.Text, out subject2) || subject2 < 0 || subject2 > 100)
      {
        MessageBox.Show("Invalid input for subject 2, it should be an integer between 0 and 100.", "Error!");
        return;
      }

      int average = (subject1 + subject2) / 2;

      txtAverage.Text = average.ToString();
      txtGrade.Text = getGrade(average).ToString();
    }

    private char getGrade(int marks)
    {
      if (marks > 75) return 'A';
      else if (marks > 65) return 'B';
      else if (marks > 40) return 'C';
      else return 'F';
    }
  }
}