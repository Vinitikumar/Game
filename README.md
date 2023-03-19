# HAM Game („Snake Game")

# Motivation
Bei meiner Wahl der Entscheidung, welches Spiel ich nachbauen wollte, half mir der Rückblick, wie ich damals an einem alten NOKIA Handy, dieses "Snake Game" gespielt habe. Welches durch viele verschiedene Iterationen im Laufe der Jahre ging, aber das Spiel ist immer noch eine Menge Spaß. Somit erstellte ich das "Snake Game" in Visual Studio mit der Windows Form Applikation Vorlage. Und kam, mit einer Freundin, auf den Namen "HAM" für das "Snake Game". "HAM" ist Englisch für das deutsche Wort Schinken, worauf ich mit meinen Klassenkameraden auf die Idee kam, anstatt einem roten Punkt, was die Schlange auffrisst, das Schinken zu nehmen. Dies ist wiederum ein Zusatz in dem Spiel ist. Ebenfalls habe ich mich für eine Multiplayer-Modus entschieden zu programmieren, was der klassische "Snake Game" nicht hatte.

# Projektstrukturplan
Das Projekt besteht aus zwei "Windows Forms", einer "TabControl" und aus vielen Klassen, die dynamisch importiert oder aus dem Spiel entfernt werden können. Die objektorientierte Programmierung (OOP) erleichtert die Unterteilung durch die Klassen, sodass nicht alles in einer Datei codiert werden müsste. Die zwei "Windows Forms" sind "MainGameForm" und "HelpForm". Der "MainGameForm" enthält auch den "TabControl", der wiederum 3 Tabs beinhaltet. Der erste Tab ist die Startseite ("StartPage") mit dem "Start-Button", welches nach dem Klick auf das zweite Tab führt. Der zweite Tab ist die Spieler Auswahlseite ("PlayerChoicesPage"). Auf der Seite sind drei weitere Buttons zu sichten, mit dem du den Einzelspieler ("Singleplayer") oder den Multispieler ("Multiplayer") auswählen kannst, die dann zu dem dritten Tab führen. Der dritte Tab ist die Spielseite ("SPAndMPGame"), die sich durch den Spielermodus variiert. Ebenfalls ist es möglich das Spiel mit der "Enter-Key" erneut zu starten und mit der "esc-Key" von der Spielseite zur Auswahlseite zu wechseln. Der dritte Button, mit dem Namen "Help", welches dann eine erneute Form („HelpForm“) öffnet. Dieser Form beinhaltet die Anleitung zu dem Spiel, die vor dem Spiel gelesen werden sollte.

Ziel des Spieles:
Der Spieler1 oder Spieler2 führt die Schlange zum Futter "food". Dazu verwenden die Spieler die Pfeiltasten "Arrow keys" oder "WASD keys" auf der Tastatur. Wird der Happen berührt so verschwindet er, die Schlangen werden um ein Körperteil länger und irgendwo auf dem Spielplan erscheINT ein neuer Futterhappen. Derjenige der einen höheren "Score" als der andere hat, ist der Gewinner. Wenn beispielsweise ein Spieler gegen die Wand sich bewegt oder den anderen Spieler am Körper stößt, beendet sich die Spielrunde.

