# Problem Plecakowy (Knapsack Problem) - C# & .NET 8.0

Projekt zrealizowany w ramach laboratorium z przedmiotu Platformy Programistyczne .NET i Java.

## Opis Projektu
Aplikacja rozwiązuje decyzyjny problem plecakowy (0-1 Knapsack Problem) przy użyciu algorytmu zachłannego. Projekt został podzielony na trzy główne etapy:
1. **Aplikacja konsolowa:** Logika biznesowa, generowanie instancji problemu i implementacja algorytmu.
2. **Testy jednostkowe (MSTest):** Weryfikacja poprawności działania algorytmu oraz sprawdzenie przypadków brzegowych.
3. **Aplikacja okienkowa (Windows Forms):** Graficzny interfejs użytkownika (GUI) pozwalający na łatwą interakcję z programem.

## Struktura Logiczna (Najważniejsze klasy)

* **`Item` (Przedmiot):** Reprezentuje pojedynczy element. Przechowuje jego identyfikator (numer), wagę ($w_i$), wartość ($v_i$) oraz wyliczany w locie stosunek wartości do wagi, który jest kluczowy dla algorytmu zachłannego.
* **`Problem`:** Główna klasa zarządzająca instancją problemu. 
  * **Konstruktor `Problem(int n, int seed)`:** Generuje zadaną liczbę przedmiotów używając podanego ziarna (seed), losując ich parametry z przedziału <1, 10>.
  * **Metoda `Solve(int capacity)`:** Implementuje algorytm zachłanny. Sortuje przedmioty malejąco po ich opłacalności (stosunek wartości do wagi), a następnie umieszcza je w plecaku, aż do wyczerpania jego pojemności.
* **`Result` (Wynik):** Klasa przechowująca rozwiązanie. Zawiera listę identyfikatorów przedmiotów, które trafiły do plecaka, oraz ich sumaryczną wagę i wartość.

## Opis Działania
1. Użytkownik podaje liczbę przedmiotów, ziarno losowania (seed) oraz pojemność plecaka.
2. Program generuje listę przedmiotów o losowych wagach i wartościach (od 1 do 10).
3. Algorytm zachłanny analizuje przedmioty, sortując je od najbardziej opłacalnych.
4. Program zwraca listę numerów przedmiotów, które zmieściły się w plecaku, maksymalizując łączną wartość bez przekraczania podanej pojemności.
5. (GUI) Błędne dane wejściowe są walidowane, a użytkownik jest o nich informowany poprzez zmianę koloru tła odpowiednich pól.

## Technologie
* C# / .NET 8.0 (LTS)
* Windows Forms (GUI)
* MSTest (Testy jednostkowe)
