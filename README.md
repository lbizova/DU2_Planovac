Zadání:

Cíl
Vytvořte konzolovou aplikaci, která umožní uživateli:

    Přidávat události: Uživatel zadá název události a datum.
    Vypisovat události: Aplikace pro každou událost zobrazí, kolik dní zbývá do daného dne.
    Zobrazovat statistiku: Aplikace vypíše všechna data událostí a počet událostí, které se konají v daný den.

Zadání
Zadávání vstupu
Uživatel bude opakovaně zadávat text. Vstup může být jeden z následujících:

    Text ve formátu EVENT;[event name];[event date], kde [event name] je jméno události a [event date] je datum ve formátu YYYY-MM-DD, např. EVENT;Lekce Czechitas;2025-05-15.
    Text LIST, který bude znamenat výpis událostí.
    Text STATS, který bude znamenat výpis statistik.
    Text END, který ukončí program.

Akce EVENT
Vytvořte třídu Event, která bude uchovávat informace o události (jméno a datum). Použijte funkci string.Split pro získání jména akce a jednotlivých částí data: rok, měsíc a den (funkci string.Split můžete použít i vícekrát – jednou pro získání jména a celého data a znovu pro parsování data). Části data použijte k vytvoření objektu DateTime. Pomocí získaných údajů vytvořte objekt typu Event a uložte ho do připraveného seznamu (List).

Akce LIST
Vypište všechny uložené akce. Pro každou akci vypište její jméno, datum a počet dní do konání akce (pozor na akce, které již proběhly).
Příklad: Pro vstup

EVENT;Lekce Czechitas;2025-05-15
EVENT;Oslava;2025-05-10
EVENT;Odevzdat úlohu;2025-04-20
LIST

vypíšeme

Event Lekce Czechitas with date 2025-05-15 will happen in 15 days
Event Oslava with date 2025-05-10 will happen in 10 days
Event Odevzdat úlohu with date 2025-04-20 happened 10 days ago

Akce STATS
Vytvořte slovník (Dictionary<DateTime, int>), do kterého si uložíte data všech uložených akcí a ke každému datu počet událostí, které se konají v daný den.
Příklad: Pro vstup

EVENT;Lekce Czechitas;2025-05-15
EVENT;Oslava;2025-05-10
EVENT;Odevzdat úlohu;2025-04-20
EVENT;Vyšetření;2025-05-10
STATS

vypíšeme

Date: 2025-05-15: events: 1
Date: 2025-05-10: events: 2
Date: 2025-04-20: events: 1

Shrnutí:
    Program by měl obsahovat: samostatnou třídu Event, hlavní while smyčku, parsování vstupu, switch nebo if/else větve pro rozhodování o akci, List s uloženými akcemi a Dictionary pro práci se statistikami.
    Reagujte na špatně formátovaný vstup. Program nesmí skončit vyhozenou výjimkou.
