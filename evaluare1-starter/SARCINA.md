# Lecția de evaluare nr. 1 — sarcina practică

**Structura MVC, rutarea, controlerele și vederile** · 50 de minute · 10 puncte

Varianta ta este **numărul tău din registru**. Tot ce este specific variantei tale
(clasa, lista, numele controlerului, ruta, indicatorul) îl găsești:

- în tabelul din [`VARIANTE.md`](VARIANTE.md);
- în comentariul din capul fișierului `Evaluare1/Models/Variante/Vxx_....cs`, unde `xx` este numărul tău.

Mai jos, cuvintele între `«…»` se înlocuiesc cu valorile din rândul tău.
Exemplu pentru varianta 01: `«Controler»` = `Medicamente`, `«Clasa»` = `Medicament`,
`«Lista»` = `BazaMedicamente.Lista`.

**Ai voie** să consulți proiectele tale de la laboratoare și suporturile teoretice.
**Nu ai voie** să comunici cu colegii și să folosești asistenți AI.
Fișierul cu datele variantei tale **nu se modifică**.

| Etapa | Ce faci | Min. |
|---|---|---|
| Pregătirea | repozitoriul din șablon, clonarea, ramura `evaluare-1` | 6 |
| Sarcina 1 | controlerul și pagina cu lista | 12 |
| Sarcina 2 | pagina unei înregistrări și `NotFound()` | 10 |
| Sarcina 3 | ruta ta și filtrarea | 10 |
| Sarcina 4 | linkul din meniu și secțiunea `Rezumat` | 8 |
| Predarea | Push și Pull Request | 4 |

---

## Pregătirea · 6 minute

1. Pe `github.com/AAW2341/evaluare1-starter`: **Use this template → Create a new repository**.
   Owner `AAW2341`, numele `evaluare1-<nume-prenume>` (ex.: `evaluare1-ion-popescu`), **Private**.
2. Visual Studio: **Git → Clone Repository**, adresa repozitoriului tău, folderul `C:\Lucru\evaluare1-<nume-prenume>`.
   **Nu crea proiect nou și nu publica nimic**: proiectul este deja în repozitoriu.
3. Clic pe `main` în dreapta-jos → **New Branch…** → `evaluare-1`, bifat **Checkout branch** → **Create**.
4. **F5**. Se deschide pagina „Lecția de evaluare nr. 1”.
5. Deschide în Solution Explorer fișierul variantei tale din `Models/Variante`. Citește comentariul din capul lui.

---

## Sarcina 1 · Controlerul și pagina cu lista · 12 minute · 3 puncte

1. Creează controlerul `«Controler»Controller` în folderul `Controllers`.
2. Acțiunea `Index`:
   - pune în `ViewBag.Titlu` titlul variantei tale (coloana „titlul” din `VARIANTE.md`);
   - trimite vederii lista `«Lista»`.
3. Creează vederea `Index` a controlerului, în folderul cerut de convenții.
   - modelul vederii: `List<«Clasa»>`;
   - în `<h1>`: `ViewBag.Titlu`;
   - un tabel cu toate înregistrările, câte un rând pentru fiecare, generat cu `foreach`;
   - patru coloane, cu antet: toate câmpurile în afară de `Id`; după valoarea numerică scrii unitatea de măsură.

**Ce trebuie să vezi:** `/«Controler»` → titlul și un tabel cu **7 rânduri**.

**Commit:** `Sarcina 1`

---

## Sarcina 2 · Pagina unei înregistrări · 10 minute · 2 puncte

1. Acțiunea `Detalii(int id)` caută în `«Lista»` înregistrarea cu acest `Id`, folosind `foreach` și `if`.
   - dacă o găsește, o trimite vederii `Detalii`;
   - dacă nu o găsește, întoarce `NotFound()`.
2. Vederea `Detalii` (modelul: `«Clasa»`): primul câmp în `<h1>`, celelalte trei câmpuri sub el
   și un link „Înapoi la listă”, generat cu `asp-action`.
3. În tabelul din Sarcina 1, valoarea din prima coloană devine link către `Detalii`,
   generat cu `asp-action` și `asp-route-id`.

**Ce trebuie să vezi:**
- adresa „Detalii” din rândul tău → pagina înregistrării cu acel `Id`;
- `/«Controler»/Detalii/99` → eroarea **404**;
- clic pe orice rând din listă → pagina lui; „Înapoi la listă” → lista.

**Commit:** `Sarcina 2`

---

## Sarcina 3 · Ruta ta și filtrarea · 10 minute · 2 puncte

1. În `Program.cs`, în locul marcat cu comentariul `// Sarcina 3`, **înaintea rutei implicite**,
   adaugă o rută convențională:
   - șablonul: coloana „Ruta” din rândul tău (ex. V01: `medicamente/forma/{forma}`);
   - valorile implicite: controlerul tău și acțiunea cu numele câmpului de filtrare (ex. V01: `Forma`);
   - un nume propriu al rutei.
