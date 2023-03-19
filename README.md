# HAM Game („Snake Game")

# Motivation
Bei meiner Wahl der Entscheidung, welches Spiel ich nachbauen wollte, half mir der Rückblick, wie ich damals an einem alten NOKIA Smartphone, diesen "Snake Game" gespielt hatte. Welches durch viele verschiedene Iterationen im Laufe der Jahre ging, aber das Spiel ist immer noch eine Menge Spaß. Somit erstellte ich das "Snake Game" in Visual Studio mit der Windows Form Application Vorlage. Und kam, mit einer Freundin, auf den Namen „HAM" für das "Snake Game". "HAM" ist übersetzt auf Englisch Schinken, worauf ich mit meinen Klassenkameraden auf die Idee kam, anstatt einem roten Punkt, was die Schlange aufrisst, das Schinken zu nehmen. Dies wiederum ein Zusatz ist. Ebenfalls hab ich mich für eine Multiplayer-Modus entschieden zu programmieren, was der klassische "Snake Game" nicht hatte.

# Projektstrukturplan
Das Projekt besteht aus zwei "Windows Forms", einer "TabControl" und aus vielen Klassen, die dynamisch importiert oder aus dem Spiel entfernt werden können. Die objektorientierte Programmierung (OOP) erleichtert die Unterteilung durch die Klassen, sodass nicht alles in einer Datei codiert werden müsste. Die zwei "Windows Forms" sind "MainGameForm" und "HelpForm". Der "MainGameForm" enthält auch den "TabControl", der wiederum 3 Tabs sich beihaltet. Der erste Tab ist die Startseite ("StartPage") mit dem Startbutton, welches nach dem Klick auf das zweite Tab führt. Der zweite Tab ist die Spieler Auswahlseite ("PlayerChoicesPage"). Auf der Seite sind drei weitere Buttons zu sichten, mit dem du den Einzelspieler ("Singleplayer") oder den Multispieler ("Multiplayer") auswählen kannst, die dann zu dem dritten Tab führen. Der dritte Tab ist die Spielseite ("SPAndMPGame"), die sich durch den Spielermodus variiert. Ebenfalls ist es möglich das Spiel mit der "Enter-Key" erneut zu starten und mit der "esc-Key" von der Spielseite zur Auswahlseite zu wechseln. Der dritte Button, mit dem Namen "Help", welches dann eine erneute Form („HelpForm“) öffnet. Dieser Form beinhaltet die Anleitung zu dem Spiel, die vor dem Spiel gelesen werden sollte. 

Ziel des Spieles:
Der Spieler1 oder Spieler2 führt die Schlange zum Futter "food". Dazu verwenden die Spieler die Pfeiltasten "Arrow keys" oder "WASD keys" auf der Tatstatur. Wird der Happen berührt so verschwindet er, die Schlangen werden um einen Körperteil länger und irgendwo auf dem Spielplan erscheint ein neuer Futterhappen.

	Spieler1: GreenSnake
	Spieler2: BlueSnake
	Food: Roter Punkt/ Ham


Hinweis: Der Programmcode beeinhaltet Kommentare für ein besseres Verständins der Logik des Spieles

