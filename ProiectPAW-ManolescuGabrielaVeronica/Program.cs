using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AgendaDeActivitati());
        }
    }
}
//1. Adaug din toolbox: Label.. apoi dau click dr proprieters la label si la Text:label1 ii pun" Name Proiect:"

//2.Chenar de delimitat inserare nume etc. il gasim in tToolbox ->caut GroupBox si il trag pe aplicatia noastra(se face un chenar cu margini gri )
//Dau click dreapta pe GroupBox de pe aplicatie->proprietrs->la Text:groupbox1 il schimb cu Adaugare Proiect
//Deoarece cand maresc aplicatia nu se mareste si chenarul gri de la Gripul box: la Layout e Anchor->bifez si right(dreapta)
// 3.(tot din toolbox)->> pt a completa numele Proiectului pun un TextBox(casuta alba) 
////apoi dau click dr pe textbox(casuta alba) -> proprieters la Design am (Name) -> il schimb din textbox1 in tbNumeProiect(este text boxul pt numele proiectului)
///Adaug din toolbox: Label.. apoi dau click dr proprieters la label si la Text:label1 ii pun" Data de inceput a proiecului:"
/////Adaug din toolbox: Label.. apoi dau click dr proprieters la label si la Text:label1 ii pun" Data de Sfarsit a Proiectului:
/////4.Pt completarea datei de inceput->in toolbox caut DateTamePicker si il trag in aplicatie(aici selecteaza direct data)
///redenumesc -proirieters pe data de inceput si lal (name) pun dtpDataInceput si la celalalt pun dtpDataSfarsit
/// 
///5. Adaug din toolbox: Label.. apoi dau click dr proprieters la label si la Text:label1 ii pun" Cost Proiect::"//am modificat perioada proiect
//si tbCost
// 6.(tot din toolbox)->> pt a completa numele Proiectului pun un TextBox(casuta alba) 
//7.Adaug din toolbox UN buton->Caut Button si il itrag pe aplicatie
//apoi dau click dr pe button1 din aplicatie ->proprieters la text pun  Adaugare Proiect  DAR SI LA Design (NAME) ii pun btnAdaugareProiect
//

