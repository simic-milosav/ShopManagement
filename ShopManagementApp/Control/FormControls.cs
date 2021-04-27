using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementApp
{
    internal sealed class FormControls
    {
        public static void ShowFields(bool value, params Control[] formElements)
        {
            foreach (Control element in formElements)
                element.Visible = value;
        }

        public static void ResetFields(params Control[] formElements)
        {
            foreach (Control element in formElements)
            {
                switch (element.GetType().Name)
                {
                    case "TextBox":
                        TextBox tBox = (TextBox)element;
                        tBox.Text = default;
                        break;
                    case "ComboBox":
                        ComboBox cBox = (ComboBox)element;
                        cBox.SelectedIndex = default;
                        break;
                    case "RadioButton":
                        RadioButton rButton = (RadioButton)element;
                        rButton.Checked = false;
                        break;
                    case "ListBox":
                        ListBox lBox = (ListBox)element;
                        lBox.DataSource = null;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void SetComboboxDefaultValue(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox cb in comboBoxes)
            {
                cb.Items.Insert(0, "--select--");
                cb.SelectedIndex = 0;
            }
        }

        public static void HideDGVColumns(params DataGridViewColumn[] columns)
        {
            foreach (DataGridViewColumn column in columns)
                column.Visible = false;
        }

        public static void ProvideError(CancelEventArgs e, Control formElement, ErrorProvider errorProvider)
        {
            switch (formElement.GetType().Name)
            {
                case "TextBox":
                    TextBox tBox = (TextBox)formElement;
                    if (string.IsNullOrEmpty(tBox.Text))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(tBox, "Field can't be empty!");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(tBox, null);
                    }
                    break;
                case "ComboBox":
                    ComboBox cBox = (ComboBox)formElement;
                    if (cBox.SelectedIndex == default)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(cBox, "Select one option!");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(cBox, null);
                    }
                    break;
                case "GroupBox":
                    GroupBox gBox = (GroupBox)formElement;
                    if (gBox.Controls.OfType<RadioButton>().All(r => r.Checked == false))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(gBox, "Select something from list!");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(gBox, null);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
