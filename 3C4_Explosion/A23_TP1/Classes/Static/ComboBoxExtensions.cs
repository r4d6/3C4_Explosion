using System;
using System.Windows.Controls;

namespace A23_TP1
{
    public static class ComboBoxExtensions
    {
        public static void AddEnumValues<T>(this ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (var item in Enum.GetValues(typeof(T)))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}