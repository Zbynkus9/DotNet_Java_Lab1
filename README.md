# Problem Plecakowy (Knapsack Problem) - C# & .NET 8.0

Projekt zrealizowany w ramach laboratorium z przedmiotu Platformy Programistyczne .NET i Java.

## Opis Projektu
Aplikacja rozwiązuje decyzyjny problem plecakowy (0-1 Knapsack Problem) przy użyciu algorytmu zachłannego. Projekt został podzielony na trzy główne etapy:
1. **Aplikacja konsolowa:** Logika biznesowa, generowanie instancji problemu i implementacja algorytmu.
2. **Testy jednostkowe (MSTest):** Weryfikacja poprawności działania algorytmu oraz sprawdzenie przypadków brzegowych.
3. **Aplikacja okienkowa (Windows Forms):** Graficzny interfejs użytkownika (GUI) pozwalający na łatwą interakcję z programem.

## Struktura Projektu

<img width="328" height="304" alt="image" src="https://github.com/user-attachments/assets/b4b7ba53-66b0-4481-9c0b-062a23fe8dfd" />

## Struktura Logiczna (Najważniejsze klasy)

* **`Item` (Przedmiot):** Reprezentuje pojedynczy element. Przechowuje jego identyfikator (numer), wagę ($w_i$), wartość ($v_i$) oraz wyliczany w locie stosunek wartości do wagi, który jest kluczowy dla algorytmu zachłannego.
* **`Problem`:** Główna klasa zarządzająca instancją problemu. 
  * **Konstruktor `Problem(int n, int seed)`:** Generuje zadaną liczbę przedmiotów używając podanego ziarna (seed), losując ich parametry z przedziału <1, 10>.
  * **Metoda `Solve(int capacity)`:** Implementuje algorytm zachłanny. Sortuje przedmioty malejąco po ich opłacalności (stosunek wartości do wagi), a następnie umieszcza je w plecaku, aż do wyczerpania jego pojemności.
* **`Result` (Wynik):** Klasa przechowująca rozwiązanie. Zawiera listę identyfikatorów przedmiotów, które trafiły do plecaka, oraz ich sumaryczną wagę i wartość.

## Kluczowe fragmenty kodu

1. Zad 1 (Logika)

```cs
public Result solve(int capacity)
{
    Result result = new Result();

    var sortedItems = items.OrderByDescending(item => item.ratio).ToList();

    foreach (var item in sortedItems)
    {
        if (result.totalWeight + item.weight <= capacity)
        {
            result.itemsIds.Add(item.id);
            result.totalWeight += item.weight;
            result.totalValue += item.value;
        }
    }

    return result;
}
```

2. Zad 2 (Testy)

```cs
[TestMethod]
public void TestMethod4()
{
    int seed = 123;
    int n = 10;

    Problem problem1 = new Problem(n, seed);
    Problem problem2 = new Problem(n, seed);

    for (int i = 0; i < n; i++) 
    {
        Assert.AreEqual(problem1.items[i].value, problem2.items[i].value);
        Assert.AreEqual(problem1.items[i].weight, problem2.items[i].weight);
    }
}
```

3. Zad 3 (GUI)

```cs
private void runBTN_Click(object sender, EventArgs e)
{
    bool isValid = true;

    int n = 0;
    int seed = 0;
    int capacity = 0;

    // Num of itmes
    if (!int.TryParse(numOfItemsTxt.Text, out n) || n <= 0)
    {
        numOfItemsTxt.BackColor = Color.LightCoral;
        isValid = false;
    }
    else
    {
        numOfItemsTxt.BackColor = SystemColors.Window;
    }

    // Seed
    if (!int.TryParse(seedTxt.Text, out seed))
    {
        seedTxt.BackColor = Color.LightCoral;
        isValid = false;
    }
    else
    {
        seedTxt.BackColor = SystemColors.Window;
    }

    // Capacity
    if (!int.TryParse(capacityTxt.Text, out capacity) || capacity <= 0)
    {
        capacityTxt.BackColor = Color.LightCoral;
        isValid = false;
    }
    else
    {
        capacityTxt.BackColor = SystemColors.Window;
    }

    // Stop on invalid
    if (!isValid)
    {
        MessageBox.Show("Incorrect data. Insert correct data.",
                        "Validation error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        return;
    }

    // Main logic
    try
    { 
        Problem problem = new Problem(n, seed);

        itemsTxt.Text = problem.ToString();


        Result result = problem.solve(capacity);

        resultTxt.Text = result.ToString();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Unexpected error while running logic: {ex.Message}",
                        "Critical error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
    }
```

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
