# WPF Counter & Window Navigation App

## O projekcie

**WPF Counter & Window Navigation App** to intuicyjna aplikacja desktopowa stworzona w ekosystemie .NET przy użyciu technologii **WPF (Windows Presentation Foundation)** oraz języka programowania **C#**. Głównym celem tego projektu jest zaprezentowanie fundamentów tworzenia interfejsów graficznych dla systemów Windows, obsługi zdarzeń użytkownika oraz zarządzania cyklem życia i nawigacją pomiędzy wieloma oknami w architekturze MVVM/code-behind.

Projekt ten doskonale sprawdza się jako punkt wyjścia dla osób uczących się programowania obiektowego oraz projektowania responsywnych interfejsów użytkownika w środowisku Visual Studio.

---

## O co w tym chodzi? (Jak to działa)

Aplikacja opiera się na interaktywnym panelu sterowania osadzonym w głównym oknie programu (`MainWindow`). Użytkownik ma do dyspozycji zestaw przycisków, z których każdy odpowiada za określoną operację matematyczną modyfikującą stan globalny zmiennej licznika. Wynik tych operacji jest na bieżąco prezentowany w centralnej części ekranu za pomocą elementu tekstowego (`TextBlock`).

Dodatkowo, projekt demonstruje mechanizm tworzenia i wywoływania dodatkowych okien (`SecondWindow`). Kliknięcie odpowiedniego przycisku inicjalizuje nową instancję klasy drugiego okna i wyświetla je niezależnie od okna głównego, co pozwala zrozumieć podstawy wielooknowości w aplikacjach okienkowych.

---

## Główne funkcjonalności

* **Interaktywny licznik:** Dynamiczna zmiana wartości liczbowych w czasie rzeczywistym.
* **Operacje arytmetyczne:**
  * *Odejmij 1* – dekrementacja wartości o jeden.
  * *Dodaj 1* – inkrementacja wartości o jeden.
  * *Dodaj 2* – zwiększenie wartości o dwa.
  * *Pomnóż przez 2* – skalowanie obecnego wyniku przez czynnik dwa.
* **Nawigacja okienkowa:** Przycisk wyzwalający otwarcie dodatkowego, pomocniczego okna aplikacji.

---

## Struktura plików projektu

W repozytorium znajdują się cztery główne pliki źródłowe odpowiedzialne za interfejs oraz logikę:

1. **`MainWindow.xaml`** – Deklaratywny opis interfejsu głównego okna aplikacji (układ kontrolek, przyciski, etykiety).
2. **`MainWindow.xaml.cs`** – Plik logiki w języku C# obsługujący zdarzenia kliknięcia oraz operacje na zmiennej licznika.
3. **`SecondWindow.xaml`** – Szablon graficzny drugiego, dodatkowego okna aplikacji.
4. **`SecondWindow.xaml.cs`** – Klasa inicjalizująca działanie drugiego okna.

---

## Wymagania wstępne

Aby poprawnie uruchomić i edytować projekt, potrzebujesz:
* Systemu operacyjnego **Windows**.
* Środowiska **Visual Studio** z zainstalowanym obciążeniem *Tworzenie aplikacji klasycznych dla platformy .NET* (.NET Desktop Development).
* Platformy **.NET** (wersja 8.0 lub nowsza).

---

## Instrukcja uruchomienia

1. Pobierz lub sklonuj repozytorium na swój lokalny dysk.
2. Utwórz nowy projekt typu **Aplikacja WPF** w programie Visual Studio.
3. Podmień zawartość domyślnych plików projektu na dostarczony kod źródłowy dla okna głównego oraz dodaj drugie okno (`SecondWindow`).
4. Zbuduj rozwiązanie i naciśnij klawisz **F5** (lub kliknij przycisk **Start**), aby uruchomić aplikację.