# 📘 C# – Osnove unosa, ispisa i tipova podataka (GitHub Classroom)

U ovom repozitoriju nalazi se **4 zadatka**.
Svaki zadatak je u svojoj `.cs` datoteci, a `Program.cs` služi samo za **pokretanje (orkestraciju)** zadataka.

---

## ✅ Kako pokrenuti

### Visual Studio 2022
1. Otvori `CSharpOsnove.sln`
2. Pokreni projekt `CSharpOsnove` (Start / F5)


---

## 📁 Struktura

```
src/CSharpOsnove/
├── Program.cs
├── Zadatak1_PogodiTip.cs
├── Zadatak2_ChatBot.cs
├── Zadatak3_RgbProvjera.cs
├── Zadatak4_Temperatura.cs

```

---

## 📝 Zadatci

### 1) Pogodi tip (tipovi podataka)
Za svaku vrijednost odaberi tip, spremi u varijablu i ispiši:
- broj učenika u razredu (28)
- broj dana u mjesecu (31)
- cijena kave (1.80 €)
- visina osobe (1.82)
- ASCII kod slova 'A' (65)
- udaljenost do Mjeseca (384400 km)
- je li korisnik prijavljen (true/false)

---

### 2) Chat bot za upis u školu
Unos:
- ime (`string`)
- prezime (`string`)
- razred (`byte`)
- smjer (`string`)

Ispis:
- jednom koristeći **string interpolaciju**
- drugi put koristeći **String.Format()**

---

### 3) RGB provjera
Unos:
- R, G, B (0–255)

Ako je ispravno: ispis `RGB(r, g, b)`  
Ako nije: ispis `Neispravan unos za RGB!`

---

### 4) Temperatura učionice (float vs double)
Unos temperature (npr. 21.5), spremi i ispiši kao:
- `float`
- `double`

---

## 📌 Upute za predaju
- Rješenja trebaju biti commitana i pushana na GitHub.
- Ne mijenjati strukturu projekta.
