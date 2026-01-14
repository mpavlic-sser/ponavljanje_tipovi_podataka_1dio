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

Za svaku vrijednost treba odabrati najprikladniji tip i ispisati vrijednost:

broj učenika u razredu (npr. 28)
broj dana u mjesecu (npr. 31)
cijena kave 1.80 €
visina osobe 1.82
ASCII kod slova ‘A’ (65)
udaljenost do Mjeseca (384400 km)
je li korisnik prijavljen (true/false)

---

### 2) Chat bot za upis u školu

Napravi program koji pita korisnika:

ime (string)
prezime (string)
razred (byte)
smjer (string)
Ispiši poruku:

jednom koristeći string interpolaciju
drugi put koristeći String.Format()

---

### 3) RGB provjera

Korisnik unosi tri vrijednosti: R, G, B (0–255).
Spremi ih u byte.

Ispiši boju kao: RGB(255, 128, 64)

---

### 4) Temperatura učionice (float vs double)

Korisnik unosi temperaturu (npr. 21.5).

Spremi u float i ispiši: Temperatura (float): ...

Spremi u double i ispiši: Temperatura (double): ...

---

## 📌 Upute za predaju
- Rješenja trebaju biti commitana i pushana na GitHub.
- Ne mijenjati strukturu projekta.
