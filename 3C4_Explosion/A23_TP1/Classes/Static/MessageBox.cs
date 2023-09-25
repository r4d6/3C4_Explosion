using System.Windows;

namespace A23_TP1
{
    public static class MessageBox
    {
        public static void ShowMessageBoxError(string message)
        {
            System.Windows.MessageBox.Show(
                message,
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static void ShowMessageBoxInformation(string message)
        {
            System.Windows.MessageBox.Show(
                message,
                "Success",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
        public static MessageBoxResult ShowMessageBoxQuestion(string message)
        {
            return System.Windows.MessageBox.Show(
                message,
                "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
        }

        public static MessageBoxResult ShowMessageBoxStop(string message)
        {
            return System.Windows.MessageBox.Show(
                message,
                "WARNING",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Stop);
        }
    }
}