using SAIMS.BusinessLogic.Controller;

namespace SAIMS.UI
{
    public partial class Category : Form
    {
        private readonly CategoryController controller = new CategoryController();
        public Category()
        {
            InitializeComponent();
            dgvCategory.ReadOnly = true;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadCategories();
        }
        private void LoadCategories()
        {
            dgvCategory.DataSource = controller.GetCategories();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using var form = new CreateCategory();
            if (form.ShowDialog() == DialogResult.OK)
                LoadCategories();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCategory();
            if (selected == null) return;

            using CreateCategory form = new CreateCategory(selected.Value.id, selected.Value.name);
            if (form.ShowDialog() == DialogResult.OK)
                LoadCategories();
        }
        private (int id, string name)? GetSelectedCategory()
        {
            if (dgvCategory.CurrentRow == null)
            {
                MessageBox.Show("Please select a category first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            int id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["Id"].Value);
            string name = dgvCategory.CurrentRow.Cells["Name"].Value.ToString();
            return (id, name);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCategory();
            if (selected == null) return;

            DialogResult confirm = MessageBox.Show(
                $"Delete category \"{selected.Value.name}\"?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string error = controller.DeleteCategory(selected.Value.id);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadCategories();
        }
        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, e);
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
