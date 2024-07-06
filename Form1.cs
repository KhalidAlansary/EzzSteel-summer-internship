using System.Data;

namespace cross;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Load += new EventHandler(Form1_Load);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        List<string> departmentNames = DatabaseManager.GetDepartmentNames();
        foreach (string departmentName in departmentNames)
        {
            comboBox1.Items.Add(departmentName);
        }
    }


    private void btn_get_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(comboBox1.Text))
        {
            MessageBox.Show("Department cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string selectedDepartment = comboBox1.Text;

        if (!DatabaseManager.GetDepartmentNames().Contains(selectedDepartment))
        {
            MessageBox.Show("Please enter a valid department.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataTable studentsTable = DatabaseManager.GetStudentsByDepartment(selectedDepartment);
        dataGridView1.DataSource = studentsTable;
    }
}