//
//8.Adaugare control(arata ca un tabel) in jos unde afisam participantii pe care ii adaugam
//Caut in toolbox : ListView->il trag in aplicatie si e un tabel alb patrat 
//Daca maresc aplicatia cand ruleaza tabelul ramane mic nu se mareste asa ca dau la click dreapta pe caseta alba din aplicatie->proprieters->Anchor pun si dreapta si in jos
//In dreapta sus in colt( la castea mare alba) am un triunghi si apas pe el->ListView Task->dau la View : Details->
//->apoi la Edit Colums incat sa adaugam niste coloane la acest control->ADD->La TEXT e CollumHedder si o schimb in Name
//la Width o maresc la 200
//Da din nou click pe ADD ->La text e CollumHedder si o schimb in Birth Date->la Width o maresc la 150//
//
//9. schimb la listview la caseta mare alba schimb Name din design in lvProiecte
////10.click dr pe tabela  mare alba listview si la GridLins pun true si apar linii grii in caseta alba
//
//11.Click dreapra pe butonul Aduugare Participanti->proprieters->dau pe fuger Events->dau dublu clic langa  Click in dreapta si apare o metoda 
//->private void btnAddParticipant_Click(object sender, EventArgs e)//in mainForm.cs
//
//
//12. Insa putem adauga persoana doar cu data si fara sa completeze nume: pot sa folosesc error provider
//Caut in ToolBox -ErrorProvider il trag oriunde in aplicatie->o sa apara jos errorProvider
//click dreapta pe ErrorProvider->propierters->la (NAme) ii pun errorProvider
//La Name Proiect: din aplicatie  :" click dr->proprieters->dau pe fulger Events-> am Validated si Validating(=e inaintea lui Validated)->
//->tratam Validating dublu click si apare o metoda   private void private void tbNumeProiect_Validating(object sender, CancelEventArgs e)
//
//
//
////Din toolbox adauga 1 button pt List 
//dau click dr -proprieters ii pun la (name)  btnLista si la text Lista..am adaugat si detalii la fel
//
//
////13.iau din Toolbox , caut MenuStrip si il trag(drag) in aplicatie
//dau clic pe el direct din aplicatie si scriu File , Exit mai jos-min 1:38
//Pe exit click dreapta ->proprietersc pe exit->ii schimba(Name) - in btnExit
//Dau dublu click pe Exit din aplicatie si apare o metoda : private void btnExit_Click(object sender, EventArgs e) il refac ultimul cu iesire!!
//
//
///14.Serializarea XML:::min 2:11
//Merg in aplicatie la Meniu MAin From langa scru Fisier XML
//Si ii pun la fel in jos pun Serializare si Deserializare
//click dreapta pe Serializare->proprieters->la (NAME) ii pun btnSerializareXML
//click dreapta pe Deserializare->proprieters->la (NAME) ii pun btnDeserializareXML
//
///15. Dublu clik pe Serialize direct din aplicatie si apare o metoda:  private void btnSerializeXML_Click(object sender, EventArgs e)
//Dupa ce am scris metoda->Dau in aplicatie la Binary Serialization Deserialize-> apoi in XML Serialization ->SErialize -> si dau click dr pe proiectul id_9 Open Folder in File Explorer
//intru in bin->Debug->si apare serialized.xml  si il deschid cu notepad
//e mult mai usor de inteles codul in xml, putem procesa usor in orice limbaj
////negativ: are mult continut fata de fisierul binar
//
///16.Dublu clik pe Deserialize direct din aplicatie si apare o metoda:private void btnDeserializeXML_Click(object sender, EventArgs e)
////In folderul din Open file explorer- bin -debug- serialized.xml pot modifica numele-dau Save-> si cand dau Deserialize din aplicatie apar modificati
//
//17.lucru cu Fisiere text--3. TextFiles-min 2:30
//Vrem sa exportam in fisier text ddatele din aplicatia noastra:
//Sa exportam un fisier text care sa aiba pe fiecare linie cate un participant cu datele aferente acelui participant, separate prin virgula,
//Merg in main form(aplicatia noastra) si mai adaug direct pe aplicatie sus (langa Fiere xml) scriu Export
//->clic dreapta pe Export ->proprieters->la (Name) pun btnExport
///Apoi dublu click pe Export pt a adauga metoda :private void btnExport_Click(object sender, EventArgs e)
//Dupa ce am facut metoda si dau export imi apare o fereasta in colt stanga pe bara  apare :Export as csv si jos la Save type as:CSV
//
//
//
//======> Github ---SEMINAR 8 GITHUB: 08 - WinForms - Dialogs.md
//Lucrul cu fereste de dialog
//Adaugal la apicatia noastra posibilitatea de a Edita si de a Sterge intrari!!
//!! de adaugat Buton de Edit si buton de Delete!!
//
////26. adaug din toolbox un button jos in aplicatie 
//Dau click dreapta pe button1 si la text il scriu Stergere
//La (Name) ii pun btnStergere
//Mai adaug inca un buton din toolbox un button tot jos in aplicatie 
//Dau click dreapta pe button2 si la text il scriu Editare
//La (Name) ii pun btnEditare
//
///Modificam modeul de selectie din Aplicatia noastra sa putem   da click oriunde pt a selecta nu doar pe prima coloana, pe coloana cu data nu merge  sa selectezi
//dau clic pe Listview adica pe tabelul mare alb unde apar participantii->proprieters
//->La FullRowSelect: cand e false selectez doar prima coloana pt a selecta daca e true putem da oriunde clic in cadrul randului si se selecteaza tot randul 
//
//
///Continurae: /26. pentru butonul de Stergere .. sa pot selecta din aplicatie participantul si sa dau click pe delete pt a-l sterge
//dau dublu click pe butonul din aplicatie direct Stergere si apare metoda: private void btnDelete_Click(object sender, EventArgs e)
//
//
//
//
//
//
////
//05:Creare baza de date in aplicatia DB Browser for SQLite.exe
//dau sus in colt, stanga primul buton ->New Database
//-ne intreaba unde vrem sa salvam baza de date: salvez baza de date direct in folderul proiectului PAw
//-in folderele cu bin obj etc si el o salzeaza cu "db"-Save si s-a creat baza de date
//-se afiseaza un ecran de unde  pot crea tabele:pot pune numele tabelei, el da Cancel
//->dau pe butonul Execut SQL- ia codul copy paste de pe github de creare tabel punctul 3,,, seminar 10
//si il pune in feresastra de la Execut SQL-si dau pe prima sageata simpla albastra
//- si dupa dau pe butonul de sus Write Changes pt a scrie datele pe disc in acel fisier
//In Database Structure avem tabelul participanti cu coloanele
//
////06.De adaugat pachetele pt a putea interactiona cu aceasta baza de date
//MA duc in Visual Studio la proiect iar in partea de sus avem Show all files-dau pe el
//->si ar trebui sa apara fisierul "db.db"->clicl dreapta pe el si dau - Include in Project
////-Mai intai dau pe Solution "ListViewSimple (deasupra proiectului) un CTRL+S
//-Apoi clic dreapta pe proiect ListViewSample->dau pe Manage NuGet Packages
//dau pe Browse
//-Aici trebuie sa salvam o librarie externa numele ei e pe github: dau la search: System.Data.SQLite.Core
//dau click pe ea si Install 
//Acum la References in stanga au aparut mai multe
//
////06.Dau clic dreapta pe fisierul bazaDeDate.db ->propertiers->si la Copy to output directry dau : Copy if Newer
//dau click dreapta pe proiet-Open folder in file explorer->bin->bin-debug avem fisierul db.db
//Scriem cod in VS: dau pe mainFrom.cs
//
//
//
////27..Editarea-->
//Pt editare ne trebuie unformular separat!!
//dau click dreapta pe proiectul din dreapta id_9 ->Add-> Form(Windows Form)->il numeste  EditareProiect.cs
//pe langa Main form o sa avem si formularul EditForm
//
////Copiez din prima aplicatie Name cu casuta si Birth Date cu casuta CTRL+C si CTRL  V in Edit Form.cs(cealalta aplicatie
//Din toolbox adaug 2 button (butoane) pt OK si Cancel
//click dreapta pe primul button ->proprieters si la (NAME) btnAnulatre si la text ii pun Cancel
//lick dreapta pe al 2 lea  button ->proprieters si la (NAME) btnSalvare si la text ii pun OK
//
////29.Cand dam ingregistrare participant in aplicatie si dam Edit sa apara acel formular de editare:
//Dublu clik pe butonul edit din colt dreapta din aplicatia 1 -pt a crea o metoda: private void btnEdit_Click(object sender, EventArgs e)
//
//
////30.Atunci cand se deschide formularul de Edit sa apara in campurile Edit Numele si data nasterii-datele participantului selectat pt editare
//in seminar 08 github
//31.Daca dau dublu clic pe apliatia2 Editare Proiect apare metoda private void EditareProiect_Load(object sender, EventArgs e)
//32.Bara de sus de la EditFrom vreau sa modific numele si dau ->proprietres->la Text ii pun : "Edit Proiect"
//
////33. Cand dau pe butonul Cancel sa se inchida aplicatia de editare: 
//Din aplicatia form Edit pareticipant pe butonul de Cancel->proprieters->Dialog Resuly bifez Cancel (inchide aplicatia edit cu Cancel cand e apasat)
////34.Butonul de OK din Edit participants aplicatia 2, >proprieters->Dialog Resuly bifez OK
////dar nu actualizeaza datele, pt asta dau dublu clik pe butonu OK din Edit si apare metoda : private void btnOK_Click(object sender, EventArgs e)
//
//010.Dau dublu clik pe butonul de stergere dar mai sus fac o alta metoda cu stergerea din DB
//
//
//
//pt form  Activitati::
//1.dau click dreapta pe proiectul din dreapta id_9 ->Add-> Form(Windows Form)->il numeste  FormActivitati.cs
////2.Chenar de delimitat inserare nume etc. il gasim in tToolbox ->caut GroupBox si il trag pe aplicatia noastra(se face un chenar cu margini gri )
//Dau click dreapta pe GroupBox de pe aplicatie->proprietrs->la Text:groupbox1 il schimb cu Adaugare Activitate
//Deoarece cand maresc aplicatia nu se mareste si chenarul gri de la Gripul box: la Layout e Anchor->bifez si right(dreapta)
//
// Adaug din toolbox: Label.. apoi dau click dr proprieters la label si la Text:label1 ii pun" Name activitate:"
//// 3.(tot din toolbox)->> pt a completa numele Proiectului pun un TextBox(casuta alba)
/////apoi dau click dr pe textbox(casuta alba) -> proprieters la Design am (Name) -> il schimb din textbox1 in tbNumeProiect(este text boxul pt numele proiectului)
//dtpDataActivitati- pt data
/////4.Pt completarea datei de inceput->in toolbox caut DateTamePicker si il trag in aplicatie(aici selecteaza direct data)
///redenumesc -proirieters pe data de inceput si lal (name) pun dtpDataInceput si la celalalt pun dtpDataSfarsit
//
//in toolbox caut COMBOBOX - PT ENUM- il redednumesc in cbDomenii
//
//7.Adaug din toolbox UN buton->Caut Button si il itrag pe aplicatie
//apoi dau click dr pe button1 din aplicatie ->proprieters la text pun  Adaugare Proiect  DAR SI LA Design (NAME) ii pun btnAdaugareProiect
//
//Caut in toolbox : ListView->il trag in aplicatie si e un tabel alb patrat 
//Daca maresc aplicatia cand ruleaza tabelul ramane mic nu se mareste asa ca dau la click dreapta pe caseta alba din aplicatie->proprieters->Anchor pun si dreapta si in jos
//In dreapta sus in colt( la castea mare alba) am un triunghi si apas pe el->ListView Task->dau la View : Details->
//->apoi la Edit Colums incat sa adaugam niste coloane la acest control->ADD->La TEXT e CollumHedder si o schimb in Name
//la Width o maresc la 200
//Da din nou click pe ADD ->La text e CollumHedder si o schimb in Birth Date->la Width o maresc la 150//
//
///9.redenumesc  listview la caseta mare alba schimb Name din design in lvActivitati
//
////10.click dr pe tabela  mare alba listview si la GridLins pun true si apar linii grii in caseta alba
//
//11.Click dreapra pe butonul Aduugare Participanti->proprieters->dau pe fuger Events->dau dublu clic langa  Click in dreapta si apare o metoda 
//->private void btnAddParticipant_Click(object sender, EventArgs e)//in mainForm.cs
//
//13.Click dreapra pe butonul Adaugare activitate->proprieters->dau pe fuger Events->dau dublu clic langa  Click in dreapta si apare o metoda 
//->private void btnAdaugaActivitate_Click(object sender, EventArgs e)//in mainForm.cs
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//

