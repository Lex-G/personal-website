using MudBlazor;
namespace Client.Services;

public class LayoutService
{
  public string MenuLabel { get; set; } = "home";
  public MudTheme CurrentTheme { get; private set; }
  public event EventHandler MajorUpdateOccurred;

  private void OnMajorUpdateOccurred() => MajorUpdateOccurred?.Invoke(this, EventArgs.Empty);
  public void SetBaseTheme(MudTheme theme)
  {
    CurrentTheme = theme;
    OnMajorUpdateOccurred();
  }
}