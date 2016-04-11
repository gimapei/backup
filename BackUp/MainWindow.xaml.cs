using System;
using System.Windows;
using System.Diagnostics;
using BackUp.windows;

namespace BackUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ItemListWindow      songListWnd = new ItemListWindow();
        private PlayItemListWindow  playListWnd = new PlayItemListWindow();
        private EditItemWindow      editWnd     = new EditItemWindow();
        private ControlWindow       controlWnd  = new ControlWindow();
        private MonitorWindow       monitorWnd  = new MonitorWindow();

        public MainWindow()
        {
            log.Debug(":::: 프로그램 시작 :::");
            PresentationTraceSources.DataBindingSource.Listeners.Add(new ConsoleTraceListener());
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Error;

            InitializeComponent();
            log.Debug(":::: 컴포넌트 초기화 완료 :::");
        }

        private void NewDocument(object sender, EventArgs e)
        {

        }

        private void ExitApplication(object sender, EventArgs e)
        {

        }

        private void ShowSongListWindow(object sender, EventArgs e)
        {

        }

        private void ShowPlayListWindow(object sender, EventArgs e)
        {

        }

        private void ShowEditWindow(object sender, EventArgs e)
        {

        }

        private void ShowControlWindow(object sender, EventArgs e)
        {

        }

        private void ShowMonitoringWindow(object sender, EventArgs e)
        {

        }

        private void OnLoaded(object sender, EventArgs e)
        {

        }
        private void OnClosing(object sender, EventArgs e)
        {

        }
    }
}
