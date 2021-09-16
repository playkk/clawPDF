using System.Windows.Controls;

namespace clawSoft.clawPDF.Shared.Helper
{
    public static class TextBoxHelper
    {
        public static void InsertText(TextBox textBox, string text)
        {
            if (text == null)
                return;

            // required to make the binding work (default update trigger is "LostFocus")
            // 使绑定工作所必需的（默认更新触发器为“LostFocus”）
            textBox.Focus();

            var newSelectionStart = textBox.SelectionStart + text.Length;
            textBox.Text = textBox.Text.Insert(textBox.SelectionStart, text);
            textBox.SelectionStart = newSelectionStart;
        }

        public static void SetText(TextBox textBox, string text)
        {
            textBox.Text = "";
            InsertText(textBox, text);
        }
    }
}