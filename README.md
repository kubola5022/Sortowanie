#  Sortowanie — porównanie algorytmów sortowania

Aplikacja desktopowa napisana w **C#**, umożliwiająca generowanie ciągów liczb, sortowanie ich za pomocą różnych algorytmów oraz porównywanie czasu ich wykonania.

Projekt został stworzony w celach edukacyjnych, aby lepiej zrozumieć działanie podstawowych algorytmów sortowania, ich implementację oraz różnice w wydajności.

---

##  Funkcjonalności

Aplikacja umożliwia:

* wybór algorytmu sortowania,
* określenie długości generowanego ciągu,
* określenie zakresu wartości liczbowych,
* generowanie danych:

  *  losowych,
  *  rosnących,
  *  malejących,
* sortowanie wygenerowanego ciągu,
* pomiar czasu wykonania algorytmu,
* prezentację posortowanych danych na wykresie,
* wyświetlanie wyników pomiarów w tabeli,
* porównywanie działania różnych algorytmów.

---

#  Zaimplementowane algorytmy

W projekcie zaimplementowano pięć algorytmów sortowania:

| Algorytm                    | Klasa        | Typ         |
| --------------------------- | ------------ | ----------- |
| Sortowanie bąbelkowe        | `Babelkowe`  | elementarne |
| Sortowanie przez wstawianie | `Wstawianie` | elementarne |
| Sortowanie przez wybór      | `Wybor`      | elementarne |
| Sortowanie szybkie          | `Szybkie`    | złożone     |
| Sortowanie przez scalanie   | `Scalanie`   | złożone     |

Algorytmy zostały zaimplementowane samodzielnie w języku C#.

---

##  Porównywanie wydajności

Jednym z głównych celów aplikacji jest możliwość porównania czasu działania poszczególnych algorytmów.

Pomiar wykonywany jest przy użyciu klasy:

```csharp
System.Diagnostics.Stopwatch
```

Przykładowy przebieg:

```text
Generowanie danych
        ↓
Wybór algorytmu
        ↓
Uruchomienie sortowania
        ↓
Pomiar czasu
        ↓
Prezentacja wyniku
```

Wyniki są prezentowane w tabeli zawierającej m.in.:

* zastosowany algorytm,
* liczbę elementów,
* czas wykonania.

---

#  Wizualizacja danych

Aplikacja wykorzystuje komponent:

```text
System.Windows.Forms.DataVisualization.Charting
```

do przedstawiania wygenerowanych i posortowanych danych na wykresie.

Dzięki temu można wizualnie obserwować rozkład elementów przed oraz po wykonaniu sortowania.

---

#  Interfejs aplikacji

Aplikacja została wykonana przy użyciu **Windows Forms**.

Użytkownik może skonfigurować parametry eksperymentu, wybrać algorytmy oraz rodzaj generowanych danych, a następnie uruchomić sortowanie i sprawdzić uzyskane wyniki.

>  Warto dodać tutaj screenshot aplikacji z folderu `docs/images`, jeśli w przyszłości zostanie utworzony.

---

#  Struktura projektu

```text
Sortowanie
│
├── Aplikacja
│   │
│   ├── Program.cs
│   ├── Okno.cs
│   ├── Okno.Designer.cs
│   │
│   ├── Sortowanie.cs
│   ├── Sortowanie_zlozone.cs
│   │
│   ├── Babelkowe.cs
│   ├── Wstawianie.cs
│   ├── Wybor.cs
│   ├── Szybkie.cs
│   └── Scalanie.cs
│
└── README.md
```

### Klasy bazowe

`Sortowanie_elementarne`

Zawiera wspólną funkcjonalność dla prostszych algorytmów sortowania oraz generowania danych.

`Sortowanie_zlozone`

Klasa bazowa wykorzystywana przez algorytmy wymagające dodatkowych parametrów podczas sortowania, takie jak Quick Sort i Merge Sort.

### Implementacje algorytmów

```text
Sortowanie_elementarne
├── Babelkowe
├── Wstawianie
└── Wybor

Sortowanie_zlozone
├── Szybkie
└── Scalanie
```

Takie podejście pozwala współdzielić część kodu odpowiedzialnego za generowanie danych i prezentację wyników.

---

#  Technologie

* **C#**
* **.NET Framework 4.7.2**
* **Windows Forms**
* **System.Windows.Forms.DataVisualization**
* **Visual Studio**

---

# Uruchomienie

### Wymagania

Do uruchomienia projektu potrzebne są:

* Windows,
* Visual Studio,
* .NET Framework 4.7.2 lub środowisko zgodne z projektem.

### Uruchomienie z Visual Studio

1. Sklonuj repozytorium:

```bash
git clone https://github.com/kubola5022/Sortowanie.git
```

2. Otwórz projekt:

```text
Aplikacja/Aplikacja.csproj
```

3. Wybierz konfigurację `Debug` lub `Release`.

4. Uruchom aplikację za pomocą:

```text
F5
```

lub:

```text
Ctrl + F5
```

---

#  Przykładowy eksperyment

Przykładowe porównanie może wyglądać następująco:

```text
Liczba elementów: 10 000
Zakres wartości: 0 – 100 000

Dane: losowe

                Czas wykonania
---------------------------------
Bąbelkowe        ...
Wstawianie       ...
Wybór            ...
Szybkie          ...
Scalanie         ...
```

Dokładne czasy zależą od sprzętu, rozmiaru danych oraz aktualnego obciążenia systemu.

---

#  Złożoność algorytmów

Orientacyjne złożoności czasowe zaimplementowanych algorytmów:

| Algorytm   | Najlepszy przypadek | Średni przypadek | Najgorszy przypadek |
| ---------- | ------------------: | ---------------: | ------------------: |
| Bąbelkowe  |               O(n²) |            O(n²) |               O(n²) |
| Wstawianie |                O(n) |            O(n²) |               O(n²) |
| Wybór      |               O(n²) |            O(n²) |               O(n²) |
| Szybkie    |          O(n log n) |       O(n log n) |               O(n²) |
| Scalanie   |          O(n log n) |       O(n log n) |          O(n log n) |

> W przypadku sortowania szybkiego rzeczywista wydajność zależy m.in. od sposobu wyboru pivota.

---

#  Cel projektu

Projekt miał na celu praktyczne poznanie:

* podstawowych algorytmów sortowania,
* rekurencji,
* operacji na tablicach,
* dziedziczenia i klas abstrakcyjnych,
* programowania obiektowego w C#,
* obsługi interfejsu Windows Forms,
* wizualizacji danych,
* pomiaru czasu wykonywania operacji,
* porównywania wydajności różnych rozwiązań algorytmicznych.

---

# Autor

**Jakub Kacprzycki**

GitHub:
https://github.com/kubola5022

---

##  Status projektu

Projekt edukacyjny.

Aplikacja została przygotowana jako praktyczne ćwiczenie z programowania w C# oraz implementacji i porównywania algorytmów sortowania.
