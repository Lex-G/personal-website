using MudBlazor;

namespace Client.Theme 
{
  public class LexTheme 
  {
      protected static string[] FontFamily = new[] { "Roboto", "Helvetica", "Arial", "sans-serif" };
        public static MudTheme MainTheme()
        {
            return new MudTheme()
            {
                Palette = new Palette()
                {
                    Black = "#000000",
                    White = "#FFFFFF",
                    Primary = "#A45C40",        // Light
                    Secondary = "#E4B7A0",      // Dark
                    Tertiary = "#C38370",       // Purple
                    Info = "#F6EEE0",           // Purple
                    Success = "#8EB767",        // Light Green
                    Warning = "#F2CA25",        // Yellow
                    Error = "#753837",          // Red
                    Dark = "#000000",
                    TextPrimary = "#FFFFFF",    // White
                    TextSecondary = "#000000",  // Black
                    //TextDisabled = "#000000",
                    ActionDefault = "#215273",  // Secondary
                    //ActionDisabled = "#B76867",
                    //ActionDisabledBackground = "#000000",
                    //Background = "#FFFFFF",
                    //BackgroundGrey = "#EBEBEB",
                    Surface = "#FFFFFF",
                    //DrawerBackground = "#FFFFFF",
                    //DrawerText = "#000000",
                    //DrawerIcon = "#212B97",
                    //AppbarBackground = "#00ff0080",
                    //AppbarText = "#FFFFFF",
                    //LinesDefault = "#000000",
                    //LinesInputs = "#000000",
                    //Divider = "#656667",
                    //DividerLight = "#A1A8AD",
                    HoverOpacity = 0.06d,
                    //GrayDefault = "#FFFFFF",
                    //GrayLight = "#FFFFFF",
                    //GrayLighter = "#FFFFFF",
                    //GrayDark = "#FFFFFF",
                    //GrayDarker = "#FFFFFF",
                },

                //TODO DarkMode
                //PaletteDark = new Palette()
                //{

                //},

                //Default for now
                Typography = new Typography()
                {
                    Default = new Default
                    {
                        FontFamily = FontFamily,
                        FontSize = ".875rem",
                        FontWeight = 400,
                        LineHeight = 1.43,
                        LetterSpacing = ".01071em",
                    },
                    H1 = new H1()
                    {
                        FontSize = "6rem",
                        FontWeight = 300,
                        LineHeight = 1.167,
                        LetterSpacing = "-.01562em",
                    },
                    H2 = new H2()
                    {
                        FontSize = "3.75rem",
                        FontWeight = 300,
                        LineHeight = 1.2,
                        LetterSpacing = "-.00833em",
                    },
                    H3 = new H3()
                    {
                        FontSize = "3rem",
                        FontWeight = 400,
                        LineHeight = 1.167,
                        LetterSpacing = "0",
                    },
                    H4 = new H4()
                    {
                        FontSize = "2.125rem",
                        FontWeight = 400,
                        LineHeight = 1.235,
                        LetterSpacing = ".00735em",
                    },
                    H5 = new H5()
                    {
                        FontSize = "1.5rem",
                        FontWeight = 400,
                        LineHeight = 1.334,
                        LetterSpacing = "0",
                    },
                    H6 = new H6()
                    {
                        FontSize = "1.25rem",
                        FontWeight = 500,
                        LineHeight = 1.6,
                        LetterSpacing = ".0075em",
                    },
                    Subtitle1 = new Subtitle1()
                    {
                        FontSize = "1rem",
                        FontWeight = 400,
                        LineHeight = 1.75,
                        LetterSpacing = ".00938em",
                    },
                    Subtitle2 = new Subtitle2()
                    {
                        FontSize = ".875rem",
                        FontWeight = 500,
                        LineHeight = 1.57,
                        LetterSpacing = ".00714em",
                    },
                    Button = new Button()
                    {
                        FontSize = ".875rem",
                        FontWeight = 500,
                        LineHeight = 1.75,
                        LetterSpacing = ".02857em",
                        TextTransform = "uppercase",
                    },
                    Overline = new Overline()
                    {
                        FontSize = ".75rem",
                        FontWeight = 400,
                        LineHeight = 2.66,
                        LetterSpacing = ".08333em",
                    },
                    Body1 = new Body1()
                    {
                        FontSize = "1rem",
                        FontWeight = 400,
                        LineHeight = 1.5,
                        LetterSpacing = ".00938em",
                    },
                    Body2 = new Body2()
                    {
                        FontSize = ".875rem",
                        FontWeight = 400,
                        LineHeight = 1.43,
                        LetterSpacing = ".01071em",
                    },

                    Caption = new Caption()
                    {
                        FontSize = ".75rem",
                        FontWeight = 400,
                        LineHeight = 1.66,
                        LetterSpacing = ".03333em",
                    },
                },

                LayoutProperties = new LayoutProperties()
                {
                    DefaultBorderRadius = "4px",
                    DrawerWidthLeft = "240px",
                    DrawerWidthRight = "240px",
                    DrawerMiniWidthLeft = "56px",
                    DrawerMiniWidthRight = "56px",
                    DrawerHeightTop = "320px",
                    DrawerHeightBottom = "320px",
                    AppbarHeight = "64px",
                },
            };
        }
  }
}