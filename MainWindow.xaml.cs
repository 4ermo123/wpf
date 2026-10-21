/*
 * Plik: MainWindow.xaml.cs
 * Opis: Klasa logiki dla głównego okna aplikacji. 
 * Obsługuje operacje matematyczne na liczniku oraz zdarzenia kliknięcia przycisków.
 */

using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        // Prywatne pole przechowujące aktualną wartość licznika
        private int currentCounter = 0;

        // Konstruktor głównego okna inicjujący komponenty XAML
        public MainWindow()
        {
            InitializeComponent();
        }

        // Obsługa kliknięcia: zmniejsza licznik o 1 i aktualizuje widok
        private void DecrementBtn_Click(object sender, RoutedEventArgs e)
        {
            currentCounter--;
            CounterBlock.Text = currentCounter.ToString();
        }

        // Obsługa kliknięcia: zwiększa licznik o 1 i aktualizuje widok
        private void IncrementBtn_Click(object sender, RoutedEventArgs e)
        {
            currentCounter++;
            CounterBlock.Text = currentCounter.ToString();
        }

        // Obsługa kliknięcia: zwiększa licznik o 2 i aktualizuje widok
        private void IncrementTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            currentCounter += 2;
            CounterBlock.Text = currentCounter.ToString();
        }

        // Obsługa kliknięcia: mnoży obecny licznik przez 2 i aktualizuje widok
        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            currentCounter *= 2;
            CounterBlock.Text = currentCounter.ToString();
        }

        // Obsługa kliknięcia: tworzy instancję drugiego okna i je wyświetla
        private void OpenWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow win = new SecondWindow();
            win.Show();
        }
    }
}