2. Acțiunea de filtrare primește un parametru `string` cu **același nume ca segmentul** dintre acolade.
   - construiește o listă nouă, `List<«Clasa»>`, cu înregistrările la care câmpul de filtrare are valoarea primită;
     **literele mari și mici nu contează** (`sirop`, `Sirop` și `SIROP` dau același rezultat);
   - `ViewBag.Titlu` = titlul variantei + `": "` + valoarea primită;
   - **refolosește** vederea `Index` din Sarcina 1: nu creezi o vedere nouă.

**Ce trebuie să vezi:** adresa de test din rândul tău → titlul cu valoarea din adresă și doar înregistrările din acel grup.
Aceeași adresă, scrisă cu litere mari, dă același rezultat.

**Commit:** `Sarcina 3`

---

## Sarcina 4 · Meniul și secțiunea Rezumat · 8 minute · 2 puncte

1. În `Views/Shared/_Layout.cshtml`, în meniu, la comentariul `Sarcina 4`:
   un link către lista ta, generat cu `asp-controller` și `asp-action`. Textul linkului: titlul variantei.
2. În același fișier, în `<aside class="rezumat">`, afișează secțiunea `Rezumat`. Secțiunea este **opțională**:
   paginile care nu o definesc trebuie să meargă în continuare.
3. În vederea `Index` definește secțiunea `Rezumat`, cu două paragrafe:
   - `Înregistrări: N` — câte înregistrări sunt în lista primită de vedere;
   - `«Indicator»: X «unitate»` — indicatorul din rândul tău, calculat cu `foreach` din **lista primită de vedere**.

**Ce trebuie să vezi:**
- pe `/«Controler»`: în dreapta, `Înregistrări: 7` și indicatorul calculat pe toată lista;
- pe adresa de test din Sarcina 3: alt număr de înregistrări și indicatorul calculat doar pe ele;
- pe `/` și pe o pagină `Detalii`: nicio eroare, partea din dreapta goală;
- linkul din meniu duce la lista ta de pe orice pagină.

**Commit:** `Sarcina 4`

---

## Predarea · 4 minute

1. **Git Changes → Push**. Pe ramura `evaluare-1` trebuie să fie commit-urile `Sarcina 1` … `Sarcina 4`
   (cele pe care le-ai făcut).
2. Pe pagina repozitoriului: **Compare & pull request** (din `evaluare-1` în `main`).
   Titlul: `Evaluare 1 — V«nr» — Nume Prenume` (ex.: `Evaluare 1 — V07 — Ion Popescu`). **Create pull request**.
3. **Nu apăsa Merge.**

Ce nu ai terminat, predai așa cum este: o sarcină făcută pe jumătate primește punctaj parțial.

---

## Dacă ai terminat înainte de timp

Se notează separat și nu intră în cele 10 puncte. Commit: `Extra 1`, `Extra 2`…

- **E1.** Sub titlul paginii `Index`: câte un link pentru fiecare dintre cele trei valori ale câmpului de filtrare,
  generat cu `asp-action` și `asp-route-…`. Deschide **Ctrl+U**: adresele trebuie să aibă forma rutei tale
  (ex. `/medicamente/forma/Sirop`), nu `?forma=Sirop`.
- **E2.** Pentru un `id` inexistent, `Detalii` nu mai dă 404: redirecționează la `Index` și afișează acolo,
  o singură dată, mesajul „Nu există înregistrarea cu id-ul 99.” (`TempData`).
- **E3.** Mută rândul tabelului din `Index` într-o vedere parțială tipizată `_Rand«Clasa».cshtml`.

---

## Baremul

| Sarcina | Ce se verifică | Puncte |
|---|---|---|
| Pregătirea și predarea | repozitoriul corect (Owner, nume, Private), ramura `evaluare-1`, commit după fiecare sarcină, Pull Request deschis, fără Merge | 1 |
| Sarcina 1 | controlerul și acțiunea `Index` după convenții; vederea în folderul corect, cu modelul tipizat; tabelul cu 7 rânduri și 4 coloane, generat cu `foreach` | 3 |
| Sarcina 2 | căutarea cu `foreach`/`if` și `View(...)`; `NotFound()` pentru id inexistent; linkurile generate cu tag helpers | 2 |
| Sarcina 3 | ruta înaintea celei implicite, adresa de test merge; filtrarea fără a ține cont de litere mari/mici, `ViewBag.Titlu`, refolosirea vederii `Index` | 2 |
| Sarcina 4 | linkul din meniu; `RenderSection` opțional; secțiunea `Rezumat` cu valorile corecte, calculate din `Model` | 2 |
| **Total** | | **10** |
