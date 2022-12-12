Id echipa: 7
Team leader: Rotaru Radu-Stefan
Senior coder: Guleama Dan Alexandru
Ceilalti membri: Visalon Giani, Tabacaru Andrei, Butelca Radu Andrei, Capmare Alex Mihai

How to play: Momentan avem implementata o tehnica rudimentara, flow-ul unui sut este: selectarea directiei, selectarea puterii si apasarea tastei `space`.

Obiective Sprint #3:

1 - Crearea unei scene pentru un sut din actiune – done:
	Am pus toate obiectele din scena intr-un spatiu cu valori pozitive pentru a scapa de bugul pe care il aveam la sut, in care deoarece pozitia mingii avea coordonate negative, mingea se ducea in directia opusa. Am modificat modul in care este aplicata forta asupra mingii, inainte adaugam directia la pozitia mingii, dupa care normalizam valorile si aplicam rezultatul inmultit cu puterea asupra mingii. Valorile normalizate erau mereu aceleasi si mingea se ducea mereu in aceeasi directie indiferent de ce input ii dadeam. Acum forta aplicata asupra mingii este produsul dintre directie si putere. Pentru valoarea y a directiei am adaugat 0.3f, deoarece suturile se duceau doar pe jos, directia alegand doar coordonatele x si z. Am creat un script nou pentru portar, pentru ca la penalty se arunca random, dar acum nu ar mai avea sens. In scena creata jucatorul suteaza din dreapta, ne-am gandit sa facem portarul sa se arunce doar in stanga, si sa se arunce doar atunci cand unghiul dintre directia mingii si directia perpendiculara pe portar de la pozitia mingii depaseste o anumita valoare.

2 - Crearea flow-ului unui meci, in care sa avem una sau doua faze de genul sut sau penalty - work in progress:
	Avem doua scene cu care putem crea flow-ul unui meci, nu am reusit sa terminam si sa vedem cum putem lega scenele din meci cu scenele care afiseaza text.

3 - Adaugarea unui collider mai bun pentru portar - done
	Am adaugat mai multe collidere pentru portar care sa ii acopere aproape tot corpul

4 - Adaugarea unui collider pentru poarta - done
	
5 - Adaugarea unui collider pentru stadion - done

6 - Crearea unui menu in care user-ul poate alege sa faca o actiune in afara terenului sau sa joace un meci - done
	Am adaugat meniul, dar butoanele inca nu duc catre alte scene 	pentru ca acestea nu sunt inca implementate

7 - Imbunatatirea textelor de Miss si Goal - done
	Am adaugat sunete atunci cand textul este afisat

8 - Afisarea unei tabele in timpul meciului - not started yet
	Inca nu am terminat task-ul #2, task-ul asta ar trebui facut dupa
	
