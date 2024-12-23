using ScottPlot.WinUI;
using ScottPlot;

namespace ScottPlotTester2.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        WinUIPlot1.Plot.Add.Signal(Generate.Sin(51));
        WinUIPlot1.Plot.Add.Signal(Generate.Cos(51));
        WinUIPlot1.Refresh();
    }
}