![image](https://user-images.githubusercontent.com/94457045/226169784-6b076125-f821-4929-8a94-ce352bcff948.png)

Hinweis:
	- Der Programmcode beinhaltet Kommentare für ein besseres Verständnis der Logik des Spieles
	- "Ham" anstatt roten Punkt ist im Code auskommentiert

![image](https://user-images.githubusercontent.com/94457045/226036395-4e8fd28f-a99f-48c4-b328-32b51fbac66d.png)
![image](https://user-images.githubusercontent.com/94457045/226037062-adf2e4c4-957d-4a05-9d2a-50f9d06313c2.png)
![image](https://user-images.githubusercontent.com/94457045/226039202-fe8a547b-ec7c-4f16-91e3-9abccac5e4de.png)
![image](https://user-images.githubusercontent.com/94457045/226039362-4910d264-b5af-4c36-97e5-43769fdefc32.png)
![image](https://user-images.githubusercontent.com/94457045/226040950-ae5c04e0-b715-406e-8e22-a664f6c2b8a2.png)
![image](https://user-images.githubusercontent.com/94457045/226041050-db943f57-2459-4ca3-9ef6-bbf89402aed3.png)

# Anstatt 2 Struktogramme von Methoden 
!2 UML-Diagramme von 2 verschiedenen Klassen

![image](https://user-images.githubusercontent.com/94457045/226171316-07294758-f3c3-441e-b2b8-7856a6c1efd2.png)
![image](https://user-images.githubusercontent.com/94457045/226171624-23b781fa-56bb-4e75-863b-5d8def5f1b9f.png)

# Beschreibung der Funktionalität

Klassen (.cs):
-> Program.cs       
Die Program-Klasse ist der Haupteinstiegspunkt für die Anwendung und startet mit der "main()-Methode" das Programm bzw. Applikation/ Anwendung.

-> Circle.cs        
Die "Circle"-Klasse wird verwendet, um den Kopf und Körper der Schlangen zu berechnen und die X- und Y-Position des Schlangenobjekts zu geben. Dafür wird eine INT-Instanz namens X und einen für Y erstellt. Die "Circle()-Methode" setzt dann X und Y auf 0 zurück.

-> Input.cs         
Die "Input"-Klasse wird mit der Benutzereingabe verknüpft, zum Beispiel mit oben, unten, links oder rechts. Eine neue Instanz der "Hashtable"-Klasse wurde erstellt, um darin die eingefügten "keys" zu verwenden. Die "KeyPress()-Methode" enthält die Funktion, die einen "key" der Klasse zurückgibt. Demnach durchläuft eine If-Anweisung, wenn der "Hashtable" leer ist, der den Booleanwert "false" und wenn nicht "true" zurückgibt. Eine weitere verwendete Methode in der "Input-Klasse" ist die "changeState()-Methode", die die Funktion hat, den Zustand der "keys" und den Spielern zu ändern.
        
-> Settings.cs      
Die "Settings-Klasse" wird verwendet, um die Höhe, Breite, Geschwindigkeit und andere Standard- "Settings" für das Spiel zu überprüfen. Ebenfalls wird hier ein Enum-Klasse namens "Directions" erstellt, die auch all die Richtungen wie links, rechts, oben und unten enthält. Die Klasse Settings setzt Instanzen wie "Width", "Height", "Speed", "GameOver" "Player1Score", "Player2Score" und "Points". Ebenfalls werden zwei Enum-Instanzen wie "directionGreenSnake" und "directionBlueSnake" gesetzt. Die Default-Einstellungsfunktion der Settings-Klasse ist die "Settings()-Methode", in der die Variablen für die Standard-"Settings" mit dem Wert deklariert wurden.

-> MainGameForm.cs      
Diese Form-Klasse beinhaltet die ganze Spiellogik. Die "MainGameForm" (Windows Form) erstellte die "MainGameForm"-Klasse. In der wird zuerst zwei Listen-Arrays für die zwei Schlangen („BlueSnake“ und „GreenSnake“) erstellt. Ebenfalls eine einzelne "Circle-Klasse" namens "food", eine variable "CurrentKeyPressedMainGamePage" mit dem Datentyp INT, zwei boolean Variablen "startedMP" und "startedSP" mit dem Wert "false", erstellt. 
Die "MainGameForm"()-Methode ist die Hauptmethode und verknüpft die "Settings"-Klasse mit der Form. Die Methode ändert die Spielzeit passend zu der "Settings speed" und verknüpft die "updateScreenSPMP()"- und "updateScreenSP()"-Methoden mit dem "GameTimer". In der "MainGameForm()"-Methode wird der "GameTimer" gestartet und die "startGame()"-Methode ausgeführt. 
Dann kommen die "Button-Methoden" ("Start-", "Singleplayer-", "Multiplayer-" und "Help-Button"). Alle Buttons führen von einem Tab zu anderem Tab, außer die "Help-Button", sie führt zu der "HelpForm" (Windows Form). 
Die "updateScreenSPMP-" und "updateScreenSP"-Methoden, werden mit dem "GameTimer-Objekt" verknüpft. Die Funktion der beiden Methoden ist, falls zuerst überprüft wird, ob das Spiel vorbei ist, wird der Spieler1 oder Spieler2, die Eingabetaste drücken, um das Spiel neu zu starten. Wenn das Spiel jedoch noch nicht vorbei ist, wird zuerst der Eingang der Spieler1 oder Spieler2 nach oben, unten, links und rechts überprüft. Später wird die definierte "movePlayer()"-Methode ausgeführt und dann die Funktion "pbCanvas.inalidate" (die "pictureBox") aufgerufen. Diese Funktion ermöglicht es, den "pictureBox" in Millisekunden zu aktualisieren, sodass es aussieht, als ob sich die Schlange im Spielbereich bewegt. Wenn diese Funktion nicht verwendet wird, dann hinterlässt die Schlange eine Spur von Punkten, wo sie sich bewegt. Auf diese Weise werden alle nicht verwendeten "graphics" durch die Bewegungen der Schlange entfernt.
Die Methode "updateGraphics()", dass aus dem Ereignis "updateGraphics", der durch Option "Paint" für den "PictureBox" hinzugefügt wurde. Dieser dient dazu, alle Grafiken hier zu zeichnen und ebenfalls aus dem "pictureBox" zu entfernen. Deshalb wird die Funktion "pbCanvas.Invalidate()" im "GameTimer"-Ereignis verwendet. 
Auf dieser Weise wird der Eindruck erweckt, dass der Spieler die Schlange im Spiel fließend bewegt. In der Methode werden zugleich die Farben für Kopf, Körper und Futter eingestellt und festgelegt. Ebenfalls wird überprüft, was passieren könnte, wenn das Spiel vorbei ist. Wenn das Spiel zu Ende ist, wird auf dem Bildschirm die erforderlichen Informationen angezeigt. 
Die Methode "startGame()" wird ausgeführt, wenn das Spiel tatsächlich startet. Dafür wurde der Standardwert für das Spiel gesetzt, wie das Einrichten des Schlangenkopfes und das Hinzufügen zu dem Array.  Zugleich wird die Sichtbarkeit der "ScoreCounts" und "ScoreLabels" zu den jeweiligen schlangen ("BlueSnake" oder "GreenSnake") gesetzt.
Die Methode "generateFood()" erzeugt das "food icon" an einer zufälligen Stelle im Spielbereich. 
Wenn die Schlange mit dem Futter kollidiert, wird die "eat()"-Methode ausgelöst. Zugleich wird auch ein anderer Sektor zum Körper der Schlange und der Schlangen-Array hinzugefügt. 
Die "die()"-Methode betätigt, was ihr Name besagt, sie wird das Spiel beenden, wenn sie ausgeführt wird. Normalerweise, wenn die Schlange entweder die Grenzen trifft oder mit den Körperteilen der Schlange kollidiert, wird das Spiel beendet. 
Mit der "tabController_KeyDown()"-Methode werden die Tabs entsprechend im Game gewechselt, wie zum Beispiel in Einzelspielermodus oder Mehrspielermodus. Ebenfalls aktiviert diese Methode die Keys nur auf dem Tab, wo das Spiel mit den unterschiedlichen Spielermodus sich befindet. Im Ganzem werden die Methoden "MainGameForm()", "startButton_Click_1()", "singlePlayerButton_Click()", "multiplayerButton_Click()", "helpButton_Click()", "updateGraphics()", "startGame()", "movePlayer1()", "movePlayer2()", "generateFood()", "eat()", "eat2()", "die()", "updateScreenSPMP()", "updateScreenSP()" und "tabController_KeyDown()" in der "Form"-Klasse verwendet.

# Console-Log-Data.txt
	- Speichern der Console.WriteLine Output to Text File
	- In der MainGameForm()-Methode ist die Logik dazu zu finden

# Projektrisiken
    - Durch „TabControl" die tabs wechseln ohne die Wechseln it den „Keys" zu betätigen
    - Erstellung der „Singleplayer- und Multiplayermodus" mit WASD und Arrow Keys
    - Nach Schinken Bild ("Ham Image") uploads anstatt roter Punkt für "food" -> system.outofmemoryexception 

# Projektrisiken
    - Durch "TabControl" die Tabs wechseln, ohne die mit den "Keys" zu betätigen
    - Erstellung der „Singleplayer- und Multiplayermodus" mit WASD und Arrow Keys
    - Nach "HamImage" Uploads anstatt roter Punkt für "food" -> system.outofmemoryexception (noch nicht gelöst)

# Vorgangsliste
	- Skizze anfertigen für die Tab Screens
	- Überlegung Konsolen- oder Gui-basierend programmieren
	- Planung Objektorientierte Programmierung (OOP)
	- Windows Forms erstellt
	- Ereignisse erstellt
	- Klassen erstellt
	- Backend programmiert
	- Singleplayer- und Multiplayermodus
	- Name für das Spiel erfunden und logo erstellt
	- Windows Forms gestaltet

# Zeitplan (Milestones)
	30min	2 UML-Diagramme von 2 verschiedenen Klassen
	20h	Coden
	4h	Dokumentation erstellen
	2h	Präsentation erstellen

# Diskussion/Fazit
Schlussfolgernd lässt sich feststellen, dass das Erstellen des "Snake Game" in Einzelspieler und Multispielermodus erzielt wurde. Somit ist die Möglichkeit eines Computerspieles wie "Snake Game", nicht nur allein, sondern auch gegen einen anderen Spieler zu spielen.
