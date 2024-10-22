using NumberTranslator.Exceptions;
using System.Text;

namespace NumberTranslator;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private (string?, byte, byte) GetData()
    {
        if (!string.IsNullOrWhiteSpace(textBoxBefore.Text)
            && Byte.TryParse(comboBoxFrom.Text, out byte from)
            && Byte.TryParse(comboBoxTo.Text, out byte to))
        {
            return (textBoxBefore.Text, from, to);
        }
        return (null, 17, 17);
    }

    private void ButtonStart_Click(object sender, EventArgs e)
    {

        (string? Num, byte From, byte To) data = GetData();
        if (data.Num == null)
        {
            textBoxAfter.Text = "Некорректные данные";
            return;
        }
        try
        {
            string result = (data.From, data.To) switch
            {
                (var x, 2) => data.Num.ConvertToBinary(x),
                (var x, var y) => data.Num.ConvertMyNum(x, y)
            };
            textBoxAfter.Text = result;
        } 
        catch (InvalidSymbolException inv) 
        {
            textBoxAfter.Text = inv.Message;
        } 
        catch (IncorrectNumberSystem inv)
        {
            textBoxAfter.Text = inv.Message;
        }
    }
}
