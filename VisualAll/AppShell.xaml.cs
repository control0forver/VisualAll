namespace VisualAll
{
    public partial class AppShell : Shell
    {
        private readonly Timer clockLabelHandler;

        public AppShell()
        {
            InitializeComponent();

            clockLabelHandler = new Timer((_) => { Dispatcher.Dispatch(() => DateTimeNowLabel.Text = DateTime.Now.ToString("ddd MM/d/yyyy - hh:mm:ss tt")); }, null, 0, 100);
        }
    }
}
