using SAIMS.BusinessLogic.Controller;

namespace SAIMS.UI
{
    public partial class CreateCategory : Form
    {
        private readonly CategoryController controller = new CategoryController();
        private readonly int? editId;   
        public CreateCategory()
        {
            InitializeComponent();
        }

        public CreateCategory(int id, string currentName) : this()
        {
            editId = id;
            txtCategoryName.Text = currentName;
            this.Text = "Edit Category";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = editId.HasValue
                ? controller.UpdateCategory(editId.Value, txtCategoryName.Text)
                : controller.AddCategory(txtCategoryName.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            MessageBox.Show(editId.HasValue ? "Category updated!" : "Category saved!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
