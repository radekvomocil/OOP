SELECT * FROM Studenti WHERE ID=1

SELECT * FROM Studenti LEFT JOIN Spojovacia ON 
Studenti.ID = Spojovacia.IdStudenta


SELECT Priezvisko, count(ID) as Pocet FROM Studenti group by Priezvisko  
order by Pocet DESC

SELECT SkratkaPredmet FROM Spojovacia group by 
SkratkaPredmet having count(IdStudenta)<3

SELECT NazovPredmetu, count(IdStudenta) as Pocet, avg(Hodnotenie) as PriemerneHodnotenie,
max(Hodnotenie) as Najhorsie, min(Hodnotenie) as Najlepsie FROM Hodnoceni group by
NazovPredmetu