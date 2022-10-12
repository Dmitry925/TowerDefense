using SFML.Graphics;
using SFML.Window;

window = new RenderWindow(new VideoMode(600, 400), "Tower Defence", Styles.Titlebar | Styles.Close);
window.SetVerticalSyncEnabled(true);


while (window.IsOpen)
{
    window.DispatchEvents();

    window.Closed += _Close!;

    window.Clear(Color.Black);

    window.Display();
}

static void _Close(object sender, EventArgs e)
{
    window.Close();
}

public partial class Program
{
    static RenderWindow window;
}