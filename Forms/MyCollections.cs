namespace design
{
    public partial class MyCollections : Form
    {
        public MyCollections()
        {
            InitializeComponent();
            Design();
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            Text1.Parent = Picture7;
            Text1.BackColor = Color.Transparent;
        }

        private void AddCollectionButton_Click(object sender, EventArgs e)
        {
            CreateNewList createNewList = new CreateNewList();
            createNewList.ShowDialog();
        }

       
    }
}
