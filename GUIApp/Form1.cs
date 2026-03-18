using DotNet_Java_Lab1;

namespace GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBTN_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            int n = 0;
            int seed = 0;
            int capacity = 0;

            // Num of itmes
            if (!int.TryParse(numOfItemsTxt.Text, out n) || n <= 0)
            {
                numOfItemsTxt.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                numOfItemsTxt.BackColor = SystemColors.Window;
            }

            // Seed
            if (!int.TryParse(seedTxt.Text, out seed))
            {
                seedTxt.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                seedTxt.BackColor = SystemColors.Window;
            }

            // Capacity
            if (!int.TryParse(capacityTxt.Text, out capacity) || capacity <= 0)
            {
                capacityTxt.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                capacityTxt.BackColor = SystemColors.Window;
            }

            // Stop on invalid
            if (!isValid)
            {
                MessageBox.Show("Incorrect data. Insert correct data.",
                                "Validation error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Main logic
            try
            { 
                Problem problem = new Problem(n, seed);

                itemsTxt.Text = problem.ToString();


                Result result = problem.solve(capacity);

                resultTxt.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error while running logic: {ex.Message}",
                                "Critical error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