![image](https://user-images.githubusercontent.com/94457045/226036395-4e8fd28f-a99f-48c4-b328-32b51fbac66d.png)
![image](https://user-images.githubusercontent.com/94457045/226037062-adf2e4c4-957d-4a05-9d2a-50f9d06313c2.png)
![image](https://user-images.githubusercontent.com/94457045/226039202-fe8a547b-ec7c-4f16-91e3-9abccac5e4de.png)
![image](https://user-images.githubusercontent.com/94457045/226039362-4910d264-b5af-4c36-97e5-43769fdefc32.png)
![image](https://user-images.githubusercontent.com/94457045/226040950-ae5c04e0-b715-406e-8e22-a664f6c2b8a2.png)
![image](https://user-images.githubusercontent.com/94457045/226041050-db943f57-2459-4ca3-9ef6-bbf89402aed3.png)

	
# Anstatt 2 Struktogramme von Methoden -> 1 UML-Diagramme von einer Klasse und 1 Struktogramm von einer Methode der gleichen Klasse



# Beschreibung der Funktionalität 

Klassen (.cs):

-> Program.cs       
Die Program-Klasse ist der Haupteinstiegspunkt für die Anwendung und startet mit der "main()-Methode" das Programm bzw. Applikation/ Anwendung.

-> Circle.cs        
Die "Circle"-Klasse wird verwendet, um den Kopf und Körper der Schlangen zu berechnen und die X- und Y-Position des Schlangenobjekts zu geben. Dafür wird die public Int-Klasse namens X und public Int-Klasse Y erstellt. Die "Circle()-Methode" setzt X und Y auf 0 zurück. 

-> Input.cs         
Die "Input"-Klasse wird mit der Benutzereingabe verknüpft, zum Beispiel mit oben, unten, links oder rechts. Eine neue Instanz der "Hashtable"-Klasse wurde erstellt, um darin eingefügten "keys" zu optimieren. Die "KeyPress()-Methode" enthält die Funktion, die einen "key" der Klasse zurückgibt. Indem die If-Anweisung, wenn die "Hashtable" leer ist, wird als Booleanwert "false" und wenn sie nicht leer ist, "true" zurückgegeben, durchläuft. Eine weitere verwendete Methode in der "Input-Klasse" ist die "changeState()-Methode", die die Funktion hat, den Zustand der "keys" und des Spieler1 bzw. mehrere Spieler2 zu ändern.
        
-> Settings.cs      
Die "Settings-Klasse" wird verwendet, um die Höhe, Breite, Geschwindigkeit und andere Standard- "Settings" für das Spiel zu überprüfen. Ebenfalls wird hier eine Enum-Klasse namens "Directions" erstellt, die auch all die Richtungen wie links, rechts, oben und unten enthält. Die Klasse Settings setzt Int-Klassen wie "Width", "Height", "Speed", "GameOver" "Player1Score", "Player2Score" und "Points". Ebenfalls werden zwei Enum-Klassen wie "directionGreenSnake" und "directionBlueSnake" gesetzt. Die Default-Einstellungsfunktion der Settings-Klasse ist die "Settings()-Methode", in der die Variablen für die Standard-"Settings" mit dem Wert deklariert wurde.

-> MainGameForm.cs      
Diese Form-Klasse beinhaltet die ganze Spiellogik. Die "MainGameForm" (Windows Form) erstellte die "MainGameForm"-Klasse. In der Klasse wird zuerst eines Listen-Arrays für die zwei Schlangen („BlueSnake“ und „GreenSnake“) erstellt. Ebenfalls eine einzelne "Circle-Klasse" namens "food", ein Boolean "started" mit dem Wert "false" und eine variable "CurrentKeyPressedMainGamePage" mit dem Datentyp Int erstellt. Die "MainGameForm"()-Methode ist die Hauptmethode und verknüpft die "Settings"-Klasse mit der Form. Die Methode ändert die Spielzeit passend zu der "Settings speed" und verknüpft die "updateScreenSPMP()"- und "updateScreenSP()"-Methode mit dem "Timer". In der "MainGameForm()"-Methode wird der "Timer" gestartet und die "startGame()"-Methode ausgeführt. Dann kommen die "Buttons-Methoden" ("Start-", "Singleplayer-", "Multiplayer-" und "Help-Button"). Alle Buttons führen von einem Tab zu anderem Tab, außer die "Help-Button", sie führt zu der "HelpForm" (Windows Form). Die "updateScreenSPMP-" und "updateScreenSP"-Methoden, werden mit dem "Timer-Objekt" verknüpft. Die Funktion, der der beiden Methoden ist, falls zuerst überprüft wird, ob das Spiel vorbei ist, wird der Spieler1 oder Spieler2, die Eingabetaste drücken, um das Spiel neu zu starten und dann das Spiel erneut zu starten. Wenn das Spiel jedoch noch nicht vorbei ist, wird zuerst der Eingang der Spieler1 oder Spieler2 nach oben, unten, links und rechts überprüft. Später wird die definierte "movePlayer()"-Methode ausgeführt und dann die Funktion "pbCanvas.inalidate" (die "pictureBox") aufgerufen. Diese Funktion ermöglicht es, den "pictureBox") in Millisekunden zu aktualisieren, sodass es aussieht, als ob sich die Schlange im Spielbereich bewegt. Wenn diese Funktion nicht verwendet wird, dann hinterlässt die Schlange eine Spur von Punkten, wo sie sich bewegt, auf diese Weise werden wir alle nicht verwendeten „graphics“ durch die Bewegungen der Schlange entfernen. Die Methode "updateGraphics()", dass aus dem Ereignis "updateGraphics", der durch Option "Paint" für den "PictureBox" hinzugefügt wurde. Dient dazu, alle Grafiken hier zu malen und ebenfalls aus dem "pictureBox" zu entfernen. Deshalb wird die Funktion "pbCanvas.Invalidate()" im "Timer"-Ereignis verwendet. Auf diese Weise wird der Eindruck erweckt, dass der Spieler die Schlange im Spiel fließend bewegt. In dieser Methode werden die Farben für Kopf, Körper und Futter eingestellt und festgelegt, was passiert, wenn das Spiel vorbei ist. Wenn das Spiel zu Ende ist, wird auf dem Bildschirm die erforderlichen Informationen angezeigt. Die Methode "startGame()" wird ausgeführt, wenn das Spiel tatsächlich startet. Dafür wurde der Standardwert für das Spiel gesetzt, wenn es beginnt, einschließlich der Einrichtung des Kopfes und das Hinzufügen zu dem Array wird in der "startGame()"-Methode erstellt. Die Methode "generateFood()" erzeugt das "food icon" an einer zufälligen Stelle im Spielbereich. Die Methode "eat" wird ausgelöst, wenn die Schlange mit dem Futter kollidiert. Zugleich wird auch ein anderer Sektor zum Körper der Schlange hinzugefügt und der wird zum Schlangen-Array hinzugefügt. Die "die()"-Methode betätigt, was ihr Name besagt, sie wird das Spiel beenden, wenn sie ausgeführt wird. Normalerweise, wenn die Schlange entweder die Grenzen trifft oder mit den Körperteilen der Schlange kollidiert, wird das Spiel beendet. Mit der "tabController_KeyDown()"-Methode werden die Tabs entsprechend im Game gewechselt, wie zum Beispiel in Einzelspielermodus oder Mehrspielermodus. Ebenfalls aktiviert diese Methode die Keys nur auf dem Tab, wo der verschiedene Spielermodus befindet. Im Ganzem werden die Methoden "MainGameForm()", "startButton_Click_1()", "singlePlayerButton_Click()", "multiplayerButton_Click()", "helpButton_Click()", "updateGraphics()", "startGame()", "movePlayer1()", "movePlayer2()", "generateFood()", "eat()", "eat2()", "die()", "updateScreenSPMP()", "updateScreenSP()" und "tabController_KeyDown()" in der "Form"-Klasse verwendet.

# Projektrisiken
    - Durch „TabControl" die tabs wechseln ohne die Wechseln it den „Keys" zu betätigen
    - Erstellung der „Singleplayer- und Multiplayermodus" mit WASD und Arrow Keys
    - Nach Schinken Bild ("HamImage") uploads anstatt roter Punkt für "food" -> system.outofmemoryexception 

# Vorgangsliste
	- Skizze anfertigen für die Screens
	- Überlegung Konsolen- oder Gui-basierend programmieren
	- Plannung Objektorientierte Programmierung (OOP)
	- Windowsforms erstellt
	- Ereignisse erstellt
	- Klassen erstellt
	- Backend programmiert
	- Singleplayer- und Multiplayermodus
	- Name für das Spiel erfunden und logo erstellt
	- Windowsforms gestaltet

# Zeitplan (Milestones)
	30min	1 UML-Diagramme von einer Klasse und 1 Struktogramm von einer Methode der gleichen Klasse
	20h	Coden
	4h	Dokumentation erstellen
	2h	Präsentation erstellen

# Diskussion/Fazit
Schlussfolgernd lässt sich herausstellen, dass das Erstellen des "Snake Game" in Einzelspieler und Multispielermodus erzielt wurde. Somit ist die Möglichkeit eines Computerspieles wie "Snake Game", nicht nur allein, sondern auch gegen einen anderen Spieler zu spielen.
