namespace design
{
    /// <summary>
    /// Класс используется для отображения и взаимодействия с коллекцией карточек.
    /// </summary>
    public partial class CollectionCard : Form
    {
        public CollectionCard()
        {
            InitializeComponent();
            Design();
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            Title.Parent = Picture7;
            Title.BackColor = Color.Transparent;
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
        }
    }
}
